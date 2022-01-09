using System.Runtime.Remoting.Contexts;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Data.AMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Data.AMContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Beggaries.AddOrUpdate(
                b => new {b.IdBeggary}, AddInform.GetBeggary().ToArray());
            context.SaveChanges();


            context.Assasin.AddOrUpdate(
                a => new {a.IdAssassins}, AddInform.GetAssassins().ToArray());
            context.SaveChanges();

            context.Fool.AddOrUpdate(
                a => new { a.IdFools }, AddInform.GetFools().ToArray());
            context.SaveChanges();


            context.Player.AddOrUpdate(p=> new {p.Id},AddInform.GetPlayer().ToArray());
            context.SaveChanges();
        }
        
    }
}
