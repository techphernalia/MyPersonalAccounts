using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    public class StockUnit
    {
        public int StockUnitId { get; set; }
        public string StockUnitName { get; set; }
        public string StockUnitSymbol { get; set; }
        public int StockUnitDecimalPlaces { get; set; }
    }
}
