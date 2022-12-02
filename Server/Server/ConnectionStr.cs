using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class ConnectionStr
    {
        public string connectstr { get; set; }
        private string machineName { get; set; }
        public ConnectionStr()
        {
            this.machineName = System.Environment.MachineName;
            this.connectstr = String.Format("Server={0};Initial Catalog=ChatApp;User=sa;Password=truong2001;TrustServerCertificate=True;MultipleActiveResultSets=true", machineName);
        }

    }
}
