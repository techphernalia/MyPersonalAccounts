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
            throw new NotImplementedException();
        }

        public void DeleteLedgerGroup(LedgerGroup ledgerGroup)
        {
            throw new NotImplementedException();
        }

        public List<LedgerGroup> GetAllLedgerGroups()
        {
            throw new NotImplementedException();
        }

        public LedgerGroup GetLedgerGroupById(int ledgerGroupId)
        {
            throw new NotImplementedException();
        }

        public List<LedgerGroup> GetLedgerGroupsForParentGroup(int parentLedgerGroupId)
        {
            throw new NotImplementedException();
        }

        public void UpdateLedgerGroup(LedgerGroup ledgerGroup)
        {
            throw new NotImplementedException();
        }
    }
}
