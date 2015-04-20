using System.ServiceModel;

namespace WcfJsonRestService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Taco GetTaco(string id);
    }
}