
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class DDLEventsClient : ClientBase<IDDLEventsService>, IDDLEventsService
    {
        #region IDDLEventsService implementation
        public void Add(DDLEvents ddlevents)
        {
            Channel.Add(ddlevents);
        }

        public void Update(DDLEvents ddlevents)
        {
            Channel.Update(ddlevents);
        }

        public void Delete(DDLEvents ddlevents)
        {
            Channel.Delete(ddlevents);
        }

        public DDLEvents GetById(int id)
        {
            return Channel.GetById(id);
        }

        public DDLEvents[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<DDLEvents> ExecuteProcedure(DDLEvents model, string storedProcedure)
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
