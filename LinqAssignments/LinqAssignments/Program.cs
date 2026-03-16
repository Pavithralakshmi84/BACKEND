using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignments
{
    public class Student
    {
        public string Name { get; set; } = string.Empty;
        public int Marks { get; set; }
        public int Age { get; set; }


      //  public string? Name { get; set; }   // nullable string
      //  public int Marks { get; set; }
        //public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Example collections
            var numbers = new List<int> { 10, 55, 23, 78, 90, 45 };
            var words = new List<string> { "Apple", "Banana", "Avocado", "Mango" };
            var names = new List<string> { "Peter", "John", "Alice", "Mark" };

            var students = new List<Student>
            {
                new Student { Name = "Ravi", Marks = 80, Age = 20 },
                new Student { Name = "Priya", Marks = 65, Age = 21 },
                new Student { Name = "Arun", Marks = 90, Age = 22 },
                new Student { Name = "Meena", Marks = 35, Age = 20 }
            };

            // 1. Numbers greater than 50
            Console.WriteLine("Numbers > 50: " + string.Join(", ", numbers.Where(n => n > 50)));

            // 2. Even numbers
            Console.WriteLine("Even numbers: " + string.Join(", ", numbers.Where(n => n % 2 == 0)));

            // 3. Odd numbers
            Console.WriteLine("Odd numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));

            // 4. Strings starting with 'A'
            Console.WriteLine("Words starting with A: " + string.Join(", ", words.Where(w => w.StartsWith("A"))));

            // 5. Names containing 'e'
            Console.WriteLine("Names containing 'e': " + string.Join(", ", names.Where(n => n.Contains("e"))));

            // 6. Students scored > 75
            Console.WriteLine("High scorers: " + string.Join(", ", students.Where(s => s.Marks > 75).Select(s => s.Name)));

            // 7. Students age = 20
            Console.WriteLine("Age 20: " + string.Join(", ", students.Where(s => s.Age == 20).Select(s => s.Name)));

            // 8. Marks between 60 and 90
            Console.WriteLine("Marks 60-90: " + string.Join(", ", students.Where(s => s.Marks >= 60 && s.Marks <= 90).Select(s => s.Name)));

            // 9. Any student failed (<40)
            Console.WriteLine("Any failed? " + students.Any(s => s.Marks < 40));

            // 10. All students passed (>=40)
            Console.WriteLine("All passed? " + students.All(s => s.Marks >= 40));
        }
    }
}
