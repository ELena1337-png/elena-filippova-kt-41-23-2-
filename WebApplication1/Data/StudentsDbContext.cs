using WebApplication1.Data.Configurations;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Discipline> Disciplines { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SpecialtyConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
