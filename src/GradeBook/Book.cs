using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      Name = name;
    }

    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics() // to tell c# that method return an object with a type of statistics I put statistic class indentifier before method
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;

      foreach (var grade in grades)
      {
        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Average += grade;
      }
      result.Average /= grades.Count;

      return result;
    }

    private List<double> grades;
    public string Name;
  }
}


