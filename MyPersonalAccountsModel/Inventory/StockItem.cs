using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    public class StockItem
    {
        public int StockItemId { get; set; }
        public string StockItemName { get; set; }
        public int StockGroupId { get; set; }
        public int StockUnitId { get; set; }
        public double OpeningBalance { get; set; }
        public double OpeningRate { get; set; }
    }
}
