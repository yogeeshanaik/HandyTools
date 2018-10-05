
using Client.Entities;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    [ServiceContract]
    public interface ILocalizedViewsService
    {
        [OperationContract]
        void Add(LocalizedViews localizedviews);

        [OperationContract]
        void Update(LocalizedViews localizedviews);

        [OperationContract]
        void Delete(LocalizedViews localizedviews);

        [OperationContract]
        LocalizedViews GetById(int id);

        [OperationContract]
        LocalizedViews[] GetAll();

        [OperationContract]
        IEnumerable<LocalizedViews> ExecuteProcedure(LocalizedViews model, string storedProcedure);
    }
}