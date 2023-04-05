using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Domain.Entities;
using SimpleInjector;

namespace CarProject.Domain
{
    public static class ConfigureServices
    {
        public static Container AddDomainServices(this Container services)
        {
            services.Register<ICar, Car>();
            return services;
        }
    }
    
}
