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
            return InventoryController.AddStockGroup(stockGroup);
        }

        public int AddStockItem(StockItem stockItem)
        {
            return InventoryController.AddStockItem(stockItem);
        }

        public int AddStockUnit(StockUnit stockUnit)
        {
            return InventoryController.AddStockUnit(stockUnit);
        }

        public void DeleteStockGroup(int stockGroupId)
        {
            InventoryController.DeleteStockGroup(stockGroupId);
        }

        public void DeleteStockItem(int stockItemId)
        {
            InventoryController.DeleteStockItem(stockItemId);
        }

        public void DeleteStockUnit(int unitId)
        {
            InventoryController.DeleteStockUnit(unitId);
        }

        public List<StockGroup> GetAllStockGroups()
        {
            return InventoryController.GetAllStockGroups();
        }

        public List<StockItem> GetAllStockItems()
        {
            return InventoryController.GetAllStockItems();
        }

        public List<StockUnit> GetAllStockUnits()
        {
            return InventoryController.GetAllStockUnits();
        }

        public StockGroup GetStockGroupFromId(int stockGroupId)
        {
            return InventoryController.GetStockGroupFromId(stockGroupId);
        }

        public List<StockGroup> GetStockGroupsForGroup(int stockGroupId)
        {
            return InventoryController.GetStockGroupsForGroup(stockGroupId);
        }

        public StockItem GetStockItemFromId(int stockItemId)
        {
            return InventoryController.GetStockItemFromId(stockItemId);
        }

        public List<StockItem> GetStockItemsForGroup(int stockGroupId)
        {
            return InventoryController.GetStockItemsForGroup(stockGroupId);
        }

        public StockUnit GetStockUnitFromId(int unitId)
        {
            return InventoryController.GetStockUnitFromId(unitId);
        }

        public void UpdateStockGroup(StockGroup stockGroup)
        {
            InventoryController.UpdateStockGroup(stockGroup);
        }

        public void UpdateStockItem(StockItem stockItem)
        {
            InventoryController.UpdateStockItem(stockItem);
        }

        public void UpdateStockUnit(StockUnit stockUnit)
        {
            InventoryController.UpdateStockUnit(stockUnit);
        }
    }
}
