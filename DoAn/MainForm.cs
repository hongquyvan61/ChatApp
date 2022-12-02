using DoAn.DTO;
using GOI;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn
{
    public partial class MainForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager manager;
        private TcpClient client;
        private StreamReader sr;
        private StreamWriter sw;
        private Thread trdClient;
        private Thread trdtaonhom;
        private IPEndPoint iep;
        private bool thoat;
        private string usrname, pwd, receiv;
        private string firstitemstr;
        private List<int> listvitrihinh = new List<int>();
        private static int vitri = 0;
        public MainForm(TcpClient client)
        {
            InitializeComponent();
            
            this.usrname = Shared.taikhoan;
            this.pwd = Shared.matkhau;
            this.client = client;
            sr = new StreamReader(client.GetStream());
            sw = new StreamWriter(client.GetStream());
            NhanTinNhan();
           
            //CODE UI//
            manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = false;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //manager.ColorScheme = new ColorScheme(
            //Primary.DeepOrange300, Primary.BlueGrey900,
            //Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            manager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void drawitem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.menutab.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.menutab.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.menutab.Font, Brushes.Black, x, y);
        }

        private void NhanTinNhan()
        {
            trdClient = new Thread(new ThreadStart(() => ThreadTask(sr, sw)));
            trdClient.IsBackground = true;
            trdClient.Start();
        }

        private void AppendTextBox(string value, string type)
        {
            khungchat.BeginInvoke(new MethodInvoker(() =>
            {
                if(type == "gui")
                {
                    khungchat.AppendText(Environment.NewLine + value);
                    khungchat.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    khungchat.AppendText(Environment.NewLine + value);
                    khungchat.SelectionAlignment = HorizontalAlignment.Left;
                }
            }));
        }
        private void AppendTextBoxgr(GOI.TINNHANGR tinnhangr, string type)
        {
            khungchatgr.BeginInvoke(new MethodInvoker(() =>
            {
                if (type == "gui")
                {
                    khungchatgr.AppendText(Environment.NewLine + tinnhangr.content);
                    khungchatgr.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    khungchatgr.AppendText(Environment.NewLine +tinnhangr.usernameSender+":"+ tinnhangr.content);
                    khungchatgr.SelectionAlignment = HorizontalAlignment.Left;
                }
            }));
        }

        private void AppendImageToTextBoxLeft(byte[] manghinh)
        {
            khungchat.BeginInvoke(new MethodInvoker(() =>
            {
                MemoryStream memoryStream = new MemoryStream(manghinh);
                Image hinh = Image.FromStream(memoryStream);
                Clipboard.SetImage(hinh);
                khungchat.ReadOnly = false;
                if (khungchat.Lines.Length != 0)
                {
                    khungchat.SelectionStart = listvitrihinh[vitri];
                    vitri += 1;
                }
                khungchat.Paste();
                khungchat.SelectionAlignment = HorizontalAlignment.Left;
                khungchat.AppendText(Environment.NewLine);
                khungchat.ReadOnly = true;
            }));
        }

        private void SenderAppendImageToTextBoxLeft(byte[] manghinh)
        {
            khungchat.BeginInvoke(new MethodInvoker(() =>
            {
                MemoryStream memoryStream = new MemoryStream(manghinh);
                Image hinh = Image.FromStream(memoryStream);
                Clipboard.SetImage(hinh);
                khungchat.ReadOnly = false;
                khungchat.AppendText(Environment.NewLine + " ");
                if (khungchat.Lines.Length != 0)
                {
                    khungchat.SelectionStart = khungchat.GetFirstCharIndexOfCurrentLine();
                    vitri += 1;
                }
                khungchat.Paste();
                khungchat.SelectionAlignment = HorizontalAlignment.Left;
                khungchat.AppendText(Environment.NewLine);
                khungchat.ReadOnly = true;
            }));
        }

        private void AppendImageToTextBoxRight(byte[] manghinh)
        {
            khungchat.BeginInvoke(new MethodInvoker(() =>
            {
                MemoryStream memoryStream = new MemoryStream(manghinh);
                Image hinh = Image.FromStream(memoryStream);
                Clipboard.SetImage(hinh);
                khungchat.ReadOnly = false;
                if (khungchat.Lines.Length != 0)
                {
                    khungchat.SelectionStart = listvitrihinh[vitri];
                    vitri += 1;
                }
                khungchat.Paste();
                khungchat.SelectionAlignment = HorizontalAlignment.Right;
                khungchat.AppendText(Environment.NewLine);
                khungchat.ReadOnly = true;
            }));
        }

        private bool IsValidPath(string path, bool exactPath = true)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (exactPath)
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
                else
                {
                    isValid = Path.IsPathRooted(path);
                }
            }
            catch (Exception ex)
            {
                isValid = false;
            }

            return isValid;
        }

       

        private void ShowAllMes(List<KeyValuePair<string, string>> dic)
        {
            khungchat.BeginInvoke(new MethodInvoker(() =>
            {
                khungchat.Clear();
                var list = dic.ToList();
                listvitrihinh.Clear();
                vitri = 0;
                foreach(var item in list)
                {
                    string doituong = item.Key.Substring(0, item.Key.IndexOf("@"));
                    if(doituong == "sender")
                    {
                        try
                        {
                            if (IsValidPath(item.Value))
                            {
                                khungchat.AppendText(Environment.NewLine + " ");
                                listvitrihinh.Add(khungchat.GetFirstCharIndexOfCurrentLine());

                                GOI.LAYHINH userlayhinh = new GOI.LAYHINH(usrname, item.Value, "sender");
                                string userlayhinhstr = JsonSerializer.Serialize(userlayhinh);
                                GOI.THUONG goilayhinh = new GOI.THUONG("userlayhinh", userlayhinhstr);
                                sendJson(goilayhinh);

                                khungchat.AppendText(Environment.NewLine);
                            }
                            else
                            {
                                khungchat.AppendText(Environment.NewLine + item.Value);
                                khungchat.SelectionAlignment = HorizontalAlignment.Right;
                                khungchat.AppendText(Environment.NewLine + " ");
                                khungchat.AppendText(Environment.NewLine);
                                
                            }
                        }
                        catch(Exception ex)
                        {

                        }
                        
                    }
                    else
                    {
                        try
                        {
                            if (IsValidPath(item.Value))
                            {
                                khungchat.AppendText(Environment.NewLine + " ");
                                listvitrihinh.Add(khungchat.GetFirstCharIndexOfCurrentLine());
                                //test commit
                                GOI.LAYHINH userlayhinh = new GOI.LAYHINH(usrname, item.Value, "receiver");
                                string userlayhinhstr = JsonSerializer.Serialize(userlayhinh);
                                GOI.THUONG goilayhinh = new GOI.THUONG("userlayhinh", userlayhinhstr);
                                sendJson(goilayhinh);

                                khungchat.AppendText(Environment.NewLine);
                            }
                            else
                            {
                                khungchat.AppendText(Environment.NewLine + item.Value);
                                khungchat.SelectionAlignment = HorizontalAlignment.Left;
                                khungchat.AppendText(Environment.NewLine + " ");
                                khungchat.AppendText(Environment.NewLine);
                            }
                        }
                        catch(Exception ex)
                        {

                        }
                        
                    }
                }
                 //KeyValuePair<string, string> temp = new KeyValuePair<string, string>(list[i].Key, list[i].Value);
                //foreach (var item in dic)
                //{
                //    if (item.Key == usrname)
                //    {
                //        List<string> lsmessage = dic[item.Key];
                //        foreach (var mes in lsmessage)
                //        {
                //            khungchat.AppendText(Environment.NewLine + mes);
                //            khungchat.SelectionAlignment = HorizontalAlignment.Right;
                //        }
                //    }
                //    else
                //    {
                //        List<string> lsmessage = dic[item.Key];
                //        foreach (var mes in lsmessage)
                //        {
                //            khungchat.AppendText(Environment.NewLine + mes);
                //            khungchat.SelectionAlignment = HorizontalAlignment.Left;
                //        }
                //    }
                //}
            }));
        }
        private void ShowAllMesgr(List<KeyValuePair<string, string>> dic)
        {
            khungchatgr.BeginInvoke(new MethodInvoker(() =>
            {
                khungchatgr.Clear();
                var list = dic.ToList();
                listvitrihinh.Clear();
                vitri = 0;
                foreach (var item in list)
                {
                    string[] mang = item.Key.Split("@");
                    if (mang[0] == "sender")
                    {
                        try
                        {
                            if (IsValidPath(item.Value))
                            {
                                khungchatgr.AppendText(Environment.NewLine + " ");
                                khungchat.AppendText(Environment.NewLine);
                            }
                            else
                            {
                               
                                khungchatgr.AppendText(Environment.NewLine + item.Value);
                                khungchatgr.SelectionAlignment = HorizontalAlignment.Right;
                                khungchatgr.AppendText(Environment.NewLine + " ");
                                khungchatgr.AppendText(Environment.NewLine);

                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                    else
                    {
                        try
                        {
                            if (IsValidPath(item.Value))
                            {
                                khungchatgr.AppendText(Environment.NewLine + " ");
                                khungchatgr.AppendText(Environment.NewLine);
                            }
                            else
                            {
                                khungchatgr.AppendText(Environment.NewLine + mang[2]+":" + item.Value);
                                khungchatgr.SelectionAlignment = HorizontalAlignment.Left;
                                khungchatgr.AppendText(Environment.NewLine + " ");
                                khungchatgr.AppendText(Environment.NewLine);
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }
                }
               
            }));
        }
        private void AppendTabUser(List<User> ls)
        {
            tabuser.BeginInvoke(new MethodInvoker(() =>
            {
                tabuser.Items.Clear();
                foreach (var u in ls)
                {
                    if(u.name != usrname)
                    {
                        tabuser.Items.Add(u.ToString(),0);
                    }
                }
                tabuser.Items[0].Selected = true;
                tabuser.Items[0].Focused = true;
            }));
            
        }
        private void AppendTabGroup(List<Group> ls)
        {
            listgroup.BeginInvoke(new MethodInvoker(() =>
            {
                listgroup.Items.Clear();
                foreach (var g in ls)
                {
                    
                    
                        listgroup.Items.Add(g.ToString(), 0);
                    
                }
                listgroup.Items[0].Selected = true;
                listgroup.Items[0].Focused = true;
            }));

        }

        private void btngui_Click(object sender, EventArgs e)
        {
            if(txtchat.Text.Length != 0)
            {
                string itemstr = tabuser.SelectedItems[0].Text;
                string receiver = itemstr.Substring(itemstr.IndexOf(" ") + 1);
                GOI.TINNHAN mes = new GOI.TINNHAN(usrname, receiver, txtchat.Text);
                string jsonString = JsonSerializer.Serialize(mes);
                GOI.THUONG common = new GOI.THUONG("tinnhan", jsonString);
                sendJson(common);
                AppendTextBox(txtchat.Text, "gui");
            }
            txtchat.Clear();
        }

        private void sendJson(object obj)
        {
            string jsonStringgui = JsonSerializer.Serialize(obj);
            //client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            sw.WriteLine(jsonStringgui);
            sw.Flush();
        }

        private void openLoginForm()
        {
            Application.Run(new Form1());
        }

        

        private void btnguihinh_Click(object sender, EventArgs e)
        {
            //MO DIALOG CHON HINH//
            OpenFileDialog layhinh = new OpenFileDialog();
            layhinh.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            layhinh.Multiselect = false;
            string path = "";
            string tenhinh = "";
            object clipboarddata = Clipboard.GetDataObject;
            khungchat.AppendText(Environment.NewLine + " ");

            //CLEAR LIST VI TRI HINH //
            listvitrihinh.Clear();
            vitri = 0;
            if (layhinh.ShowDialog() == DialogResult.OK)
            {
                path = layhinh.FileName;
                string imagepath = path.ToString();
                imagepath = imagepath.Substring(imagepath.LastIndexOf("\\"));
                tenhinh = imagepath.Remove(0, 1);

                Image hinh = Image.FromFile(path);
                Image hinhresize = (Image)ResizeImage(hinh, 150, 150);
                Clipboard.SetImage(hinhresize);
                khungchat.ReadOnly = false;
                khungchat.AppendText(Environment.NewLine+" ");
                if (khungchat.Lines.Length != 0)
                {
                    
                    khungchat.SelectionStart = khungchat.GetFirstCharIndexOfCurrentLine();
                }
                khungchat.Paste();
                khungchat.SelectionAlignment = HorizontalAlignment.Right;
                khungchat.ReadOnly = true;
                
                Clipboard.SetDataObject(clipboarddata);

                //GUI HINH QUA TCPCLIENT//
                byte[] bStream = ImageToByte(hinhresize);
                string itemstr = tabuser.SelectedItems[0].Text;
                string receiver = itemstr.Substring(itemstr.IndexOf(" ") + 1);
                GOI.GUIHINH guihinh = new GOI.GUIHINH(usrname, receiver, bStream, tenhinh);
                string guihinhstr = JsonSerializer.Serialize(guihinh);
                GOI.THUONG goi = new GOI.THUONG("guihinhchoclient", guihinhstr);
                sendJson(goi);
            }
        }

        private static byte[] ImageToByte(Image iImage)
        {
            MemoryStream mMemoryStream = new MemoryStream();
            iImage.Save(mMemoryStream, ImageFormat.Png);
            return mMemoryStream.ToArray();
        }
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void tabuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var arr = tabuser.SelectedItems;
                //foreach(var item in arr)
                //{
                //    var templiv = (ListViewItem)item;
                //    string txt = templiv.SubItems[0].Text;
                //    GOI.GETMES getmes = new GOI.GETMES(usrname, receiv);
                //    string getmesstr = JsonSerializer.Serialize<GOI.GETMES>(getmes);
                //    GOI.THUONG goi = new GOI.THUONG("getallmes", getmesstr);
                //    sendJson(goi);
                //    break;
                //}
                if (tabuser.SelectedIndices.Count > 0)
                {
                    string itemstr = tabuser.Items[tabuser.SelectedIndices[0]].Text;
                    receiv = itemstr.Substring(itemstr.IndexOf(" ") + 1);
                    GOI.GETMES getmes = new GOI.GETMES(usrname, receiv);
                    string getmesstr = JsonSerializer.Serialize<GOI.GETMES>(getmes);
                    GOI.THUONG goi = new GOI.THUONG("getallmes", getmesstr);
                    sendJson(goi);
                }
                //if (tabuser.FocusedItem == null) return;
                //int p = tabuser.FocusedItem.Index;

            }
            catch (Exception ex)
            {

            }
        }

        private void btntaonhom_Click(object sender, EventArgs e)
        {
            //TaoNhom formtaonhom = new TaoNhom();
            //formtaonhom.ShowDialog();
            trdtaonhom = new Thread(openFormTaoNhom);
            this.Close();
            trdtaonhom.SetApartmentState(ApartmentState.STA);
            trdtaonhom.Start();
        }

        private void openFormTaoNhom(object obj)
        {
            Application.Run(new TaoNhom(usrname));
        }

        private void txtchat_TextChanged(object sender, EventArgs e)
        {

        }

        private void listgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (listgroup.SelectedIndices.Count > 0)
                {
                    string itemstr = listgroup.Items[listgroup.SelectedIndices[0]].Text;
                    receiv = itemstr.Substring(itemstr.IndexOf(" ") + 1);
                    GOI.GETMES getmes = new GOI.GETMES(usrname, receiv);
                    string getmesstr = JsonSerializer.Serialize<GOI.GETMES>(getmes);
                    GOI.THUONG goi = new GOI.THUONG("getallmesgr", getmesstr);
                    sendJson(goi);
                }
                //if (tabuser.FocusedItem == null) return;
                //int p = tabuser.FocusedItem.Index;

            }
            catch (Exception ex)
            {

            }
        }

        private void gui_Click(object sender, EventArgs e)
        {
            if (txttn.Text.Length != 0)
            {
                string itemstr = listgroup.SelectedItems[0].Text;
                string receiver = itemstr.Substring(itemstr.IndexOf(" ") + 1);
                GOI.TINNHANGR mes = new GOI.TINNHANGR(usrname, receiver, txttn.Text);
                string jsonString = JsonSerializer.Serialize(mes);
                GOI.THUONG common = new GOI.THUONG("tinnhangr", jsonString);
                sendJson(common);
                AppendTextBoxgr(mes, "gui");
            }
            txttn.Clear();
        }

        private void khungchatgr_TextChanged(object sender, EventArgs e)
        {

        }

        private void menutab_Selected(object sender, TabControlEventArgs e)
        {

            try
            {
                if (e.TabPageIndex == 2)
                {
                    DialogResult dr = MessageBox.Show("Ban co chac chan muon dang xuat?",
                      "Dang xuat", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        GOI.THUONG logout = new GOI.THUONG("logout", usrname);
                        sendJson(logout);
                        this.Close();
                        Shared.taikhoan = "";
                        Shared.matkhau = "";
                        Thread loginformThread = new Thread(openLoginForm);
                        loginformThread.SetApartmentState(ApartmentState.STA);
                        loginformThread.Start();
                    }
                }
                if (e.TabPageIndex == 1)
                {
                        GOI.THUONG laygroup = new GOI.THUONG("getallgroup", usrname);
                        sendJson(laygroup);
                    //this.Close();
                    //Shared.taikhoan = "";
                    //Shared.matkhau = "";


                }
            }
            catch(Exception ex)
            {
                
            }
        }


        private void ThreadTask(StreamReader sr, StreamWriter sw)
        {
            string jsonString = "";
            THUONG layuser = new THUONG("getonlineusers", usrname);
            sendJson(layuser);

            try
            {
                while (!thoat)
                {

                    jsonString = sr.ReadLine();
                    //jsonString=jsonString.Replace("\\u0022", "\"");
                    //jsonString = jsonString.Replace("\0", "");
                    THUONG goi = JsonSerializer.Deserialize<GOI.THUONG>(jsonString);

                    if (goi != null)
                    {
                        switch (goi.kind)
                        {
                            case "tinnhan":
                                TINNHAN? mes = JsonSerializer.Deserialize<GOI.TINNHAN>(goi.content);
                                AppendTextBox(mes.content,"nhan");
                                break;
                            case "tinnhangr":
                                TINNHANGR? mesgr = JsonSerializer.Deserialize<GOI.TINNHANGR>(goi.content);
                                AppendTextBoxgr(mesgr, "nhan");
                                break;
                            case "getonlineusers":
                                if (goi.content != null)
                                {
                                    List<User> ls = JsonSerializer.Deserialize<List<User>>(goi.content);
                                    AppendTabUser(ls);
                                }
                                break;
                            case "getallgroup":
                                if (goi.content != null)
                                {
                                    List<Group> ls = JsonSerializer.Deserialize<List<Group>>(goi.content);
                                    AppendTabGroup(ls);
                                }
                                break;
                            case "getallmes":
                                List<KeyValuePair<string, string>> dicmes = JsonSerializer.Deserialize<List<KeyValuePair<string, string>>>(goi.content);
                                ShowAllMes(dicmes);
                                break;
                            case "getallmesgr":
                                List<KeyValuePair<string, string>> dicmesgr = JsonSerializer.Deserialize<List<KeyValuePair<string, string>>>(goi.content);
                                ShowAllMesgr(dicmesgr);
                                break;
                            case "guihinhchoclient":
                                if(goi.content != null)
                                {
                                    GOI.GUIHINH guihinh = JsonSerializer.Deserialize<GOI.GUIHINH>(goi.content);
                                    SenderAppendImageToTextBoxLeft(guihinh.manghinh);
                                }
                                break;
                            case "trahinhtusv":
                                {

                                    if (goi.content != null)
                                    {
                                        
                                            GOI.TRAHINH guihinhtuSV = JsonSerializer.Deserialize<GOI.TRAHINH>(goi.content);

                                            if (guihinhtuSV.type == "sender")
                                            {
                                                AppendImageToTextBoxRight(guihinhtuSV.manghinh);
                                            }
                                            else
                                            {
                                                AppendImageToTextBoxLeft(guihinhtuSV.manghinh);
                                            }
                                    }
                                }
                                break;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Da dang xuat hoac loi mang!");
            }
        }
    }
}
