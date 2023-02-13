using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WeddingAPI.Models
{
    public class WeddingDbContext : DbContext
    {
        public WeddingDbContext(DbContextOptions<WeddingDbContext> options) 
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        public DbSet<Users> Users { get; set; }
    }
}
