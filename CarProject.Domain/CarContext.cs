﻿using System.Data.Entity;
using CarProject.Domain.Entities;
using EntityFramework.CodeFirst.Migrations;

namespace CarProject.Domain
{
    public class CarContext : DbContext, ICarContext
    {
        public CarContext() : base("name=CarDatabase")
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}
