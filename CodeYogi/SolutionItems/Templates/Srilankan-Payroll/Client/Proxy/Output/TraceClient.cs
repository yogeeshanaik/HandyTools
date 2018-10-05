
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class TraceClient : ClientBase<ITraceService>, ITraceService
    {
        #region ITraceService implementation
        public void Add(Trace trace)
        {
            Channel.Add(trace);
        }

        public void Update(Trace trace)
        {
            Channel.Update(trace);
        }

        public void Delete(Trace trace)
        {
            Channel.Delete(trace);
        }

        public Trace GetById(int id)
        {
            return Channel.GetById(id);
        }

        public Trace[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<Trace> ExecuteProcedure(Trace model, string storedProcedure)
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
