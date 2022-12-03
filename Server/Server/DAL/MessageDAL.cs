using DoAn;
using DoAn.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAL
{
    public class MessageDAL
    {
        public ConnectionStr connstr;
        public UserDAL userdal;
        public GroupDAL groupdal;
        public MessageDAL()
        {
            connstr = new ConnectionStr();
            groupdal = new GroupDAL();
        }

        public bool LuuTinNhan(string gui, string nhan, string noidung, string duongdan)
        {
            DateTime now = DateTime.Now;
            int senderid = userdal.getUserId(gui);
            int receiverid = userdal.getUserId(nhan);
            string query = String.Format("insert into tinnhan(nguoigui,nguoinhan,noidung,ngaygiogui,hinhanh) values" +
                                        "({0},{1},'{2}','{3}','{4}')", senderid, receiverid, noidung, now.ToString(), duongdan);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();
                if (row != 0) return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            return false;
        }
        public bool LuuTinNhanGR(string gui, string nhan, string noidung, string duongdan,int manhom)
        {
            DateTime now = DateTime.Now;
            int senderid = userdal.getUserId(gui);
            int receiverid = groupdal.layidnhom(nhan);
            string query = String.Format("insert into tinnhan(nguoigui,nguoinhan,noidung,ngaygiogui,hinhanh,ma_nhom) values" +
                                        "({0},'','{1}','{2}','{3}','{4}')", senderid, noidung, now.ToString(), duongdan,manhom);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                con.Close();
                if (row != 0) return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            return false;
        }
        public List<KeyValuePair<string, string>> GetMes(string sender, string receiver)
        {
            userdal = new UserDAL();
            int senderid = userdal.getUserId(sender);
            int receiverid = userdal.getUserId(receiver);
            List<KeyValuePair<string, string>> dicmessage = new List<KeyValuePair<string, string>>();
            string query = String.Format("select nguoigui, noidung, ngaygiogui, hinhanh from tinnhan where (nguoigui={0} and nguoinhan={1}) or (nguoigui={2} and nguoinhan={3})", senderid, receiverid, receiverid, senderid);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> chatmesgui = new List<string>();
                List<string> chatmesnhan = new List<string>();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string k = "";
                    //TAO KEY CHO TUNG TIN NHAN//
                    if (id == senderid)
                    {
                        k = "sender@" + reader.GetString(2);
                    }
                    else
                    {
                        k = "receiver@" + reader.GetString(2);
                    }
                    if (reader.GetString(3) != "")
                    {
                        KeyValuePair<string, string> pair = new KeyValuePair<string, string>(k, reader.GetString(3));
                        dicmessage.Add(pair);
                    }
                    else
                    {
                        KeyValuePair<string, string> pair = new KeyValuePair<string, string>(k, reader.GetString(1));
                        dicmessage.Add(pair);
                    }
                }
                //dicmessage.Add(sender, chatmesgui);
                //dicmessage.Add(receiver, chatmesnhan);
                con.Close();
                reader.Close();
                return dicmessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
            return null;
        }
        public List<KeyValuePair<string, string>> GetMesgr(string sender, string receiver)
        {
            userdal = new UserDAL();
            int senderid = userdal.getUserId(sender);
            int receiverid = groupdal.layidnhom(receiver);
            List<KeyValuePair<string, string>> dicmessage = new List<KeyValuePair<string, string>>();
            string query = String.Format("select nguoigui, noidung, ngaygiogui, hinhanh from tinnhan where ma_nhom={0}", receiverid);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> chatmesgui = new List<string>();
                List<string> chatmesnhan = new List<string>();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string k = "";
                    //TAO KEY CHO TUNG TIN NHAN//
                    if (id == senderid)
                    {
                        string name = userdal.getUsername(id);
                        k = "sender@" + reader.GetString(2)+"@"+name;
                    }
                    else
                    {
                        string name = userdal.getUsername(id);
                        k = "receiver@" + reader.GetString(2) + "@" + name;
                    }
                    if (reader.GetString(3) != "")
                    {
                        KeyValuePair<string, string> pair = new KeyValuePair<string, string>(k, reader.GetString(3));
                        dicmessage.Add(pair);
                    }
                    else
                    {
                        KeyValuePair<string, string> pair = new KeyValuePair<string, string>(k, reader.GetString(1));
                        dicmessage.Add(pair);
                    }
                }
                //dicmessage.Add(sender, chatmesgui);
                //dicmessage.Add(receiver, chatmesnhan);
                con.Close();
                reader.Close();
                return dicmessage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
            return null;
        }
    }
}
