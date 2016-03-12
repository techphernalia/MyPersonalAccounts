using com.techphernalia.MyPersonalAccounts.Controller;
using System.ServiceModel;
using System.ServiceProcess;

namespace com.techphernalia.MyPersonalAccounts.Service
{
    /// <summary>
    /// Windows Service for MyPersonalAccouts
    /// </summary>
    partial class MyPersonalAccountsService : ServiceBase
    {
        private ServiceHost host = null;
        public MyPersonalAccountsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            host = new ServiceHost(typeof(ApplicationController));
            host.Open();
            // TODO: Add code here to start your service.
        }

        protected override void OnStop()
        {
            host.Close();
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }
    }
}
