using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Account_Management
{
    class StockUtility
    {
        public List<Stocks> stocksList { get; set; }
        public class Stocks
        {
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
    }
}
