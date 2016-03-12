using System.ComponentModel;

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
        [Browsable(false)]
        public int StockUnitId { get; set; }

        /// <summary>
        /// Name of Unit
        /// </summary>
        [DisplayName("Unit")]
        public string StockUnitName { get; set; }

        /// <summary>
        /// Symbol for Unit
        /// </summary>
        [DisplayName("Symbol")]
        public string StockUnitSymbol { get; set; }

        /// <summary>
        /// Number of Decimal Places in Unit
        /// </summary>
        [DisplayName("Decimal Places")]
        public int StockUnitDecimalPlaces { get; set; }

        /// <summary>
        /// Human Readable System Id
        /// </summary>
        [DisplayName("Identifier")]
        public string SystemId { get; set; }

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
