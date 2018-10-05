
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IUserRoleService
    {
        [OperationContract]
        void Add(UserRole userrole);

        [OperationContract]
        void Update(UserRole userrole);

        [OperationContract]
        void Delete(UserRole userrole);

        [OperationContract]
        UserRole GetById(int id);

        [OperationContract]
        UserRole[] GetAll();

        [OperationContract]
        IEnumerable<UserRole> ExecuteProcedure(UserRole model, string storedProcedure);
    }
}