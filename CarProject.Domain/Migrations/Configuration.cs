using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Domain.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<CarProject.Domain.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            // not allowed migration, if data loss is possible
            //AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(CarProject.Domain.CarContext context)
        {
            //base.Seed(context);
        }
    }
}
