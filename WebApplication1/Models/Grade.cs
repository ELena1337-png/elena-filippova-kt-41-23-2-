namespace WebApplication1.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; } = null!;

        public int Value { get; set; } // 2-5

    }
}
