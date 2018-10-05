
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void Add(User user);

        [OperationContract]
        void Update(User user);

        [OperationContract]
        void Delete(User user);

        [OperationContract]
        User GetById(int id);

        [OperationContract]
        User[] GetAll();

        [OperationContract]
        IEnumerable<User> ExecuteProcedure(User model, string storedProcedure);
    }
}