


using Business.Entities;
using Business.Services.Contracts;
using Data.Core.Infrastructure;
using Data.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    
        public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }
        public void Add(User user)
        {
            _userRepository.Add(user);
            _unitOfWork.Commit();
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
            _unitOfWork.Commit();
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
            _unitOfWork.Commit();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User[] GetAll()
        {
            return _userRepository.GetAll().ToArray();
        }

        public IEnumerable<User> ExecuteProcedure(User model, string storedProcedure)
        {
            return _userRepository.ExecuteProcedure(model, storedProcedure);
        }
        
    }

}
    