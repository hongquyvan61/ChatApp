using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class User
    {
        public int userid;
        public string name { get; set; }
        public string pass { get; set; }

        public string trangthai { get; set; }
        public User()
        {

        }

        public User(string name, string pass, string trangthai)
        {
            this.name = name;
            this.pass = pass;
            this.trangthai = trangthai;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
