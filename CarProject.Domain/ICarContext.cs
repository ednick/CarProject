using CarProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain
{
    public interface ICarContext
    {
        DbSet<Car> Cars { get; set; }
    }
}
