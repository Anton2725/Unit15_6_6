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

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = from c in classes
                              from s in c.Students
                              select s;

            return allStudents.ToArray();
        }
    }
}
