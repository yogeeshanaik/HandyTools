



using Business.Entities;
using Data.Core.Infrastructure;
using System.Linq;

namespace Data.Core.Repositories
{
    
         
    public class DDLEventsRepository : RepositoryBase<DDLEvents>, IUserRepository
    {
        
        public DDLEventsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public DDLEvents ManageDDLEvents(DDLEvents ddlevents)
        {
            return base.ExecuteProcedure(user, "AppName_ManageDDLEvents").FirstOrDefault();
        }            
        
        public interface IDDLEventsRepository : IRepository<User>
        {
            DDLEvents ValidateDDLEvents(DDLEvents ddlevents);
        }
            

    }

            
    public class LocalizedTypesRepository : RepositoryBase<LocalizedTypes>, IUserRepository
    {
        
        public LocalizedTypesRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public LocalizedTypes ManageLocalizedTypes(LocalizedTypes localizedtypes)
        {
            return base.ExecuteProcedure(user, "AppName_ManageLocalizedTypes").FirstOrDefault();
        }            
        
        public interface ILocalizedTypesRepository : IRepository<User>
        {
            LocalizedTypes ValidateLocalizedTypes(LocalizedTypes localizedtypes);
        }
            

    }

            
    public class LocalizedViewsRepository : RepositoryBase<LocalizedViews>, IUserRepository
    {
        
        public LocalizedViewsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public LocalizedViews ManageLocalizedViews(LocalizedViews localizedviews)
        {
            return base.ExecuteProcedure(user, "AppName_ManageLocalizedViews").FirstOrDefault();
        }            
        
        public interface ILocalizedViewsRepository : IRepository<User>
        {
            LocalizedViews ValidateLocalizedViews(LocalizedViews localizedviews);
        }
            

    }

            
    public class NavigationRepository : RepositoryBase<Navigation>, IUserRepository
    {
        
        public NavigationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public Navigation ManageNavigation(Navigation navigation)
        {
            return base.ExecuteProcedure(user, "AppName_ManageNavigation").FirstOrDefault();
        }            
        
        public interface INavigationRepository : IRepository<User>
        {
            Navigation ValidateNavigation(Navigation navigation);
        }
            

    }

            
    public class PermissionRepository : RepositoryBase<Permission>, IUserRepository
    {
        
        public PermissionRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public Permission ManagePermission(Permission permission)
        {
            return base.ExecuteProcedure(user, "AppName_ManagePermission").FirstOrDefault();
        }            
        
        public interface IPermissionRepository : IRepository<User>
        {
            Permission ValidatePermission(Permission permission);
        }
            

    }

            
    public class RoleRepository : RepositoryBase<Role>, IUserRepository
    {
        
        public RoleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public Role ManageRole(Role role)
        {
            return base.ExecuteProcedure(user, "AppName_ManageRole").FirstOrDefault();
        }            
        
        public interface IRoleRepository : IRepository<User>
        {
            Role ValidateRole(Role role);
        }
            

    }

            
    public class RolePermissionRepository : RepositoryBase<RolePermission>, IUserRepository
    {
        
        public RolePermissionRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public RolePermission ManageRolePermission(RolePermission rolepermission)
        {
            return base.ExecuteProcedure(user, "AppName_ManageRolePermission").FirstOrDefault();
        }            
        
        public interface IRolePermissionRepository : IRepository<User>
        {
            RolePermission ValidateRolePermission(RolePermission rolepermission);
        }
            

    }

            
    public class TraceRepository : RepositoryBase<Trace>, IUserRepository
    {
        
        public TraceRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public Trace ManageTrace(Trace trace)
        {
            return base.ExecuteProcedure(user, "AppName_ManageTrace").FirstOrDefault();
        }            
        
        public interface ITraceRepository : IRepository<User>
        {
            Trace ValidateTrace(Trace trace);
        }
            

    }

            
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        
        public UserRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public User ManageUser(User user)
        {
            return base.ExecuteProcedure(user, "AppName_ManageUser").FirstOrDefault();
        }            
        
        public interface IUserRepository : IRepository<User>
        {
            User ValidateUser(User user);
        }
            

    }

            
    public class UserLoginRepository : RepositoryBase<UserLogin>, IUserRepository
    {
        
        public UserLoginRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public UserLogin ManageUserLogin(UserLogin userlogin)
        {
            return base.ExecuteProcedure(user, "AppName_ManageUserLogin").FirstOrDefault();
        }            
        
        public interface IUserLoginRepository : IRepository<User>
        {
            UserLogin ValidateUserLogin(UserLogin userlogin);
        }
            

    }

            
    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRepository
    {
        
        public UserRoleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
            
        public UserRole ManageUserRole(UserRole userrole)
        {
            return base.ExecuteProcedure(user, "AppName_ManageUserRole").FirstOrDefault();
        }            
        
        public interface IUserRoleRepository : IRepository<User>
        {
            UserRole ValidateUserRole(UserRole userrole);
        }
            

    }

        
}