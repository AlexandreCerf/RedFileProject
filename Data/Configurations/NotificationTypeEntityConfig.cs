using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class NotificationTypeEntityConfig : IEntityTypeConfiguration<NotificationType>
    {
        public void Configure(EntityTypeBuilder<NotificationType> builder) 
        {
            builder
                .ToTable("NotificationType");
            builder
                .Property(nt => nt.Name)
                .HasMaxLength(255);
        }
    }
}
