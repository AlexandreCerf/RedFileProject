using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;



namespace RedFileProject.Data.Configurations
{
    public class AttachmentEntityConfig : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder
                .ToTable("Attachment");

            builder
                .Property(a => a.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder
                .Property(a => a.Path)
                .HasColumnType("varchar")
                .HasMaxLength(255);

            builder
                .HasOne<Message>(a => a.Message).WithMany(m => m.Attachments)
                .HasForeignKey(a => a.AttachmentId);
        }
    }
}
