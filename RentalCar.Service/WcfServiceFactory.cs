using Microsoft.Practices.Unity;
using RentalCar.Service.Infrastructure;
using RentalCar.Service.Infrastructure.Interfaces;
using RentalCar.Service.Repositories;
using RentalCar.Service.Repositories.Interfaces;
using RentalCar.Service.Services;
using Unity.Wcf;

namespace RentalCar.Service
{
	public class WcfServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            // register all your components with the container here
            // container
            //    .RegisterType<IService1, Service1>()
            //    .RegisterType<DataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IConnection, Connection>();
            container.RegisterType<IVehicleRepository, VehicleRepository>();

        }
    }    
}