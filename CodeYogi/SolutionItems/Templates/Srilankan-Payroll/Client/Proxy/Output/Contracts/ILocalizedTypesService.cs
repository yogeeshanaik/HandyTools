
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface ILocalizedTypesService
    {
        [OperationContract]
        void Add(LocalizedTypes localizedtypes);

        [OperationContract]
        void Update(LocalizedTypes localizedtypes);

        [OperationContract]
        void Delete(LocalizedTypes localizedtypes);

        [OperationContract]
        LocalizedTypes GetById(int id);

        [OperationContract]
        LocalizedTypes[] GetAll();

        [OperationContract]
        IEnumerable<LocalizedTypes> ExecuteProcedure(LocalizedTypes model, string storedProcedure);
    }
}