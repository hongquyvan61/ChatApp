using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string role { get; set; }
        public int UserId { get; set; }


        public Group()
        {

        }
        public Group(int GroupId, string Name, string role, int UserId)
        {
            this.GroupId = GroupId;
            this.Name = Name;
            this.role = role;
            this.UserId = UserId;
        }
        public Group(string Name)
        {
            this.Name = Name;
        }
    }
}
