using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class UserInDataGrid
    {
        public string name { get; set; }
        public bool IsChecked { get; set; }
        public UserInDataGrid()
        {

        }

        public UserInDataGrid(string name, bool isChecked)
        {
            this.name = name;
            IsChecked = isChecked;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
