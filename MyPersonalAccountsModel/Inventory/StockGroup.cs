namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    /// <summary>
    /// Group for Inventory Items
    /// </summary>
    public class StockGroup
    {
        /// <summary>
        /// Unique Identifier for Group
        /// </summary>
        public int StockGroupId { get; set; }

        /// <summary>
        /// Group Name
        /// </summary>
        public string StockGroupName { get; set; }

        /// <summary>
        /// Unique Identifier of Parent Group
        /// </summary>
        public int ParentStockGroup { get; set; }

        /// <summary>
        /// Allow quantities to be added in group
        /// </summary>
        public bool AllowQuantityAdd { get; set; }

        /// <summary>
        /// Human Readable System Id
        /// </summary>
        public string SystemId { get; set; }

        /// <summary>
        /// Display Group Information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0}] Allow Quantity Add : [{1}] with Id : {2}", StockGroupName, AllowQuantityAdd,StockGroupId);
        }
    }
}
