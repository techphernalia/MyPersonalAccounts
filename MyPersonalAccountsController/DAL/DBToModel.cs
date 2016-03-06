using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Controller.DAL
{
    public static class DBToModel
    {
        public static List<StockUnit> ToStockUnits(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new StockUnit
                    {
                        StockUnitId = row.Field<int>("stock_unit_id"),
                        StockUnitName = row.Field<string>("stock_unit_name"),
                        StockUnitSymbol = row.Field<string>("stock_unit_symbol"),
                        StockUnitDecimalPlaces = row.Field<int>("stock_unit_decimal_places")
                    }).ToList();
        }

        public static List<StockGroup> ToStockGroups(this DataTable DT)
        {
            return (from row in DT.AsEnumerable()
                    select new StockGroup
                    {
                        StockGroupId = row.Field<int>("stock_group_id"),
                        StockGroupName = row.Field<string>("stock_group_name"),
                        ParentStockGroup = row.Field<int>("parent_stock_group"),
                        AllowQuantityAdd = row.Field<bool>("allow_quantity_add")
                    }).ToList();
        }

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
                        OpeningRate = row.Field<decimal>("opening_rate")
                    }).ToList();
        }
    }
}
