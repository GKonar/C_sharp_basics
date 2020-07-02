using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new[] { 12.7, 15.5, 12.2, 3 }; // array holding numbers and in {} we keep the initial numbers
            var grades = new List<double>() { 12.7, 15.5, 12.2, 3 }; // create a new list of double
            grades.Add(56.1);

            var result = 0.0;
            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"Average grade {result:N1}"); 

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
