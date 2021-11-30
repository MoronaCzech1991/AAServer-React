using AAServer.Infra.Identity.IdenityModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AAServer.Infra.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser , ApplicationRole, int>
    {   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional tables.    
            // modelBuilder.Entity<ApplicationUser>().ToTable("AccountUser");
            // modelBuilder.Entity<ApplicationRole>().ToTable("Role");
        }
        
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<ApplicationRoleClaim> ApplicationRoleClaim { get; set; }
        public DbSet<ApplicationUserClaim> ApplicationUserClaim { get; set; }
        public DbSet<ApplicationUserLogin> ApplicationUserLogin { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRole { get; set; }
        public DbSet<ApplicationUserToken> ApplicationUserToken { get; set; }
       
       
    }
}
