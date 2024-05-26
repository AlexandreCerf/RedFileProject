using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class ReactionEntityConfig : IEntityTypeConfiguration<Reaction>
    {
        public void Configure(EntityTypeBuilder<Reaction> builder)
        {
            builder
                .ToTable("Reaction");
            builder
                .Property(r => r.Name)
                .HasMaxLength(50);
            builder
                .Property(r => r.PicturePath)
                .HasMaxLength(255);

        }
    }
}
