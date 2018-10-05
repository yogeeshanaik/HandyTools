
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface ITraceService
    {
        [OperationContract]
        void Add(Trace trace);

        [OperationContract]
        void Update(Trace trace);

        [OperationContract]
        void Delete(Trace trace);

        [OperationContract]
        Trace GetById(int id);

        [OperationContract]
        Trace[] GetAll();

        [OperationContract]
        IEnumerable<Trace> ExecuteProcedure(Trace model, string storedProcedure);
    }
}