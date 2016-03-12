using com.techphernalia.MyPersonalAccounts.Model.Controller;
using System;
using System.Collections.Generic;
using com.techphernalia.MyPersonalAccounts.Model.Inventory;

namespace com.techphernalia.MyPersonalAccounts.Controller
{
    public partial class ApplicationController : IInventoryController
    {
        public int AddStockGroup(StockGroup stockGroup)
        {
            throw new NotImplementedException();
        }

        public int AddStockItem(StockItem stockItem)
        {
            throw new NotImplementedException();
        }

        public int AddStockUnit(StockUnit stockUnit)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockGroup(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockItem(int stockItemId)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockUnit(int unitId)
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> GetAllStockGroups()
        {
            return this.InventoryController.GetAllStockGroups();
        }

        public List<StockItem> GetAllStockItems()
        {
            throw new NotImplementedException();
        }

        public List<StockUnit> GetAllStockUnits()
        {
            throw new NotImplementedException();
        }

        public StockGroup GetStockGroupFromId(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> GetStockGroupsForGroup(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public StockItem GetStockItemFromId(int stockItemId)
        {
            throw new NotImplementedException();
        }

        public List<StockItem> GetStockItemsForGroup(int stockGroupId)
        {
            throw new NotImplementedException();
        }

        public StockUnit GetStockUnitFromId(int unitId)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockGroup(StockGroup stockGroup)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockItem(StockItem stockItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockUnit(StockUnit stockUnit)
        {
            throw new NotImplementedException();
        }
    }
}
