﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class Shared
    {
        public static IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.1.155"), 2008);
        //public static IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.43.179"), 2008);
        // public static IPEndPoint iep = new IPEndPoint(IPAddress.Parse("192.168.43.179"), 2008);
        public static TcpClient server;
        public static StreamReader strread;
        public static StreamWriter strwrite;
        public static string taikhoan;
        public static string matkhau;
    }
}
