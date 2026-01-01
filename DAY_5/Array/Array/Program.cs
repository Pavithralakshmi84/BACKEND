using System;

namespace BeginnerCSharpPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PrintPyramid();
            Console.WriteLine();

            SwapNumbers();
            Console.WriteLine();

            FindMinMax();
            Console.WriteLine();

            CountDuplicates();
            Console.WriteLine();

            MergeSortedArrays();
            Console.WriteLine();

            MatrixMultiplication();
            Console.WriteLine();

                       Console.ReadKey();
        }

        #region 1. Pyramid Star Pattern
     
        static void PrintPyramid()
        {
            Console.WriteLine("1. Pyramid Star Pattern (rows=5):");
            int rows = 5; 

            for (int i = 1; i <= rows; i++)
            {
                // Print spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region 2. Swap Numbers without Third Variable
        
        static void SwapNumbers()
        {
            Console.WriteLine("2. Swap Numbers without Third Variable:");
            int a = 10;  
            int b = 20;  

            Console.WriteLine($"Sample Input - Before swap: a={a}, b={b}");

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swap: a={a}, b={b}");
        }
        #endregion

        #region 3. Min and Max in Array
        /// <summarycompl
        /// Finds minimum and maximum elements in sample array {64, 34, 25, 12, 22}.
        /// Initializes min/max with first element, then compares rest.
        /// </summary>
        static void FindMinMax()
        {
            Console.WriteLine("3. Min and Max in Array:");
            int[] arr = { 64, 34, 25, 12, 22 };  

            Console.WriteLine("Sample Array: [" + string.Join(", ", arr) + "]");

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"Minimum: {min}, Maximum: {max}");
        }
        #endregion

        #region 4. Count Duplicate Elements
       
        static void CountDuplicates()
        {
            Console.WriteLine("4. Count Duplicate Elements:");
            int[] arr = { 1, 2, 3, 2, 4, 1, 5, 3 };  
            int n = arr.Length;

            Console.WriteLine("Sample Array: [" + string.Join(", ", arr) + "]");

            int[] count = new int[n];
            for (int i = 0; i < n; i++)
                count[i] = 1; // Initialize count

            int duplicates = 0;
            for (int i = 0; i < n; i++)
            {
                if (count[i] == 1) 
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count[j] = 2;  
                            duplicates++;
                        }
                    }
                }
            }

            Console.WriteLine($"Total duplicate elements: {duplicates}");
        }
        #endregion

        #region 5. Merge Two Sorted Arrays
        
        static void MergeSortedArrays()
        {
            Console.WriteLine("5. Merge Two Sorted Arrays:");
            int[] arr1 = { 1, 3, 5 }; 
            int[] arr2 = { 2, 4, 6 }; 
            int n = arr1.Length;
            int[] merged = new int[2 * n];

            Console.WriteLine("Array 1: [" + string.Join(", ", arr1) + "]");
            Console.WriteLine("Array 2: [" + string.Join(", ", arr2) + "]");

            // Copy to merged
            for (int i = 0; i < n; i++) merged[i] = arr1[i];
            for (int i = 0; i < n; i++) merged[n + i] = arr2[i];

            // Bubble sort merged array
            for (int i = 0; i < 2 * n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    if (merged[j] > merged[j + 1])
                    {
                        int temp = merged[j];
                        merged[j] = merged[j + 1];
                        merged[j + 1] = temp;
                    }
                }
            }

            Console.Write("Merged sorted array: [" + string.Join(", ", merged) + "]");
            Console.WriteLine();
        }
        #endregion

        #region 6. Matrix Multiplication

        static void MatrixMultiplication()
        {
            Console.WriteLine("6. Matrix Multiplication (2x2 matrices):");
            int[,] mat1 = { { 1, 2 }, { 3, 4 } }; // Sample matrix 1
            int[,] mat2 = { { 5, 6 }, { 7, 8 } }; // Sample matrix 2
            int[,] result = new int[2, 2];
            int n = 2;

            Console.WriteLine("Matrix 1:");
            PrintMatrix(mat1, n);
            Console.WriteLine("Matrix 2:");
            PrintMatrix(mat2, n);

            // Multiply
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        result[i, j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }

            Console.WriteLine("Result matrix:");
            PrintMatrix(result, n);
        }

        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
