
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IPermissionService
    {
        [OperationContract]
        void Add(Permission permission);

        [OperationContract]
        void Update(Permission permission);

        [OperationContract]
        void Delete(Permission permission);

        [OperationContract]
        Permission GetById(int id);

        [OperationContract]
        Permission[] GetAll();

        [OperationContract]
        IEnumerable<Permission> ExecuteProcedure(Permission model, string storedProcedure);
    }
}