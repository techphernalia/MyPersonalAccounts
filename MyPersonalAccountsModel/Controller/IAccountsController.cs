using System.Collections.Generic;
using System.ServiceModel;

namespace com.techphernalia.MyPersonalAccounts.Model.Controller
{
    [ServiceContract]
    public interface IAccountsController
    {
        #region Ledger Groups

        [OperationContract]
        int AddLedgerGroup(LedgerGroup ledgerGroup);

        [OperationContract]
        void UpdateLedgerGroup(LedgerGroup ledgerGroup);

        [OperationContract]
        List<LedgerGroup> GetAllLedgerGroups();

        [OperationContract]
        LedgerGroup GetLedgerGroupById(int ledgerGroupId);

        [OperationContract]
        List<LedgerGroup> GetLedgerGroupsForParentGroup(int parentLedgerGroupId);

        [OperationContract]
        void DeleteLedgerGroup(LedgerGroup ledgerGroup);

        #endregion
    }
}
