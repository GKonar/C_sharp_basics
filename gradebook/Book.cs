using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);    
        }

        public void showStats()
        {
            var result = 0.0;
            var highGrade = double.MinValue; // the smallest value which U can use as double precission floating point var
            var lowGrade = double.MaxValue;
            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"Average grade {result:N1}");
            Console.WriteLine($"Highest grade in the list: {highGrade}");
            Console.WriteLine($"Smallest grade in the list: {lowGrade}");
        }

        private List<double> grades;
        private string name;
    }
}
