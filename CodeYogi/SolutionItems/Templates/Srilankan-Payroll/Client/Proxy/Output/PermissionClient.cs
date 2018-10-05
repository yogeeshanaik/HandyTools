
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class PermissionClient : ClientBase<IPermissionService>, IPermissionService
    {
        #region IPermissionService implementation
        public void Add(Permission permission)
        {
            Channel.Add(permission);
        }

        public void Update(Permission permission)
        {
            Channel.Update(permission);
        }

        public void Delete(Permission permission)
        {
            Channel.Delete(permission);
        }

        public Permission GetById(int id)
        {
            return Channel.GetById(id);
        }

        public Permission[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<Permission> ExecuteProcedure(Permission model, string storedProcedure)
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
