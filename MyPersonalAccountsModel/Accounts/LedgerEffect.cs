namespace com.techphernalia.MyPersonalAccounts.Model
{
    /// <summary>
    /// Affect of Ledger on Account
    /// </summary>
    public enum LedgerEffect
    {
        /// <summary>
        /// Right side of Balance Sheet
        /// </summary>
        BalanceSheetRight,
        /// <summary>
        /// Left side of Balance Sheet
        /// </summary>
        BalanceSheetLeft,
        /// <summary>
        /// Right side of Profit and Loss Account
        /// </summary>
        ProfitLossRight,
        /// <summary>
        /// Left side of Profit and Loss Account
        /// </summary>
        ProfitLossLeft,
        /// <summary>
        /// Right side of Transaction
        /// </summary>
        TransactionRight,
        /// <summary>
        /// Left side of Transaction
        /// </summary>
        TransactionLeft
    }
}
