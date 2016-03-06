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
            if(stockUnit.Count > 0)
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
            throw new NotImplementedException();
        }

        public StockGroup GetStockGroupFromId(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public int AddStockGroup(StockItem stockItem)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStockGroup(StockItem stockItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStockGroup(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Stock Item

        public List<StockItem> GetAllStockItems()
        {
            return SQLController.GetInstance().ExecuteProcedure("GetStockItems", null).Tables[0].ToStockItems();
        }

        public List<StockItem> GetStockItemsForGroup(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public StockItem GetStockItemFromId(int stockItemId)
        {
            throw new NotImplementedException();
        }

        public int AddStockItem(StockGroup stockGroup)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStockItem(StockGroup stockGroup)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStockItemI(int stockItemId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
