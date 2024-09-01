using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class ManagerDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Borrowings> Borrowings { get; set; }

        public ManagerDbContext() { }

        public ManagerDbContext(DbContextOptions<ManagerDbContext> options)
           : base(options) { }
    }
}
