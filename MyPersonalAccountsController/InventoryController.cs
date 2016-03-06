using com.techphernalia.MyPersonalAccounts.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using com.techphernalia.MyPersonalAccounts.Controller.DAL;
using System.Data.SqlClient;

namespace com.techphernalia.MyPersonalAccounts.Controller
{
    public class InventoryController : IInventoryController
    {
        #region Stock Unit

        public List<StockUnit> GetAllStockUnits()
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockUnits", null).Tables[0].ToStockUnits();
        }

        public StockUnit GetStockUnitFromId(int unitId)
        {
            var stockUnit = SQLController.GetInstance().ExecuteProcedure("GetStockUnits", new SqlParameter[] { new SqlParameter { ParameterName = "@stock_unit_id", Value = unitId } }).Tables[0].ToStockUnits();
            if (stockUnit.Count > 0)
            {
                return stockUnit[0];
            }
            return null;
        }

        public int AddStockUnit(StockUnit stockUnit)
        {
            return Convert.ToInt32(SQLController.GetInstance().ExecuteProcedure("AddStockUnit", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_unit_name", Value = stockUnit.StockUnitName },
                new SqlParameter { ParameterName = "@stock_unit_symbol", Value = stockUnit.StockUnitSymbol},
                new SqlParameter { ParameterName = "@stock_unit_decimal_places", Value = stockUnit.StockUnitDecimalPlaces}
            }).Tables[0].Rows[0][0]);
        }

        public void UpdateStockUnit(StockUnit stockUnit)
        {
            SQLController.GetInstance().ExecuteProcedure("EditStockUnit", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_unit_id", Value = stockUnit.StockUnitId},
                new SqlParameter { ParameterName = "@stock_unit_name", Value = stockUnit.StockUnitName },
                new SqlParameter { ParameterName = "@stock_unit_symbol", Value = stockUnit.StockUnitSymbol},
                new SqlParameter { ParameterName = "@stock_unit_decimal_places", Value = stockUnit.StockUnitDecimalPlaces}
            });
        }

        public void DeleteStockUnit(int unitId)
        {
            SQLController.GetInstance().ExecuteProcedure("DeleteStockUnit", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_unit_id", Value = unitId}
            });
        }

        #endregion

        #region Stock Group

        public List<StockGroup> GetAllStockGroups()
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockGroups", null).Tables[0].ToStockGroups();
        }

        public List<StockGroup> GetStockGroupsForGroup(int stockGroupId)
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockGroups", new SqlParameter[] { new SqlParameter { ParameterName = "@parent_stock_group_id", Value = stockGroupId } }).Tables[0].ToStockGroups();
        }

        public StockGroup GetStockGroupFromId(int stockGroupId)
        {
            var stockGroup = SQLController.GetInstance().ExecuteProcedure("GetStockGroups", new SqlParameter[] { new SqlParameter { ParameterName = "@stock_group_id", Value = stockGroupId } }).Tables[0].ToStockGroups();
            if (stockGroup.Count > 0)
            {
                return stockGroup[0];
            }
            return null;
        }

        public int AddStockGroup(StockGroup stockGroup)
        {
            return Convert.ToInt32(SQLController.GetInstance().ExecuteProcedure("AddStockGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_group_name", Value = stockGroup.StockGroupName },
                new SqlParameter { ParameterName = "@parent_stock_group", Value = stockGroup.ParentStockGroup},
                new SqlParameter { ParameterName = "@allow_quantity_add", Value = stockGroup.AllowQuantityAdd}
            }).Tables[0].Rows[0][0]);
        }

        public void UpdateStockGroup(StockGroup stockGroup)
        {
            SQLController.GetInstance().ExecuteProcedure("EditStockGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_group_id", Value = stockGroup.StockGroupId },
                new SqlParameter { ParameterName = "@stock_group_name", Value = stockGroup.StockGroupName },
                new SqlParameter { ParameterName = "@parent_stock_group", Value = stockGroup.ParentStockGroup },
                new SqlParameter { ParameterName = "@allow_quantity_add", Value = stockGroup.AllowQuantityAdd }
            });
        }

        public void DeleteStockGroup(int stockGroupId)
        {
            SQLController.GetInstance().ExecuteProcedure("DeleteStockGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_group_id", Value = stockGroupId}
            });
        }

        #endregion

        #region Stock Item

        public List<StockItem> GetAllStockItems()
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockItems", null).Tables[0].ToStockItems();
        }

        public List<StockItem> GetStockItemsForGroup(int stockGroupId)
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockItems", new SqlParameter[] { new SqlParameter { ParameterName = "@parent_stock_group_id", Value = stockGroupId } }).Tables[0].ToStockItems();
        }

        public StockItem GetStockItemFromId(int stockItemId)
        {
            var stockItem = SQLController.GetInstance().ExecuteProcedure("GetStockItems", new SqlParameter[] { new SqlParameter { ParameterName = "@stock_item_id", Value = stockItemId } }).Tables[0].ToStockItems();
            if (stockItem.Count > 0)
            {
                return stockItem[0];
            }
            return null;
        }

        public int AddStockItem(StockItem stockItem)
        {
            return Convert.ToInt32(SQLController.GetInstance().ExecuteProcedure("AddStockItem", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@stock_item_name", Value = stockItem.StockItemName },
                new SqlParameter { ParameterName = "@parent_stock_group", Value = stockItem.StockGroupId},
                new SqlParameter { ParameterName = "@parent_stock_unit", Value = stockItem.StockUnitId},
                new SqlParameter { ParameterName = "@opening_balance", Value = stockItem.OpeningBalance },
                new SqlParameter { ParameterName = "@opening_rate", Value = stockItem.OpeningRate }
            }).Tables[0].Rows[0][0]);
        }

        public void UpdateStockItem(StockItem stockItem)
        {
            SQLController.GetInstance().ExecuteProcedure("EditStockItem", new SqlParameter[]
           {
                new SqlParameter { ParameterName = "@stock_item_id", Value = stockItem.StockItemId },
                new SqlParameter { ParameterName = "@stock_item_name", Value = stockItem.StockItemName },
                new SqlParameter { ParameterName = "@parent_stock_group", Value = stockItem.StockGroupId},
                new SqlParameter { ParameterName = "@parent_stock_unit", Value = stockItem.StockUnitId},
                new SqlParameter { ParameterName = "@opening_balance", Value = stockItem.OpeningBalance },
                new SqlParameter { ParameterName = "@opening_rate", Value = stockItem.OpeningRate }
           });
        }

        public void DeleteStockItem(int stockItemId)
        {
            SQLController.GetInstance().ExecuteProcedure("DeleteStockItem", new SqlParameter[]
           {
                new SqlParameter { ParameterName = "@stock_item_id", Value = stockItemId}
           });
        }

        #endregion
    }
}
