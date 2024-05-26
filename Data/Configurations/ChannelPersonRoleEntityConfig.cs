using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class ChannelPersonRoleEntityConfig : IEntityTypeConfiguration<ChannelPersonRole>
    {
        public void Configure(EntityTypeBuilder<ChannelPersonRole> builder) 
        {
            builder
                .ToTable("ChannelPersonRole");
            builder
                .Property(cpr => cpr.Name)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
