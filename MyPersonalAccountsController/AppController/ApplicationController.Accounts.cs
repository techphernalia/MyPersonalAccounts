using com.techphernalia.MyPersonalAccounts.Model.Controller;
using System;
using System.Collections.Generic;
using com.techphernalia.MyPersonalAccounts.Model;

namespace com.techphernalia.MyPersonalAccounts.Controller
{
    public partial class ApplicationController : IAccountsController
    {

        public int AddLedgerGroup(LedgerGroup ledgerGroup)
        {
            return AccountsController.AddLedgerGroup(ledgerGroup);
        }

        public void DeleteLedgerGroup(LedgerGroup ledgerGroup)
        {
            AccountsController.DeleteLedgerGroup(ledgerGroup);
        }

        public List<LedgerGroup> GetAllLedgerGroups()
        {
            return AccountsController.GetAllLedgerGroups();
        }

        public LedgerGroup GetLedgerGroupById(int ledgerGroupId)
        {
            return AccountsController.GetLedgerGroupById(ledgerGroupId);
        }

        public List<LedgerGroup> GetLedgerGroupsForParentGroup(int parentLedgerGroupId)
        {
            return AccountsController.GetLedgerGroupsForParentGroup(parentLedgerGroupId);
        }

        public void UpdateLedgerGroup(LedgerGroup ledgerGroup)
        {
            AccountsController.UpdateLedgerGroup(ledgerGroup);
        }
    }
}
