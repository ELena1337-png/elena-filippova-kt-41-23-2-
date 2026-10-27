namespace WebApplication1.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null!;

        public bool IsDeleted { get; set; }


        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
