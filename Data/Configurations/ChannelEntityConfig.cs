using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class ChannelEntityConfig : IEntityTypeConfiguration<Channel>
    {
        public void Configure(EntityTypeBuilder<Channel> builder)
        {
            builder
                .ToTable("Channel");

            builder
                .Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(255);
        }
    }
}
