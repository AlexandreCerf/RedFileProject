using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class Person_MessageEntityConfig : IEntityTypeConfiguration<Person_Message>
    {
        public void Configure(EntityTypeBuilder<Person_Message> builder)
        {
            builder
                .ToTable("Person_Message");
            builder
                .HasKey(pm => new { pm.PersonId, pm.MessageId })
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            builder.HasOne<Person>(pm => pm.Person)
                .WithMany(p => p.Person_Message)
                .HasForeignKey(pm => pm.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne<Message>(pm => pm.Message)
                .WithMany(p => p.Person_Message)
                .HasForeignKey(pm => pm.MessageId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
