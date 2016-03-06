using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    public class StockGroup
    {
        public int StockGroupId { get; set; }
        public string StockGroupName { get; set; }
        public int StockParentGroup { get; set; }
        public bool AddQuantity { get; set; }
    }
}
