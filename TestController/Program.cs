using com.techphernalia.MyPersonalAccounts.Controller;
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

            //controller.AddStockUnit(new StockUnit { StockUnitName = "_Primary", StockUnitSymbol = "" , StockUnitDecimalPlaces = 0 });

            Print(controller.GetAllStockUnits());
            Print(controller.GetAllStockItems());
            Print(controller.GetAllStockGroups());
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
