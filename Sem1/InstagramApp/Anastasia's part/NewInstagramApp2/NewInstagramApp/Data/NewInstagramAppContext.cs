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

        public DbSet<User> User { get; set; }
        
    }
}
