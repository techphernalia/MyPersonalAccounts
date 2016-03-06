using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Model
{
    /// <summary>
    /// Ledger Groups of Accounts
    /// </summary>
    public class LedgerGroup
    {
        /// <summary>
        /// Unique identifier of Ledger Group
        /// </summary>
        public int LedgerGroupId { get; set; }
        
        /// <summary>
        /// Ledger Group Name
        /// </summary>
        public string LedgerGroupName { get; set; }

        /// <summary>
        /// Parent Ledger Group
        /// </summary>
        public int ParentLedgerGroupId { get; set; }

        /// <summary>
        /// Ledger Group Type
        /// </summary>
        public LedgerType LedgerType { get;set; }

        /// <summary>
        /// Ledger Group Effect
        /// </summary>
        public LedgerEffect LedgerEffect { get; set; }
    }
}
