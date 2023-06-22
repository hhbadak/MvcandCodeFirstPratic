namespace MVCAndCodeFirstPracticaWeb.Migrations
{
    using MVCAndCodeFirstPracticaWeb.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCAndCodeFirstPracticaModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MVCAndCodeFirstPracticaModel context)
        {
            context.Categories.AddOrUpdate(x => x.ID, new Categories() { ID = 1, Name = "Soft İçecek" });
            context.Suppliers.AddOrUpdate(y => y.ID, new Suppliers() { ID = 1, CompanyName = "Zanilo", Phone = "05372596733", status = true });
            context.Products.AddOrUpdate(z => z.ID, new Products() { ID = 1, Name = "Coca Cola 330ml", CategoryID = 1, SupplierID = 1, UnitPrice = 22.5, Status = true });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
