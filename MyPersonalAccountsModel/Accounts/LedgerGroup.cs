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

        /// <summary>
        /// Human Readable System Id
        /// </summary>
        public string SystemId { get; set; }

        /// <summary>
        /// Display Ledger Group
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[{0}] with type [{1}] having effect [{2}] with Id [{3}]", LedgerGroupName, LedgerType, LedgerEffect, LedgerGroupId);
        }
    }
}
