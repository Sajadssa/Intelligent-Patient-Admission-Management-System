namespace IPAMS_DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IPAMS_DAL.IPAMS_db>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IPAMS_DAL.IPAMS_db";
        }

        protected override void Seed(IPAMS_DAL.IPAMS_db context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
