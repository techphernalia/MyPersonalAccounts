using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.Controller
{
    public interface IInventoryController
    {
        #region Stock Unit

        List<StockUnit> GetAllStockUnits();

        StockUnit GetStockUnitFromId(int unitId);

        int AddStockUnit(StockUnit stockUnit);

        void UpdateStockUnit(StockUnit stockUnit);

        void DeleteStockUnit(int unitId);

        #endregion

        #region Stock Group

        List<StockGroup> GetAllStockGroups();
        
        List<StockGroup> GetStockGroupsForGroup(int stockGroupId);
        
        StockGroup GetStockGroupFromId(int stockGroupId);
        
        int AddStockGroup(StockGroup stockGroup);
        
        void UpdateStockGroup(StockGroup stockGroup);

        void DeleteStockGroup(int stockGroupId);

        #endregion

        #region Stock Item

        List<StockItem> GetAllStockItems();

        List<StockItem> GetStockItemsForGroup(int stockGroupId);

        StockItem GetStockItemFromId(int stockItemId);

        int AddStockItem(StockItem stockItem);

        void UpdateStockItem(StockItem stockItem);

        void DeleteStockItem(int stockItemId);

        #endregion
    }
}
