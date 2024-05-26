using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class PersonJobTitleEntityConfig : IEntityTypeConfiguration<PersonJobTitle>
    {
        public void Configure(EntityTypeBuilder<PersonJobTitle> builder)
        {
            builder
                .ToTable("PersonJobTitle");
            builder
                .Property(pjt => pjt.Name)
                .HasMaxLength(255);

        }
    }
}
