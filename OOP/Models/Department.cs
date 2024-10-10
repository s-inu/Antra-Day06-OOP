namespace OOP.Models;
using Interfaces;

public class Department : IDepartmentService
{
  public required Instructor Head { get; set; }
  public List<Course> Courses { get; set; } = [];
  public decimal Budget { get; set; }

  public void AssignHead(Instructor instructor)
  {
    Head = instructor;
  }
}
