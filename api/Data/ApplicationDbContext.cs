using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Data.Configurations;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Login> Logins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginConfiguration());
            //modelBuilder.Entity<Login>()
            //    .HasOne(l => l.Profile)
            //    .WithMany()
            //    .HasForeignKey(l => l.profile_id); // Specify foreign key

            // Other entity configurations...
        }

    }
}
