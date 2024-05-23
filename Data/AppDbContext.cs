using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedFileProject.Models;



namespace RedFileProject.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Channel> MyProperty { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>(entity =>
            {
                entity.Property(m => m.Id).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.Name).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.NormalizedName).HasColumnType("VARCHAR(100)");
            });
            builder.Entity<IdentityUser>(entity =>
            {
                entity.Property(m => m.Id).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.UserName).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.NormalizedUserName).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.Email).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.NormalizedEmail).HasColumnType("VARCHAR(100)");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.Property(m => m.LoginProvider).HasColumnType("VARCHAR(100)");
                entity.Property(m => m.ProviderKey).HasColumnType("VARCHAR(100)");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.Property(m => m.LoginProvider).HasColumnType("VARCHAR(50)");
                entity.Property(m => m.Name).HasColumnType("VARCHAR(50)");
            });

        }
    }
}
