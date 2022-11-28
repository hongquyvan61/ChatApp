using DoAn.DTO;
using GOI;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class TaoNhom : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager manager;
        private TcpClient client;
        private Thread trdtaonhom;
        private Thread trdMainForm;
        private StreamReader sr;
        private StreamWriter sw;
        private string usrname;
        private bool thoat;
        public TaoNhom(string usrname)
        {
            InitializeComponent();
            client = Shared.server;
            sr = new StreamReader(client.GetStream());
            sw = new StreamWriter(client.GetStream());
            this.usrname = usrname;
            NhanGoiTuServer();
            //CODE UI
            manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.EnforceBackcolorOnAllComponents = false;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //manager.ColorScheme = new ColorScheme(
            //Primary.DeepOrange300, Primary.BlueGrey900,
            //Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            manager.ColorScheme = new MaterialSkin.ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.LightBlue200, TextShade.WHITE);
        }

        private void NhanGoiTuServer()
        {
            trdtaonhom = new Thread(new ThreadStart(() => ThreadTask(sr, sw)));
            trdtaonhom.IsBackground = true;
            trdtaonhom.Start();
        }

        private void sendJson(object obj)
        {
            string jsonStringgui = JsonSerializer.Serialize(obj);
            //client.Send(jsonUtf8Bytes, jsonUtf8Bytes.Length, SocketFlags.None);
            sw.WriteLine(jsonStringgui);
            sw.Flush();
        }

        private void btntimuser_Click(object sender, EventArgs e)
        {
            string usercansearch = txtsearchuser.Text.Trim();
            GOI.SEARCHUSER goisearchuser = new GOI.SEARCHUSER(usercansearch, usrname);
            string str = JsonSerializer.Serialize<GOI.SEARCHUSER>(goisearchuser);
            GOI.THUONG goi = new GOI.THUONG("searchuser", str);
            sendJson(goi);
        }

        private void btnReturnToMain_Click(object sender, EventArgs e)
        {
            trdMainForm = new Thread(openMainForm);
            this.Close();
            trdMainForm.SetApartmentState(ApartmentState.STA);
            trdMainForm.Start();
        }

        private void openMainForm(object obj)
        {
            Application.Run(new MainForm(Shared.server));
        }

        private void FillKetQuaSearch(List<User> ls)
        {
            ketquasearch.BeginInvoke(new MethodInvoker(() =>
            {
                List<UserInDataGrid> dglist = new List<UserInDataGrid>();
                foreach(var u in ls)
                {
                    dglist.Add(new UserInDataGrid(u.name, u.IsChecked));
                }
                ketquasearch.DataSource = dglist;
            }));
        }

        private void ClearDataGrid()
        {
            ketquasearch.BeginInvoke(new MethodInvoker(() =>
            {
                ketquasearch.DataSource = null;
            }));
            dsthanhvien.BeginInvoke(new MethodInvoker(() =>
            {
                dsthanhvien.Rows.Clear();
                dsthanhvien.Refresh();
            }));
        }
        private void ThreadTask(StreamReader sr, StreamWriter sw)
        {
            string jsonString = "";
            
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
                            
                            case "searchuser":
                                {
                                    if (goi.content != null)
                                    {
                                        List<User> ls = JsonSerializer.Deserialize<List<User>>(goi.content);
                                        FillKetQuaSearch(ls);
                                    }
                                }
                                break;
                            case "taonhom":
                                {
                                    if (goi.content != null)
                                    {
                                        string ketqua = goi.content;
                                        if (ketqua.Equals("SUCCESS"))
                                        {
                                            MessageBox.Show("Tao nhom thanh cong!");
                                            ClearDataGrid();
                                        }
                                        else
                                        {
                                            if (ketqua.Equals("FAILED"))
                                            {
                                                MessageBox.Show("Tao nhom that bai, xay ra loi!");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ten nhom da ton tai, hay dat ten khac!");
                                            }
                                        }
                                    }
                                }
                                break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi mang!");
            }
        }

        private void btntaonhom_Click(object sender, EventArgs e)
        {
            string tennhom;
            if (txttennhom.Text.Trim() != "")
            {
                if (dsthanhvien.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Them it nhat 2 thanh vien vao danh sach!");
                }
                else
                {
                    if(dsthanhvien.Rows.Count >= 3)
                    {
                        tennhom = txttennhom.Text.Trim();
                        List<User> ls = new List<User>();
                        for (int rows = 0; rows < dsthanhvien.Rows.Count; rows++)
                        {
                            object tam = dsthanhvien.Rows[rows].Cells[0].Value;
                            if(tam != null)
                            {
                                ls.Add(new User(tam.ToString(), "", "", false));
                            }
                            else
                            {
                                continue;
                            }
                        }
                        ls.Add(new User(usrname, "", "", false));
                        string str = JsonSerializer.Serialize<List<User>>(ls);
                        GOI.THANHVIENNHOM goitvnhom = new GOI.THANHVIENNHOM(str);
                        string strgoitvnhom = JsonSerializer.Serialize<GOI.THANHVIENNHOM>(goitvnhom);
                        GOI.TAONHOM goitaonhom = new GOI.TAONHOM(usrname,tennhom,strgoitvnhom);
                        string strgoitaonhom = JsonSerializer.Serialize<GOI.TAONHOM>(goitaonhom);
                        GOI.THUONG goi = new GOI.THUONG("taonhom", strgoitaonhom);

                        string jsonStringgui = JsonSerializer.Serialize<GOI.THUONG>(goi);
                        StreamWriter swtam = new StreamWriter(client.GetStream());
                        swtam.WriteLine(jsonStringgui);
                        swtam.Flush();
                        //sendJson(goi);
                    }
                    else
                    {
                        MessageBox.Show("Them it nhat 2 thanh vien vao danh sach!");
                    }
                }
            }
            else
            {
                if(dsthanhvien.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Nhap ten nhom va them it nhat 2 thanh vien vao danh sach!");
                }
                else
                {
                    MessageBox.Show("Nhap ten nhom!");
                }
            }
            

        }

        private int CheckTrungDSThanhVien(string usrname)
        {
            for (int rows = 0; rows < dsthanhvien.Rows.Count; rows++)
            {
                object temp = dsthanhvien.Rows[rows].Cells[0].Value;
                if(temp != null && temp.ToString() == usrname)
                {
                    return rows;
                }
                
            }
            return -1;
        }
        private void ketquasearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                ketquasearch.CommitEdit(DataGridViewDataErrorContexts.Commit);

            //Check the value of cell
            if ((bool)ketquasearch.CurrentCell.Value == true)
            {
                //Use index of TimeOut column

                //ketquasearch.Rows[e.RowIndex].Cells[3].Value = DateTime.Now;

                //Set other columns values
                string uname = ketquasearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dsthanhvien.Rows[0].Cells[0].Value != null)
                {
                    if (CheckTrungDSThanhVien(uname) == -1)
                    {
                        dsthanhvien.Rows.Add(uname);
                    }
                    else
                    {
                        MessageBox.Show("User nay da co trong danh sach!");
                    }
                }
                else
                {

                    //int rowId = dsthanhvien.Rows.Add();
                    //DataGridViewRow row = dsthanhvien.Rows[rowId];
                    //row.Cells["Column1"].Value = uname;
                    dsthanhvien.Rows.Add(uname);
                }
            }
            else
            {
                string uname = ketquasearch.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dsthanhvien.Rows[0].Cells[0].Value != null)
                {
                    int row = CheckTrungDSThanhVien(uname);
                    if (row != -1)
                    {
                        dsthanhvien.Rows.RemoveAt(row);
                    }
                }
            }
        }

        
    }
}
