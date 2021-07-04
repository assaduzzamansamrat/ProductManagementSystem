using PMSInterface;
using PMSRepository;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PMS
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<ICompanyRepository, CompanyRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}