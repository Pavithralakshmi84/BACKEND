using System;
using System.Collections.Generic;
using System.Linq; // for Distinct()

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List of integers
            List<int> numbers = new List<int>();

            #region 1. Create and Display Elements
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("List Elements:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 2. Add and Remove Elements
            numbers.Add(40);
            numbers.Remove(20); // removes first occurrence of 20

            Console.WriteLine("After Add and Remove:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 3. Search an Element
            int searchElement = 30;
            if (numbers.Contains(searchElement))
                Console.WriteLine($"{searchElement} found in List.");
            else
                Console.WriteLine($"{searchElement} not found.");
            Console.WriteLine();
            #endregion

            #region 4. Sort Elements
            numbers.Add(5);
            numbers.Add(25);
            numbers.Sort();

            Console.WriteLine("Sorted List:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 5. Find Maximum and Minimum
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"Maximum: {max}, Minimum: {min}");
            Console.WriteLine();
            #endregion

            #region 6. Remove Duplicates
            numbers.Add(30);
            numbers.Add(10);

            List<int> uniqueNumbers = numbers.Distinct().ToList();

            Console.WriteLine("List after removing duplicates:");
            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 7. Count Elements
            Console.WriteLine($"Number of elements in List: {numbers.Count}");
            Console.WriteLine();
            #endregion

            #region 8. Reverse Elements
            numbers.Reverse();
            Console.WriteLine("Reversed List:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
