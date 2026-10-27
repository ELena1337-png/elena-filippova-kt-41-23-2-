namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        public bool IsDeleted { get; set; }


        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

    }
}
