
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class UserClient : ClientBase<IUserService>, IUserService
    {
        #region IUserService implementation
        public void Add(User user)
        {
            Channel.Add(user);
        }

        public void Update(User user)
        {
            Channel.Update(user);
        }

        public void Delete(User user)
        {
            Channel.Delete(user);
        }

        public User GetById(int id)
        {
            return Channel.GetById(id);
        }

        public User[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<User> ExecuteProcedure(User model, string storedProcedure)
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
