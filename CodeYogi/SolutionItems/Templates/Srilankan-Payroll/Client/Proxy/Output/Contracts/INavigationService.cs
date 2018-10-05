
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface INavigationService
    {
        [OperationContract]
        void Add(Navigation navigation);

        [OperationContract]
        void Update(Navigation navigation);

        [OperationContract]
        void Delete(Navigation navigation);

        [OperationContract]
        Navigation GetById(int id);

        [OperationContract]
        Navigation[] GetAll();

        [OperationContract]
        IEnumerable<Navigation> ExecuteProcedure(Navigation model, string storedProcedure);
    }
}