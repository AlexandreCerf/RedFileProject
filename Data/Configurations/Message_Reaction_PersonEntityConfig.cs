using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class Message_Reaction_PersonEntityConfig : IEntityTypeConfiguration<Message_Reaction_Person>
    {
        public void Configure(EntityTypeBuilder<Message_Reaction_Person> builder) 
        {
            builder
                .ToTable("Message_Reaction_Person");
            builder
                .HasKey(mrp => new { mrp.PersonId, mrp.MessageId, mrp.ReactionId })
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
            builder
                .HasOne<Message>(mrp => mrp.Message)
                .WithMany(m => m.Message_Reaction_Person)
                .HasForeignKey(c => c.MessageId);
            builder
                .HasOne<Person>(mrp => mrp.Person)
                .WithMany(p => p.Message_Reaction_Person)
                .HasForeignKey(c => c.PersonId);
            builder
                .HasOne<Reaction>(mrp => mrp.Reaction)
                .WithMany(r => r.Message_Reaction_Person)
                .HasForeignKey(c => c.ReactionId);
        }
    }
}
