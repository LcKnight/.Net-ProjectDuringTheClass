using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Manager>().ToTable("Manager");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Library>().ToTable("Library");
            modelBuilder.Entity<Shelf>().ToTable("Shelf");
            modelBuilder.Entity<Position>().ToTable("Position");
        }

      
    }

}
