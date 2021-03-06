
using Business.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Business.Services.Contracts
{
    [ErrorBehaviour(typeof(ErrorHandler))]
    [ServiceContract]
    public interface IDDLEventsService
    {
        [OperationContract]
        void Add(DDLEvents ddlevents);

        [OperationContract]
        void Update(DDLEvents ddlevents);

        [OperationContract]
        void Delete(DDLEvents ddlevents);

        [OperationContract]
        DDLEvents GetById(int id);

        [OperationContract]
        DDLEvents[] GetAll();

        [OperationContract]
        IEnumerable<DDLEvents> ExecuteProcedure(DDLEvents model, string storedProcedure);
    }
}