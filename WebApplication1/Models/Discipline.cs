namespace WebApplication1.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;


        public bool IsDeleted { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }
}
