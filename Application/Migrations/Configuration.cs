namespace Application.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Application.Context.DefaultDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Application.Context.DefaultDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.employees.AddOrUpdate(
                new Core.Entity.Employee()
                {
                    Employee_Name = "mynmar",
                    Employee_Address = "yangon",
                    Employee_NRC = "jkdfsajfds"
                }
                );
        }
    }
}
