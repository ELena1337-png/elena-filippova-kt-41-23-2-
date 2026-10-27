using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("Groups");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(g => g.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(g => g.Specialty)
                .WithMany(s => s.Groups)
                .HasForeignKey(g => g.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(g => g.IsDeleted);
        }
    }
}
