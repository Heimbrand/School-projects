namespace BdFirstDemo.Entities;

public partial class Student
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
