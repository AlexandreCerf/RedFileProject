using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class PersonEntityConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .ToTable("Person");
            builder
                .Property(p => p.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder
                .Property(p => p.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            builder
                .Property(p => p.ProfilPicturePath)
                .HasMaxLength(255);
            builder
                .Property(p => p.Description)
                .HasMaxLength(255);
            builder
                .Property(p => p.DateCreatePerson)
                .HasColumnType("datetime");
            builder
                .HasOne<PersonJobTitle>(p => p.PersonJobTitle).WithMany(pjt => pjt.Persons)
                .HasForeignKey(p => p.PersonJobTitleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder
               .HasOne<PersonRole>(p => p.PersonRole).WithMany(pr => pr.Persons)
               .HasForeignKey(p => p.PersonRoleId)
               .OnDelete(DeleteBehavior.ClientSetNull);
            builder
               .HasOne<PersonStatus>(p => p.PersonStatus).WithMany(ps => ps.Persons)
               .HasForeignKey(p => p.PersonStatusId)
               .OnDelete(DeleteBehavior.ClientSetNull);
        } 
    }
}
