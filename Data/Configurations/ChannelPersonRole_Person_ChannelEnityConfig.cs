using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RedFileProject.Models;

namespace RedFileProject.Data.Configurations
{
    public class ChannelPersonRole_Person_ChannelEnityConfig : IEntityTypeConfiguration<ChannelPersonRole_Person_Channel>
    {
        public void Configure(EntityTypeBuilder<ChannelPersonRole_Person_Channel> builder)
        {
            builder.ToTable("channelpersonrole_person_channel");

            builder.HasKey(cpc => new { cpc.PersonId, cpc.ChannelId })
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            builder
                .Property(cpc => cpc.AffectDate)
                .HasColumnType("datetime");

            builder
                .HasOne<Person>(cpc => cpc.Person)
                .WithMany(m => m.ChannelPersonRole_Person_Channel)
                .HasForeignKey(c => c.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder
                .HasOne<Channel>(cpc => cpc.Channel)
                .WithMany(p => p.ChannelPersonRole_Person_Channel)
                .HasForeignKey(c => c.ChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            builder
                .HasOne<ChannelPersonRole>(cpc => cpc.ChannelPersonRole)
                .WithMany(cpr => cpr.ChannelPersonRole_Person_Channel)
                .HasForeignKey(c => c.ChannelPersonRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
