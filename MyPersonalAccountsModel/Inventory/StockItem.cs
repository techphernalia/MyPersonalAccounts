namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    /// <summary>
    /// Stock Items Type
    /// </summary>
    public class StockItem
    {
        /// <summary>
        /// Unique Identifier for Item
        /// </summary>
        public int StockItemId { get; set; }

        /// <summary>
        /// Name of Stock Item
        /// </summary>
        public string StockItemName { get; set; }

        /// <summary>
        /// Parent Group of Stock Item
        /// </summary>
        public int StockGroupId { get; set; }

        /// <summary>
        /// Unit used for Stock Item
        /// </summary>
        public int StockUnitId { get; set; }

        /// <summary>
        /// Opening Balance
        /// </summary>
        public decimal OpeningBalance { get; set; }

        /// <summary>
        /// Rate for Opening Balance
        /// </summary>
        public decimal OpeningRate { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] with Opening Balance [{1}] @ [{2}] with ID : {3}",StockItemName,OpeningBalance,OpeningRate,StockItemId);
        }
    }
}
