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
        public decimal OpeningBalance { get; set; }
        public decimal OpeningRate { get; set; }
    }
}
