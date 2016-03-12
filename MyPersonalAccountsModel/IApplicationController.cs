using com.techphernalia.MyPersonalAccounts.Model.Controller;
using System.ServiceModel;

namespace com.techphernalia.MyPersonalAccounts.Model
{
    [ServiceContract]
    public interface IApplicationController : IAccountsController, IInventoryController
    {
    }
}
