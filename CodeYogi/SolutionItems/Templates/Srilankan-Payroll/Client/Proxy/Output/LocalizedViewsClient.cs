
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class LocalizedViewsClient : ClientBase<ILocalizedViewsService>, ILocalizedViewsService
    {
        #region ILocalizedViewsService implementation
        public void Add(LocalizedViews localizedviews)
        {
            Channel.Add(localizedviews);
        }

        public void Update(LocalizedViews localizedviews)
        {
            Channel.Update(localizedviews);
        }

        public void Delete(LocalizedViews localizedviews)
        {
            Channel.Delete(localizedviews);
        }

        public LocalizedViews GetById(int id)
        {
            return Channel.GetById(id);
        }

        public LocalizedViews[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<LocalizedViews> ExecuteProcedure(LocalizedViews model, string storedProcedure)
        {
            return Channel.ExecuteProcedure(model, storedProcedure);
        }

        #endregion

        public void CleanUp()
        {
            try
            {
                if (base.State != CommunicationState.Faulted)
                    base.Close();
                else
                    base.Abort();
            }
            catch (Exception ex)
            {
                base.Abort();
            }
        }
    }
}
