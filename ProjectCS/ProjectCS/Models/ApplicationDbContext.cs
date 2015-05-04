using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ProjectCS.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                .HasMany(t => t.Likes)
                .WithMany(t => t.Likes)
                .Map(m =>
                {
                    m.ToTable("Likes");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("ProjectId");
                });

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(t => t.Following)
                .WithMany(t => t.Followers)
                .Map(m =>
                {
                    m.ToTable("Followers");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("ProjectId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}