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

        bool UpdateStockUnit(StockUnit stockUnit);

        bool DeleteStockUnit(int unitId);

        #endregion

        #region Stock Group

        List<StockGroup> GetAllStockGroups();
        
        List<StockGroup> GetStockGroupsForGroup(int stockGroupId);
        
        StockGroup GetStockGroupFromId(int stockGroupId);
        
        int AddStockGroup(StockItem stockItem);
        
        bool UpdateStockGroup(StockItem stockItem);

        bool DeleteStockGroup(int stockGroupId);

        #endregion

        #region Stock Item

        List<StockItem> GetAllStockItems();

        List<StockItem> GetStockItemsForGroup(int stockGroupId);

        StockItem GetStockItemFromId(int stockItemId);

        int AddStockItem(StockGroup stockGroup);

        bool UpdateStockItem(StockGroup stockGroup);

        bool DeleteStockItemI(int stockItemId);

        #endregion
    }
}
