﻿namespace BdFirstDemo.Entities;

public partial class Course
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Points { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
