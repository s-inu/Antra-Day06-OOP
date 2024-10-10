namespace OOP.Models;
using Interfaces;

public class Instructor(string name, DateTime dob, DateTime joinDate) : Person(name, dob), IInstructorService
{
    public DateTime JoinDate { get; set; } = joinDate;
    public required Department Department { get; set; }

    public void CalculateExperience()
  {
    Console.WriteLine($"Experience: {DateTime.Now.Year - JoinDate.Year} years");
  }

  public override decimal CalculateSalary()
  {
    var baseSalary = base.CalculateSalary();
    var experienceYears = DateTime.Now.Year - JoinDate.Year;
    return baseSalary + (experienceYears * 1000); // Bonus per year of experience
  }
}
