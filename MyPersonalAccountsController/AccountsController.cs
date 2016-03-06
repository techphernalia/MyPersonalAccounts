using com.techphernalia.MyPersonalAccounts.Model.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.techphernalia.MyPersonalAccounts.Model;
using com.techphernalia.MyPersonalAccounts.Model.Exceptions;
using System.Data.SqlClient;
using com.techphernalia.MyPersonalAccounts.Controller.DAL;

namespace com.techphernalia.MyPersonalAccounts.Controller
{
    public class AccountsController : IAccountsController
    {
        #region Ledger Groups

        public int AddLedgerGroup(LedgerGroup ledgerGroup)
        {
            if(ledgerGroup.LedgerType == LedgerType.SuperAccountGroup || ledgerGroup.LedgerType == LedgerType.AccountGroup)
            {
                throw new InvalidLedgerGroupException(string.Format("[{0}] is Invalid.", ledgerGroup.LedgerType.ToString()));
            }
            return Convert.ToInt32(SQLController.GetInstance().ExecuteProcedure("AddLedgerGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@ledger_group_name", Value = ledgerGroup.LedgerGroupName },
                new SqlParameter { ParameterName = "@parent_ledger_group_id", Value = ledgerGroup.ParentLedgerGroupId},
                new SqlParameter { ParameterName = "@ledger_type", Value = (int)ledgerGroup.LedgerType}
            }).Tables[0].Rows[0][0]);
        }

        public void DeleteLedgerGroup(LedgerGroup ledgerGroup)
        {
            if (ledgerGroup.LedgerType == LedgerType.SuperAccountGroup || ledgerGroup.LedgerType == LedgerType.AccountGroup)
            {
                throw new InvalidLedgerGroupException(string.Format("[{0}] is Invalid.", ledgerGroup.LedgerType.ToString()));
            }
            SQLController.GetInstance().ExecuteProcedure("DeleteLedgerGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@ledger_group_id", Value = ledgerGroup.LedgerGroupId}
            });
        }

        public List<LedgerGroup> GetAllLedgerGroups()
        {
            return SQLController.GetInstance().ExecuteProcedure("GetLedgerGroups", null).Tables[0].ToLedgerGroups();
        }

        public LedgerGroup GetLedgerGroupById(int ledgerGroupId)
        {
            var ledgerGroup = SQLController.GetInstance().ExecuteProcedure("GetLedgerGroups", new SqlParameter[] { new SqlParameter { ParameterName = "@ledger_group_id", Value = ledgerGroupId } }).Tables[0].ToLedgerGroups();
            if (ledgerGroup.Count > 0)
            {
                return ledgerGroup[0];
            }
            return null;

        }

        public List<LedgerGroup> GetLedgerGroupsForParentGroup(int parentLedgerGroupId)
        {
            return SQLController.GetInstance().ExecuteProcedure("GetLedgerGroups", new SqlParameter[] { new SqlParameter { ParameterName = "@parent_ledger_group_id", Value = parentLedgerGroupId } }).Tables[0].ToLedgerGroups();
        }

        public void UpdateLedgerGroup(LedgerGroup ledgerGroup)
        {
            SQLController.GetInstance().ExecuteProcedure("EditLedgerGroup", new SqlParameter[]
            {
                new SqlParameter { ParameterName = "@ledger_group_id", Value = ledgerGroup.LedgerGroupId },
                new SqlParameter { ParameterName = "@ledger_group_name", Value = ledgerGroup.LedgerGroupName },
                new SqlParameter { ParameterName = "@parent_ledger_group_id", Value = ledgerGroup.ParentLedgerGroupId},
                new SqlParameter { ParameterName = "@ledger_type", Value = (int)ledgerGroup.LedgerType}
            });
        }

        #endregion
    }
}
