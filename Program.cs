using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15_6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.

            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
               new Classroom { Students = {"Bulat", "Alex", "Galina"} }

            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }


        static string[] GetAllStudents(Classroom[] classes)
        {
            // Решение с помощью LING-запроса.
            var allStudents_0 = from c in classes
                              from s in c.Students
                              select s;

            // Решение с помощью методов расширения.
            var allStudents_1 = classes.SelectMany(c=>c.Students);

            return allStudents_1.ToArray();
        }
    }
}
