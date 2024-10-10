using System;

namespace OOP.Interfaces;

public interface IInstructorService
{
  public interface IInstructorService : IPersonService
  {
    void CalculateExperience();
  }
}
