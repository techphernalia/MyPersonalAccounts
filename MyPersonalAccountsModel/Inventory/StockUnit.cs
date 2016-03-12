namespace com.techphernalia.MyPersonalAccounts.Model.Inventory
{
    /// <summary>
    /// Unit for Inventory Items
    /// </summary>
    public class StockUnit
    {
        /// <summary>
        /// Unique Identifier of Unit
        /// </summary>
        public int StockUnitId { get; set; }

        /// <summary>
        /// Name of Unit
        /// </summary>
        public string StockUnitName { get; set; }

        /// <summary>
        /// Symbol for Unit
        /// </summary>
        public string StockUnitSymbol { get; set; }

        /// <summary>
        /// Number of Decimal Places in Unit
        /// </summary>
        public int StockUnitDecimalPlaces { get; set; }

        /// <summary>
        /// Display Unit information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0}] with symbol [{1}] having {2} Decimal Places with Id : {3}", StockUnitName, StockUnitSymbol, StockUnitDecimalPlaces, StockUnitId);
        }
    }
}
