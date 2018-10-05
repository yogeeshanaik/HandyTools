
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IRoleService
    {
        [OperationContract]
        void Add(Role role);

        [OperationContract]
        void Update(Role role);

        [OperationContract]
        void Delete(Role role);

        [OperationContract]
        Role GetById(int id);

        [OperationContract]
        Role[] GetAll();

        [OperationContract]
        IEnumerable<Role> ExecuteProcedure(Role model, string storedProcedure);
    }
}