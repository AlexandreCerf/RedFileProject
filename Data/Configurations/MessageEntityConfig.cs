using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class MessageEntityConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder
                .ToTable("Message");
            builder
                .Property(m => m.Text)
                .HasColumnType("text");

            builder
                .Property(m => m.DatePost)
                .HasColumnType("datetime");
            builder
                .HasOne<Channel>(m => m.Channel)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.ChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder
                .HasOne<Person>(m => m.Person)
                .WithMany(c => c.Messages)
                .HasForeignKey(c => c.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
