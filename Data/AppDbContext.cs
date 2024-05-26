using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RedFileProject.Models;
using System.Reflection;



namespace RedFileProject.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Channel> ChannelPersonRoles { get; set; }
        public DbSet<Channel> ChannelPersonRole_Person_Channels { get; set; }
        public DbSet<Channel> ChannelTypes { get; set; }
        public DbSet<Channel> Messages { get; set; }
        public DbSet<Channel> Message_Reaction_Persons { get; set; }
        public DbSet<Channel> Notifications { get; set; }
        public DbSet<Channel> NotificationTypes { get; set; }
        public DbSet<Channel> Persons { get; set; }
        public DbSet<Channel> Person_Channels { get; set; }
        public DbSet<Channel> Person_Messages { get; set; }
        public DbSet<Channel> Person_Notifications { get; set; }
        public DbSet<Channel> PersonJobTitles { get; set; }
        public DbSet<Channel> PersonsStatus { get; set; }
        public DbSet<Channel> Reactions { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Person>(entity =>
            {
                entity.ToTable(name: "Person");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Role");
            });


            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaim");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaim");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogin");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserToken");
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRole");
            });

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
