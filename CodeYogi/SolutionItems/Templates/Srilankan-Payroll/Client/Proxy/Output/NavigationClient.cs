
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class NavigationClient : ClientBase<INavigationService>, INavigationService
    {
        #region INavigationService implementation
        public void Add(Navigation navigation)
        {
            Channel.Add(navigation);
        }

        public void Update(Navigation navigation)
        {
            Channel.Update(navigation);
        }

        public void Delete(Navigation navigation)
        {
            Channel.Delete(navigation);
        }

        public Navigation GetById(int id)
        {
            return Channel.GetById(id);
        }

        public Navigation[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<Navigation> ExecuteProcedure(Navigation model, string storedProcedure)
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
