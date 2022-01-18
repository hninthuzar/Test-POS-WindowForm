using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPos
{
    public class Sale
    {
        public string saleid { get; set; }
        public string invno { get; set; }
        public DateTime date { get; set; }
        public string custid { get; set; }
        public string custname { get; set; }
        public int totalamt { get; set; }
    }

    public class SaleDetail
    {
        public string saleid { get; set; }
        public string itemid { get; set; }
        public string itemcode { get; set; }
        public string itemname { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
        public int disper { get; set; }
        public int disamt { get; set; }
        public int totalamt { get; set; }
    }
}
