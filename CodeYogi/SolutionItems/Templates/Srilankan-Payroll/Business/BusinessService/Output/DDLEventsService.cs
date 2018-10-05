


using Business.Entities;
using Business.Services.Contracts;
using Data.Core.Infrastructure;
using Data.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    
        public class DDLEventsService : IDDLEventsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDDLEventsRepository _ddleventsRepository;

        public DDLEventsService(IUnitOfWork unitOfWork, IDDLEventsRepository ddleventsRepository)
        {
            _unitOfWork = unitOfWork;
            _ddleventsRepository = ddleventsRepository;
        }
        public void Add(DDLEvents ddlevents)
        {
            _ddleventsRepository.Add(ddlevents);
            _unitOfWork.Commit();
        }

        public void Update(DDLEvents ddlevents)
        {
            _ddleventsRepository.Update(ddlevents);
            _unitOfWork.Commit();
        }

        public void Delete(DDLEvents ddlevents)
        {
            _ddleventsRepository.Delete(ddlevents);
            _unitOfWork.Commit();
        }

        public DDLEvents GetById(int id)
        {
            return _ddleventsRepository.GetById(id);
        }

        public DDLEvents[] GetAll()
        {
            return _ddleventsRepository.GetAll().ToArray();
        }

        public IEnumerable<DDLEvents> ExecuteProcedure(DDLEvents model, string storedProcedure)
        {
            return _ddleventsRepository.ExecuteProcedure(model, storedProcedure);
        }
        
    }

}
    