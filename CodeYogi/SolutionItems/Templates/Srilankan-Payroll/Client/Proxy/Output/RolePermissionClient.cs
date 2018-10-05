
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class RolePermissionClient : ClientBase<IRolePermissionService>, IRolePermissionService
    {
        #region IRolePermissionService implementation
        public void Add(RolePermission rolepermission)
        {
            Channel.Add(rolepermission);
        }

        public void Update(RolePermission rolepermission)
        {
            Channel.Update(rolepermission);
        }

        public void Delete(RolePermission rolepermission)
        {
            Channel.Delete(rolepermission);
        }

        public RolePermission GetById(int id)
        {
            return Channel.GetById(id);
        }

        public RolePermission[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<RolePermission> ExecuteProcedure(RolePermission model, string storedProcedure)
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
