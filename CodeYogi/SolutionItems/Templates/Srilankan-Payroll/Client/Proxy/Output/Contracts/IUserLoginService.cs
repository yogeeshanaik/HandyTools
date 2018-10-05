
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface IUserLoginService
    {
        [OperationContract]
        void Add(UserLogin userlogin);

        [OperationContract]
        void Update(UserLogin userlogin);

        [OperationContract]
        void Delete(UserLogin userlogin);

        [OperationContract]
        UserLogin GetById(int id);

        [OperationContract]
        UserLogin[] GetAll();

        [OperationContract]
        IEnumerable<UserLogin> ExecuteProcedure(UserLogin model, string storedProcedure);
    }
}