using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace LibraryCatalog.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}