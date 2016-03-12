using com.techphernalia.MyPersonalAccounts.Model;
using System.ServiceModel;

namespace com.techphernalia.MyPersonalAccounts.Manager
{
    internal class ServiceInteractor
    {
        private static IApplicationController _IApplicationController = null;
        private static string _mutex = string.Empty;

        internal static IApplicationController GetApplicationController()
        {
            if(_IApplicationController == null)
            {
                lock (_mutex)
                {
                    if(_IApplicationController == null)
                    {
                        ChannelFactory < IApplicationController > factory = new ChannelFactory<IApplicationController>("ApplicationController_net");
                        _IApplicationController = factory.CreateChannel();
                    }
                }
            }
            return _IApplicationController;
        }
    }
}
