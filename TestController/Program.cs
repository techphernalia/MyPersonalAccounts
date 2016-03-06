using com.techphernalia.MyPersonalAccounts.Controller;
using com.techphernalia.MyPersonalAccounts.Model;
using com.techphernalia.MyPersonalAccounts.Model.Controller;
using com.techphernalia.MyPersonalAccounts.Model.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestController
{
    class Program
    {
        static void Main(string[] args)
        {
            IInventoryController controller = new InventoryController();
            
            Print(controller.GetAllStockGroups());
            Print(controller.GetAllStockItems());
            Print(controller.GetAllStockUnits());

            IAccountsController aController = new AccountsController();
            Print(aController.GetAllLedgerGroups());
            Print(aController.GetLedgerGroupsForParentGroup(0));
            Console.WriteLine(aController.GetLedgerGroupById(1));

            Console.Write("Press any key to exit...");
            Console.ReadLine();
        }
        public static void Print(IEnumerable<object> items)
        {
            foreach(var i in items)
            {
                Console.WriteLine(i);
            }
        }
    }
}
