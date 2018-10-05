using Autofac;
using Autofac.Integration.Mvc;
using Client.Proxies;
using Client.Contracts;

namespace Core.Web
{
    public static class Bootstrapper
    {/// <summary>
        /// Configures and builds Autofac IOC container.
        /// </summary>
        /// <returns></returns>
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            //register controller
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register types
            

            // build container
            return builder.Build();
        }
    }
}