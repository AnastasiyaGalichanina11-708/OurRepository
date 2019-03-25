using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewInstagramApp.Models
{
    public class NewInstagramAppContext : DbContext
    {
        public NewInstagramAppContext (DbContextOptions<NewInstagramAppContext> options)
            : base(options)
        {
        }

        public DbSet<FileModel> FileModels { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments  { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }


        public NewInstagramAppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NewInstagramApp;Trusted_Connection=True;");
        }
    }
}
