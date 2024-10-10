namespace OOP.Interfaces;
using Models;

public interface IDepartmentService
{
  void AssignHead(Instructor instructor);
  decimal Budget { get; set; }
}
