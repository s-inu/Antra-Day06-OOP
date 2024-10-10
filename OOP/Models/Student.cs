namespace OOP.Models;
using Interfaces;


public class Student(string name, DateTime dob) : Person(name, dob), IStudentService
{
  public List<Course> Courses { get; set; } = new List<Course>();

    public void CalculateGPA()
  {
    Console.WriteLine("Calculating GPA based on course grades...");
    // GPA calculation logic would be implemented here
  }
}
