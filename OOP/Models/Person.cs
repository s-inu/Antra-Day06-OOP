namespace OOP.Models;
using Interfaces;

public abstract class Person(string name, DateTime dob) : IPersonService
{
    public string Name { get; set; } = name;
    public DateTime DateOfBirth { get; set; } = dob;
    protected decimal salary;
  public List<string> Addresses { get; set; } = new List<string>();

    public void CalculateAge()
  {
    Console.WriteLine($"Age: {DateTime.Now.Year - DateOfBirth.Year} years");
  }

  public virtual decimal CalculateSalary()
  {
    if (salary < 0) throw new ArgumentOutOfRangeException("Salary cannot be negative.");
    return salary;
  }

  public List<string> GetAddresses()
  {
    return Addresses;
  }
}
