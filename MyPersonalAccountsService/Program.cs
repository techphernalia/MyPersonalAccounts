using System.ServiceProcess;
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
