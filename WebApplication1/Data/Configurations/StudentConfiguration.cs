using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.IsDeleted)
                .HasDefaultValue(false);

            builder.HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(s => s.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasIndex(s => s.GroupId);
            builder.HasIndex(s => s.IsDeleted);
        }
    }
}
