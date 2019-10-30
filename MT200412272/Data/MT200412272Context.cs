using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MT200412272.Models
{
    public class MT200412272Context : DbContext
    {
        public MT200412272Context (DbContextOptions<MT200412272Context> options)
            : base(options)
        {
        }

        public DbSet<MT200412272.Models.Forum> Forum { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Forum>().HasData(
                new Models.Forum() { Id = 1, name = "Meisam", comment = "It is a good webpage!", date = DateTime.Today },
                new Models.Forum() { Id = 2, name = "Koohaki", comment = "It is awsome!", date = DateTime.Today }
             ); 

        }
    }
}
