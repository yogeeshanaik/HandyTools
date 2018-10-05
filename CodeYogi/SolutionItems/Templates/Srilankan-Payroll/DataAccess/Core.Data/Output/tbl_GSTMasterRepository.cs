


using Business.Entities;
using Data.Core.Infrastructure;

namespace Data.Core.Repositories
{
    
    public interface Itbl_GSTMasterRepository : IRepository<tbl_GSTMaster>
    {
    }
    
    public class tbl_GSTMasterRepository : RepositoryBase<tbl_GSTMaster>, Itbl_GSTMasterRepository
    {
        
        public tbl_GSTMasterRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
    }

}