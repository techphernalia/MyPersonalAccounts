namespace com.techphernalia.MyPersonalAccounts.Model
{
    /// <summary>
    /// Types of Ledger Available
    /// </summary>
    public enum LedgerType
    {
        /// <summary>
        /// Super Account Group, Not visible on UI
        /// </summary>
        SuperAccountGroup,
        /// <summary>
        /// Account Group, Can not be created, edited or deleted
        /// </summary>
        AccountGroup,
        /// <summary>
        /// Ledger Group, can be created, edited or deleted
        /// </summary>
        LedgerGroup,
        /// <summary>
        /// Real Ledger, Leaf node of tree
        /// </summary>
        Ledger
    }
}
