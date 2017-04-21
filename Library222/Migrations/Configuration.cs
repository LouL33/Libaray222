namespace Library222.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library222.DataContext.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library222.DataContext.BookContext context)
        {
            var BookBook = new System.Collections.Generic.List<Models.Books>
            {
                new Models.Books{ Title = "Drunken Specialist", Author = "Sam Rye",Year ="2016", Genre = "Non-Bio",IsCheckedOut = false,LastChechedOut = DateTime.Now, DueBackDate = new DateTime(2017,02,25)  }
            };

            context.Books.AddOrUpdate(a => a.Title, BookBook.First());
            context.SaveChanges();
        }
    }
}
