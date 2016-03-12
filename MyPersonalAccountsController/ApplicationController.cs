using com.techphernalia.MyPersonalAccounts.Model;
using System;
using com.techphernalia.MyPersonalAccounts.Model.Controller;

namespace com.techphernalia.MyPersonalAccounts.Controller
{
    public partial class ApplicationController : IApplicationController
    {
        #region Private Members

        private static IAccountsController _IAccountsController = null;

        private static IInventoryController _IInventoryController = null;

        private static string _mutex = string.Empty;

        #endregion

        #region ApplicationController Members

        private IAccountsController AccountsController
        {
            get
            {
                if (_IAccountsController == null)
                {
                    lock (_mutex)
                    {
                        if (_IAccountsController == null)
                        {
                            _IAccountsController = new AccountsController();
                        }
                    }
                }
                return _IAccountsController;
            }
            set
            {
                throw new NotSupportedException("You can not set AccountsController");
            }
        }

        private IInventoryController InventoryController
        {
            get
            {
                if (_IInventoryController == null)
                {
                    lock (_mutex)
                    {
                        if (_IInventoryController == null)
                        {
                            _IInventoryController = new InventoryController();
                        }
                    }
                }
                return _IInventoryController;
            }
            set
            {
                throw new NotSupportedException("You can not set InventoryController");
            }
        }

        #endregion

    }
}
