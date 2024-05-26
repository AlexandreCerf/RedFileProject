using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class Person_ChannelEntityConfig : IEntityTypeConfiguration<Person_Channel>
    {
        public void Configure(EntityTypeBuilder<Person_Channel> builder)
        {
            builder
                .ToTable("Person_Channel");
            builder
                .HasKey(pc => new { pc.PersonId, pc.ChannelId })
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            builder
                .Property(pc => pc.SignInDate)
                .HasColumnType("datetime");

            builder
                .HasOne<Person>(pc => pc.Person).WithMany(p => p.Person_Channel)
                .HasForeignKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder
                .HasOne<Channel>(pc => pc.Channel).WithMany(p => p.Person_Channel)
                .HasForeignKey(p => p.ChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
