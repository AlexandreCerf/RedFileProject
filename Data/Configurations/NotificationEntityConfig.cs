using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class NotificationEntityConfig : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder
                .ToTable("Notification");
            builder
                .Property(n => n.Name)
                .HasMaxLength(255)
                .HasColumnType("varchar");
            builder
                .Property(n => n.Content)
                .HasMaxLength(255);
            builder
                .Property(n => n.NotificationDate)
                .HasColumnType("datetime");

            builder
                .HasOne<NotificationType>(n => n.NotificationType)
                .WithMany(nt => nt.Notifications)
                .HasForeignKey(nt => nt.NotificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);


        }
    }
}
