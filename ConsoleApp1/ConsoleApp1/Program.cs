using System;

class Program
{
    static void Main()
    {
        // Fixed size array with 5 elements
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        Console.WriteLine("Array elements:");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.Write(fruits[i] + " ");
        }
        Console.WriteLine();

        // Search input
        Console.Write("Enter fruit to search: ");
        string searchFruit = Console.ReadLine();

        // Linear search - check each position
        bool found = false;
        int position = -1;

        for (int i = 0; i < fruits.Length; i++)
        {
            if (fruits[i] == searchFruit)
            {
                found = true;
                position = i;
                break;  // Stop searching once found
            }
        }

        // Display result
        if (found)
        {
            Console.WriteLine($"'{searchFruit}' found at position {position}");
        }
        else
        {
            Console.WriteLine($"'{searchFruit}' not found");
        }

        Console.ReadKey();
    }
}
