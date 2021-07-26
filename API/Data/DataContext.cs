using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
         public DbSet<Specialization> Specializations { get; set; }
          public DbSet<Associate> Associates { get; set; }
          public DbSet<AppUser> Users { get; set; }
    }  
}