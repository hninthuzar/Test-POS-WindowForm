using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPos
{
    class Category
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string parentID { get; set; }
        public string parent { get; set; }
    }
}
