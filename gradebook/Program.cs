using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Greg's grade book");

            book.AddGrade(31.1);
            book.AddGrade(43.4);
            book.AddGrade(4.4);

            book.showStats();
        }
    }
}
