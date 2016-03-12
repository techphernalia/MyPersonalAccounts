using com.techphernalia.MyPersonalAccounts.Controller.Controllers;
using com.techphernalia.MyPersonalAccounts.Model;
using com.techphernalia.MyPersonalAccounts.Model.AppConfig;
using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace com.techphernalia.MyPersonalAccounts.Controller.DAL
{
    /// <summary>
    /// Extension Methods to map DataTable to C# Models
    /// </summary>
    public static class DBToModel
    {
        /// <summary>
        /// Converts SQL DataTable to List of Stock Units
        /// </summary>
        /// <param name="DT"></param>
        /// <returns></returns>
        public static List<StockUnit> ToStockUnits(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new StockUnit
                    {
                        StockUnitId = row.Field<int>("stock_unit_id"),
                        StockUnitName = row.Field<string>("stock_unit_name"),
                        StockUnitSymbol = row.Field<string>("stock_unit_symbol"),
                        StockUnitDecimalPlaces = row.Field<int>("stock_unit_decimal_places"),
                        SystemId = string.Format(ConfigurationController.instance["StockUnit"], row.Field<int>("stock_unit_id"))
                    }).ToList();
        }

        /// <summary>
        /// Converts SQL DataTable to List of Stock Groups
        /// </summary>
        /// <param name="DT"></param>
        /// <returns></returns>
        public static List<StockGroup> ToStockGroups(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new StockGroup
                    {
                        StockGroupId = row.Field<int>("stock_group_id"),
                        StockGroupName = row.Field<string>("stock_group_name"),
                        ParentStockGroup = row.Field<int>("parent_stock_group"),
                        AllowQuantityAdd = row.Field<bool>("allow_quantity_add"),
                        SystemId = string.Format(ConfigurationController.instance["StockGroup"], row.Field<int>("stock_group_id"))
                    }).ToList();
        }

        /// <summary>
        /// Converts SQL DataTable to List of Stock Items
        /// </summary>
        /// <param name="DT"></param>
        /// <returns></returns>
        public static List<StockItem> ToStockItems(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new StockItem
                    {
                        StockItemId = row.Field<int>("stock_item_id"),
                        StockItemName = row.Field<string>("stock_item_name"),
                        StockGroupId = row.Field<int>("parent_stock_group"),
                        StockUnitId = row.Field<int>("parent_stock_unit"),
                        OpeningBalance = row.Field<decimal>("opening_balance"),
                        OpeningRate = row.Field<decimal>("opening_rate"),
                        SystemId = string.Format(ConfigurationController.instance["StockItem"], row.Field<int>("stock_item_id"))
                    }).ToList();
        }

        /// <summary>
        /// Converts SQL DataTable to List of Ledger Groups
        /// </summary>
        /// <param name="DT"></param>
        /// <returns></returns>
        public static List<LedgerGroup> ToLedgerGroups(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new LedgerGroup
                    {
                        LedgerGroupId = row.Field<int>("ledger_group_id"),
                        LedgerEffect = (LedgerEffect)row.Field<int>("ledger_effect"),
                        LedgerType = (LedgerType)row.Field<int>("ledger_type"),
                        LedgerGroupName = row.Field<string>("ledger_group_name"),
                        ParentLedgerGroupId = row.Field<int>("parent_ledger_group_id"),
                        SystemId = string.Format(ConfigurationController.instance["LedgerGroup"], row.Field<int>("ledger_group_id"))
                    }).ToList();
        }

        public static List<NameConfiguration> ToNameConfiguration(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new NameConfiguration
                    {
                        ConfigurationId = row.Field<int>("id"),
                        SystemName = row.Field<string>("system_name"),
                        Prefix = row.Field<string>("name_prefix"),
                        Suffix = row.Field<string>("name_suffix"),
                        IDLength = row.Field<int>("id_length")
                    }).ToList();
        }
    }
}
