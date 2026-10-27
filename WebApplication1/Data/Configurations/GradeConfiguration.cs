using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.ToTable("Grades");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Value)
                .IsRequired();

            builder.HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(g => g.Discipline)
                .WithMany(d => d.Grades)
                .HasForeignKey(g => g.DisciplineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(g => g.StudentId);
            builder.HasIndex(g => g.DisciplineId);
        }
    }
}
