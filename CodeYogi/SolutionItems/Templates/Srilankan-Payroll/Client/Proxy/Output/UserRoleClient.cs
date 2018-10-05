
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class UserRoleClient : ClientBase<IUserRoleService>, IUserRoleService
    {
        #region IUserRoleService implementation
        public void Add(UserRole userrole)
        {
            Channel.Add(userrole);
        }

        public void Update(UserRole userrole)
        {
            Channel.Update(userrole);
        }

        public void Delete(UserRole userrole)
        {
            Channel.Delete(userrole);
        }

        public UserRole GetById(int id)
        {
            return Channel.GetById(id);
        }

        public UserRole[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<UserRole> ExecuteProcedure(UserRole model, string storedProcedure)
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
