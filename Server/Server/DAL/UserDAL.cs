using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DoAn.DAL
{
    public class UserDAL
    {
        public ConnectionStr connstr;
        public UserDAL()
        {
            connstr = new ConnectionStr();
        }
        public bool checklogin(string name, string pwd)
        {
            string query = String.Format("select * from taikhoan where username='{0}' and pass='{1}'", name, pwd);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int userid = 0;
                while (reader.Read())
                {
                    userid = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                if (userid != 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public bool checkdangki(string name)
        {
            string query = String.Format("select * from taikhoan where username='{0}' ", name);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int userid = 0;
                while (reader.Read())
                {
                    userid = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                if (userid == 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public bool ThemTaiKhoan(string username, string pass)
        {


            string query = String.Format("insert into taikhoan(username,pass,trangthai) values" +
                                               "('{0}','{1}','{2}')", username, pass, "offline");
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
        public int getUserId(string name)
        {
            string query = String.Format("select userid from taikhoan where username='{0}'", name);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int userid = 0;
                while (reader.Read())
                {
                    userid = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return userid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public bool UpdateTrangThai(int userid, string trangthai)
        {
            string query = String.Format("update taikhoan set trangthai='{0}' where userid={1}", trangthai, userid);
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

        public List<User> getOnlineUsers(string usrname)
        {
            List<User> ls = new List<User>();
            string query = String.Format("select username, trangthai from taikhoan where username !='{0}'",usrname);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    User u = new User(reader.GetString(0), "", reader.GetString(1));
                    ls.Add(u);
                }
                con.Close();
                reader.Close();
                return ls;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ls;
        }
    }
}
