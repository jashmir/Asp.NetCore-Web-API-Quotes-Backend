namespace WebAPIQuotesBackend.EntitiesMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIQuotesBackend.Data.QuoteServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"EntitiesMigrations";
            ContextKey = "WebAPIQuotesBackend.Data.QuoteServiceContext";
        }

        protected override void Seed(WebAPIQuotesBackend.Data.QuoteServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
