using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class Person_NotificationEntityConfig : IEntityTypeConfiguration<Person_Notification>
    {
        public void Configure(EntityTypeBuilder<Person_Notification> builder)
        {
            builder
                .ToTable("Person_Notification");
            builder
               .HasKey(pn => new { pn.PersonId, pn.NotificationId })
               .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            builder
                .Property(pn => pn.ReadDate)
                .HasColumnType("datetime");
            builder
                .HasOne<Notification>(pn => pn.Notification)
                .WithMany(n => n.Person_Notification)
                .HasForeignKey(pn=>pn.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder
                .HasOne<Person>(pn => pn.Person)
                .WithMany(p => p.Person_Notification)
                .HasForeignKey(pn => pn.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
