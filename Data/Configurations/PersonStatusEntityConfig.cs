using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class PersonStatusEntityConfig : IEntityTypeConfiguration<PersonStatus>
    {
        public void Configure(EntityTypeBuilder<PersonStatus> builder)
        {
            builder
                .ToTable("PersonStatus");
            builder
                .Property(ps => ps.Name)
                .HasMaxLength(255);
        }
    }
}
