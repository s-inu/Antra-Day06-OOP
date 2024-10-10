namespace OOP.Models;
using Interfaces;

public class Course : ICourseService
{
  public required string Name { get; set; }
  public List<Student> EnrolledStudents { get; set; } = new List<Student>();

  public void EnrollStudent(Student student)
  {
    EnrolledStudents.Add(student);
  }
}

