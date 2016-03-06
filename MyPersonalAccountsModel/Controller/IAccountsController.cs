using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model.Controller
{
    public interface IAccountsController
    {
        #region Ledger Groups

        int AddLedgerGroup(LedgerGroup ledgerGroup);

        void UpdateLedgerGroup(LedgerGroup ledgerGroup);

        List<LedgerGroup> GetAllLedgerGroups();

        LedgerGroup GetLedgerGroupById(int ledgerGroupId);

        List<LedgerGroup> GetLedgerGroupsForParentGroup(int parentLedgerGroupId);

        void DeleteLedgerGroup(LedgerGroup ledgerGroup);

        #endregion
    }
}
