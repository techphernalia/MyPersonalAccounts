using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using System.Collections.Generic;
using System.ServiceModel;

namespace com.techphernalia.MyPersonalAccounts.Model.Controller
{
    [ServiceContract]
    public interface IInventoryController
    {
        #region Stock Unit

        [OperationContract]
        List<StockUnit> GetAllStockUnits();

        [OperationContract]
        StockUnit GetStockUnitFromId(int unitId);

        [OperationContract]
        int AddStockUnit(StockUnit stockUnit);

        [OperationContract]
        void UpdateStockUnit(StockUnit stockUnit);

        [OperationContract]
        void DeleteStockUnit(int unitId);

        #endregion

        #region Stock Group

        [OperationContract]
        List<StockGroup> GetAllStockGroups();

        [OperationContract]
        List<StockGroup> GetStockGroupsForGroup(int stockGroupId);

        [OperationContract]
        StockGroup GetStockGroupFromId(int stockGroupId);

        [OperationContract]
        int AddStockGroup(StockGroup stockGroup);

        [OperationContract]
        void UpdateStockGroup(StockGroup stockGroup);

        [OperationContract]
        void DeleteStockGroup(int stockGroupId);

        #endregion

        #region Stock Item

        [OperationContract]
        List<StockItem> GetAllStockItems();

        [OperationContract]
        List<StockItem> GetStockItemsForGroup(int stockGroupId);

        [OperationContract]
        StockItem GetStockItemFromId(int stockItemId);

        [OperationContract]
        int AddStockItem(StockItem stockItem);

        [OperationContract]
        void UpdateStockItem(StockItem stockItem);

        [OperationContract]
        void DeleteStockItem(int stockItemId);

        #endregion
    }
}
