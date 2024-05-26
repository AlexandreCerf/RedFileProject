using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class ChannelTypeEntityConfig :  IEntityTypeConfiguration<ChannelType>
    {
        public void Configure(EntityTypeBuilder<ChannelType> builder)
        {
            builder
                .ToTable("ChannelType");
            builder
                .Property(ct => ct.ChannelTypeName)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
