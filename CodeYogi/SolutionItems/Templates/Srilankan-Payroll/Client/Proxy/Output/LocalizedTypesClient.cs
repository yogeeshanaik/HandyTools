
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class LocalizedTypesClient : ClientBase<ILocalizedTypesService>, ILocalizedTypesService
    {
        #region ILocalizedTypesService implementation
        public void Add(LocalizedTypes localizedtypes)
        {
            Channel.Add(localizedtypes);
        }

        public void Update(LocalizedTypes localizedtypes)
        {
            Channel.Update(localizedtypes);
        }

        public void Delete(LocalizedTypes localizedtypes)
        {
            Channel.Delete(localizedtypes);
        }

        public LocalizedTypes GetById(int id)
        {
            return Channel.GetById(id);
        }

        public LocalizedTypes[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<LocalizedTypes> ExecuteProcedure(LocalizedTypes model, string storedProcedure)
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
