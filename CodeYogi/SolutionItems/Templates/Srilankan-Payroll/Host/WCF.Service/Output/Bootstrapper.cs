using Autofac;
using Business.Services;
using Business.Services.Contracts;
using Data.Core.Infrastructure;
using Data.Core.Repositories;

namespace WCF.Service
{
    public static class Bootstrapper
    {
        /// <summary>
        /// Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            // register UnitOfWork
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<DbFactory>().As<IDbFactory>();
            
            // register services            
            builder.RegisterType<BlogService>().As<IBlogService>();
            builder.RegisterType<ArticleService>().As<IArticleService>();
            builder.RegisterType<UserService>().As<IUserService>();

            

            // register repositories
            builder.RegisterType<ArticleRepository>().As<IArticleRepository>();
            builder.RegisterType<BlogRepository>().As<IBlogRepository>();
            
            

            // build container
            return builder.Build();
        }
    }
}