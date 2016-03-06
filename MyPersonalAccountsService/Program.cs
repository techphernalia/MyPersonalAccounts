using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using com.techphernalia.MyPersonalAccounts;
namespace com.techphernalia.MyPersonalAccounts.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyPersonalAccountsService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
