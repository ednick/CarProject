using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.DataAccess.Repository;
using CarProject.Domain;
using SimpleInjector;

namespace CarProject.DataAccess
{
    public static class ConfigureServices
    {
        public static Container AddRepositoryServices(this Container services)
        {
            services.AddDomainServices();
            services.Register<ICarRepository, CarRepository>();
            return services;
        }
    }
}
