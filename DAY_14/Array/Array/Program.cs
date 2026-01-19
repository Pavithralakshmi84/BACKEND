using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList list = new ArrayList();

            #region 1. Create and Display Elements
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("ArrayList Elements:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 2. Add and Remove Elements
            list.Add(40);
            list.Remove(20); // removes first occurrence of 20

            Console.WriteLine("After Add and Remove:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 3. Search an Element
            int searchElement = 30;
            if (list.Contains(searchElement))
                Console.WriteLine($"{searchElement} found in ArrayList.");
            else
                Console.WriteLine($"{searchElement} not found.");
            Console.WriteLine();
            #endregion

            #region 4. Sort Elements
            list.Add(5);
            list.Add(25);
            list.Sort();

            Console.WriteLine("Sorted ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 5. Find Maximum and Minimum
            int max = (int)list[0];
            int min = (int)list[0];
            foreach (int item in list)
            {
                if (item > max) max = item;
                if (item < min) min = item;
            }
            Console.WriteLine($"Maximum: {max}, Minimum: {min}");
            Console.WriteLine();
            #endregion

            #region 6. Remove Duplicates
            list.Add(30);
            list.Add(10);

            ArrayList uniqueList = new ArrayList();
            foreach (var item in list)
            {
                if (!uniqueList.Contains(item))
                    uniqueList.Add(item);
            }

            Console.WriteLine("ArrayList after removing duplicates:");
            foreach (var item in uniqueList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region 7. Count Elements
            Console.WriteLine($"Number of elements in ArrayList: {list.Count}");
            Console.WriteLine();
            #endregion

            #region 8. Reverse Elements
            list.Reverse();
            Console.WriteLine("Reversed ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
