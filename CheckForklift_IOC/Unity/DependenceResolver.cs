using CheckForklift.Interfaces.Repositories;
using CheckForklift.Interfaces.Services;
using CheckForklift.Services;
using CheckForklift_Infra.Persistence.Repositories;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace CheckForklift.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            //UnitOfWork
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            container.RegisterType<IServicesDispositivos, ServicesDispositivos>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicesUtilizacoes, ServicesUtilizacoes>(new HierarchicalLifetimeManager());
            container.RegisterType<IServicesVeiculos, ServicesVeiculos>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceUsuarios, ServicesUsuarios>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType<IRepositoryDispositivos, RepositoryDispositivos>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryUsuarios, RepositoryUsuario>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryUtilizacao, RepositoryUtilizacao>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryVeiculos, RepositoryVeiculos>(new HierarchicalLifetimeManager());
        }
    }
}