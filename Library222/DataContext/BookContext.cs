using Library222.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library222.DataContext
{
    public class BookContext :DbContext
    {
        public BookContext() : base("name=DefaultConnection")
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}