using DoAn;
using DoAn.DAL;
using DoAn.DTO;
using GOI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server.DAL
{
    public class GroupDAL
    {
        public ConnectionStr connstr;
        public UserDAL userdal;
        public GroupDAL()
        {
            connstr = new ConnectionStr();
            userdal = new UserDAL();
        }

        public bool TaoNhom(string nguoitao, string tennhom, List<User> thanhvien)
        {
            string query = String.Format("insert into nhom(ten_nhom) values('{0}')", tennhom);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int row = cmd.ExecuteNonQuery();
                if (row != 0)
                {
                    if(ThemChiTietNhom(nguoitao, thanhvien))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            return false;
        }

        public int LayIDNhomVuaTao()
        {
            string query = String.Format("select MAX(ma_nhom) from nhom");
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int groupid = 0;
                while (reader.Read())
                {
                    groupid = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                return groupid;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public bool ThemChiTietNhom(string nguoitao, List<User> thanhvien)
        {
            int groupid = LayIDNhomVuaTao();
            int row = 0;
            if (groupid != 0)
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                con.Open();
                foreach (var mem in thanhvien)
                {
                    int uid = userdal.getUserId(mem.name);
                    string role = nguoitao == mem.name ? "truongnhom" : "thanhvien";
                    string query = String.Format("insert into chitietnhom(ma_nhom, userid, role) values({0},{1},'{2}')", groupid,uid,role);
                    
                    SqlCommand cmd = new SqlCommand(query, con);
                    row = cmd.ExecuteNonQuery();
                }
                if (row != 0)
                {
                    con.Close();
                    return true;
                }
            }
            return false;
        }

        public bool KiemTraTrungTenNhom(string ten)
        {
            string query = String.Format("select ma_nhom from nhom where ten_nhom='{0}'", ten);
            try
            {
                SqlConnection con = new SqlConnection(connstr.connectstr);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int groupid = 0;
                while (reader.Read())
                {
                    groupid = reader.GetInt32(0);
                }
                con.Close();
                reader.Close();
                if (groupid != 0) return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            return true;
        }
    }
}
