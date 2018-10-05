
using Client.Contracts;
using Client.Entities;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace Client.Contracts
{
    public class UserLoginClient : ClientBase<IUserLoginService>, IUserLoginService
    {
        #region IUserLoginService implementation
        public void Add(UserLogin userlogin)
        {
            Channel.Add(userlogin);
        }

        public void Update(UserLogin userlogin)
        {
            Channel.Update(userlogin);
        }

        public void Delete(UserLogin userlogin)
        {
            Channel.Delete(userlogin);
        }

        public UserLogin GetById(int id)
        {
            return Channel.GetById(id);
        }

        public UserLogin[] GetAll()
        {
            return Channel.GetAll();
        }

        public IEnumerable<UserLogin> ExecuteProcedure(UserLogin model, string storedProcedure)
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
