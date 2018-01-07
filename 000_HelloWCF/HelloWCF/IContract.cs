using System.ServiceModel;

// Контракт.

namespace HelloWCF
{    
    [ServiceContract]
    interface IContract
    {
        [OperationContract]
        void Say(string input);
    }
}


