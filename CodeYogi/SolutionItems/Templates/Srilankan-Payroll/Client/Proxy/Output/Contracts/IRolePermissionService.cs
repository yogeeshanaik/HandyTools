
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IRolePermissionService
    {
        [OperationContract]
        void Add(RolePermission rolepermission);

        [OperationContract]
        void Update(RolePermission rolepermission);

        [OperationContract]
        void Delete(RolePermission rolepermission);

        [OperationContract]
        RolePermission GetById(int id);

        [OperationContract]
        RolePermission[] GetAll();

        [OperationContract]
        IEnumerable<RolePermission> ExecuteProcedure(RolePermission model, string storedProcedure);
    }
}