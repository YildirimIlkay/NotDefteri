namespace NotDefteri.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NotDefteri.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NotDefteri.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Notes.Any())
            {
                context.Notes.Add(new Data.Note()
                {
                    Title = "New Clock",
                    Content = "What time is it when the clock strikes 13?" +
                    "\r\n Time to get a new clock"
                });
                context.Notes.Add(new Data.Note()
                {
                    Title = "Balloon",
                    Content = "Why can't Elsa from Frozen have a balloon" + 
                    "\r\n Because she will 'let it go,let it go'"
                });
                context.Notes.Add(new Data.Note()
                {
                    Title = "Magician",
                    Content = "What do you call a dog magician?" + 
                    "\r\n A labracadabrador"
                });
            }
        }
    }
}
