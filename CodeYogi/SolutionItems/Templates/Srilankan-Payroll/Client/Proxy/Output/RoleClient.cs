
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class RoleClient : ClientBase<IRoleService>, IRoleService
    {
        #region IRoleService implementation
        public void Add(Role role)
        {
            Channel.Add(role);
        }

        public void Update(Role role)
        {
            Channel.Update(role);
        }

        public void Delete(Role role)
        {
            Channel.Delete(role);
        }

        public Role GetById(int id)
        {
            return Channel.GetById(id);
        }

        public Role[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<Role> ExecuteProcedure(Role model, string storedProcedure)
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
