using CarProject.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.DataAccess;
using SimpleInjector;

namespace CarProject.Service
{
    public static class ConfigureServices
    {
        public static Container AddCarServices(this Container services)
        {
            services.AddRepositoryServices();
            services.Register<ICarService, CarService>();
            return services;
        }
    }
}
