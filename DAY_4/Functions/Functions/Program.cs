using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 20 PROGRAMS - FOR, WHILE, DO-WHILE LOOPS ===");
        Console.WriteLine("All programs run automatically with sample inputs.\n");

      
        PrintSeries1To20_For(); Console.WriteLine();
        PrintSeries1To20_While(); Console.WriteLine();
        PrintSeries1To20_DoWhile(); Console.WriteLine("\n");

        PrintOddSeries_For(); Console.WriteLine();
        PrintOddSeries_While(); Console.WriteLine();
        PrintOddSeries_DoWhile(); Console.WriteLine("\n");

        PrintEvenSeries_For(); Console.WriteLine();
        PrintEvenSeries_While(); Console.WriteLine();
        PrintEvenSeries_DoWhile(); Console.WriteLine("\n");

        PrintMultiples5_For(); Console.WriteLine();
        PrintMultiples5_While(); Console.WriteLine();
        PrintMultiples5_DoWhile(); Console.WriteLine("\n");

        // 5-8: Sum series
        Console.WriteLine("5-8) Sum Series (n=10 terms):");
        Console.WriteLine("5. Sum 1+2+3+...: " + SumNatural_For(10));
        Console.WriteLine("5. Sum 1+2+3+...: " + SumNatural_While(10));
        Console.WriteLine("5. Sum 1+2+3+...: " + SumNatural_DoWhile(10));
        Console.WriteLine();

        Console.WriteLine("6. Sum 0+2+4+...: " + SumEven_For(10));
        Console.WriteLine("6. Sum 0+2+4+...: " + SumEven_While(10));
        Console.WriteLine("6. Sum 0+2+4+...: " + SumEven_DoWhile(10));
        Console.WriteLine();

        Console.WriteLine("7. Sum 1+3+5+...: " + SumOdd_For(10));
        Console.WriteLine("7. Sum 1+3+5+...: " + SumOdd_While(10));
        Console.WriteLine("7. Sum 1+3+5+...: " + SumOdd_DoWhile(10));
        Console.WriteLine();

        Console.WriteLine("8. Sum 0+5+10+...: " + SumMultiples5_For(10));
        Console.WriteLine("8. Sum 0+5+10+...: " + SumMultiples5_While(10));
        Console.WriteLine("8. Sum 0+5+10+...: " + SumMultiples5_DoWhile(10));
        Console.WriteLine();

        // 9-11: Factorial series
        Console.WriteLine("9-11) Factorial Series (n=5):");
        Console.WriteLine("9. 1/1!+2/2!+...: " + SeriesNFact_For(5));
        Console.WriteLine("9. 1/1!+2/2!+...: " + SeriesNFact_While(5));
        Console.WriteLine("9. 1/1!+2/2!+...: " + SeriesNFact_DoWhile(5));
        Console.WriteLine();

        Console.WriteLine("10. 0+2/2!+4/4!+...: " + SeriesEvenFact_For(4));
        Console.WriteLine("10. 0+2/2!+4/4!+...: " + SeriesEvenFact_While(4));
        Console.WriteLine("10. 0+2/2!+4/4!+...: " + SeriesEvenFact_DoWhile(4));
        Console.WriteLine();

        Console.WriteLine("11. 1/1!+3/3!+5/5!+...: " + SeriesOddFact_For(4));
        Console.WriteLine("11. 1/1!+3/3!+5/5!+...: " + SeriesOddFact_While(4));
        Console.WriteLine("11. 1/1!+3/3!+5/5!+...: " + SeriesOddFact_DoWhile(4));
        Console.WriteLine();

       
        Console.WriteLine("12. Factorial(5):");
        Console.WriteLine("12. 5! = " + Factorial_For(5));
        Console.WriteLine("12. 5! = " + Factorial_While(5));
        Console.WriteLine("12. 5! = " + Factorial_DoWhile(5));
        Console.WriteLine();

        Console.WriteLine("13. Prime Check(29):");
        Console.WriteLine("13. 29 is " + (IsPrime_For(29) ? "Prime" : "Not Prime"));
        Console.WriteLine("13. 29 is " + (IsPrime_While(29) ? "Prime" : "Not Prime"));
        Console.WriteLine("13. 29 is " + (IsPrime_DoWhile(29) ? "Prime" : "Not Prime"));
        Console.WriteLine();

        Console.WriteLine("14. Primes 1-50:");
        PrintPrimes_For(50); Console.WriteLine();
        PrintPrimes_While(50); Console.WriteLine();
        PrintPrimes_DoWhile(50); Console.WriteLine();

    
        Console.WriteLine("15. Armstrong Check(153):");
        Console.WriteLine("15. 153 is " + (IsArmstrong_For(153) ? "Armstrong" : "Not"));
        Console.WriteLine("15. 153 is " + (IsArmstrong_While(153) ? "Armstrong" : "Not"));
        Console.WriteLine("15. 153 is " + (IsArmstrong_DoWhile(153) ? "Armstrong" : "Not"));
        Console.WriteLine();

        Console.WriteLine("16. Armstrong 0-1000:");
        PrintArmstrong_For(1000); Console.WriteLine();
        PrintArmstrong_While(1000); Console.WriteLine();
        PrintArmstrong_DoWhile(1000); Console.WriteLine();

       
        Console.WriteLine("17. Fibonacci (10 terms):");
        PrintFibonacci_For(10); Console.WriteLine();
        PrintFibonacci_While(10); Console.WriteLine();
        PrintFibonacci_DoWhile(10); Console.WriteLine();

        Console.WriteLine("18. 5 Table (1-10):");
        PrintTable5_For(); Console.WriteLine();
        PrintTable5_While(); Console.WriteLine();
        PrintTable5_DoWhile(); Console.WriteLine();

        Console.WriteLine("19. Sum Digits(12345):");
        Console.WriteLine("19. Sum = " + SumDigits_For(12345));
        Console.WriteLine("19. Sum = " + SumDigits_While(12345));
        Console.WriteLine("19. Sum = " + SumDigits_DoWhile(12345));
        Console.WriteLine();

        Console.WriteLine("20. Palindrome Check:");
        Console.WriteLine("20. MALAYALAM: " + (IsPalindrome_For("MALAYALAM") ? "Yes" : "No"));
        Console.WriteLine("20. MALAYALAM: " + (IsPalindrome_While("MALAYALAM") ? "Yes" : "No"));
        Console.WriteLine("20. MALAYALAM: " + (IsPalindrome_DoWhile("MALAYALAM") ? "Yes" : "No"));
        Console.WriteLine("20. BAAB: " + (IsPalindrome_For("BAAB") ? "Yes" : "No"));
        Console.WriteLine("20. LOTUS:" + (IsPalindrome_For("LOTUS") ? "YES" : "NO"));

     
        Console.ReadKey();
    }

    #region 1-4 Series Printing Functions
    static void PrintSeries1To20_For() { Console.Write("1. 1-20 (for): "); for (int i = 1; i <= 20; i++) Console.Write(i + " "); }
    static void PrintSeries1To20_While() { Console.Write("1. 1-20 (while): "); int i = 1; while (i <= 20) { Console.Write(i + " "); i++; } }
    static void PrintSeries1To20_DoWhile() { Console.Write("1. 1-20 (do-while): "); int i = 1; do { Console.Write(i + " "); i++; } while (i <= 20); }

    static void PrintOddSeries_For() { Console.Write("2. Odds (for): "); for (int i = 1; i <= 20; i += 2) Console.Write(i + " "); }
    static void PrintOddSeries_While() { Console.Write("2. Odds (while): "); int i = 1; while (i <= 20) { Console.Write(i + " "); i += 2; } }
    static void PrintOddSeries_DoWhile() { Console.Write("2. Odds (do-while): "); int i = 1; do { Console.Write(i + " "); i += 2; } while (i <= 20); }

    static void PrintEvenSeries_For() { Console.Write("3. Evens (for): "); for (int i = 0; i <= 20; i += 2) Console.Write(i + " "); }
    static void PrintEvenSeries_While() { Console.Write("3. Evens (while): "); int i = 0; while (i <= 20) { Console.Write(i + " "); i += 2; } }
    static void PrintEvenSeries_DoWhile() { Console.Write("3. Evens (do-while): "); int i = 0; do { Console.Write(i + " "); i += 2; } while (i <= 20); }

    static void PrintMultiples5_For() { Console.Write("4. 5s (for): "); for (int i = 0; i <= 25; i += 5) Console.Write(i + " "); }
    static void PrintMultiples5_While() { Console.Write("4. 5s (while): "); int i = 0; while (i <= 25) { Console.Write(i + " "); i += 5; } }
    static void PrintMultiples5_DoWhile() { Console.Write("4. 5s (do-while): "); int i = 0; do { Console.Write(i + " "); i += 5; } while (i <= 25); }
    #endregion

    #region 5-8 Sum Functions
    static int SumNatural_For(int n) { int s = 0; for (int i = 1; i <= n; i++) s += i; return s; }
    static int SumNatural_While(int n) { int s = 0, i = 1; while (i <= n) { s += i; i++; } return s; }
    static int SumNatural_DoWhile(int n) { int s = 0, i = 1; do { s += i; i++; } while (i <= n); return s; }

    static int SumEven_For(int n) { int s = 0; for (int i = 0; i < n; i++) s += 2 * i; return s; }
    static int SumEven_While(int n) { int s = 0, i = 0; while (i < n) { s += 2 * i; i++; } return s; }
    static int SumEven_DoWhile(int n) { int s = 0, i = 0; do { s += 2 * i; i++; } while (i < n); return s; }

    static int SumOdd_For(int n) { int s = 0; for (int i = 0; i < n; i++) s += 2 * i + 1; return s; }
    static int SumOdd_While(int n) { int s = 0, i = 0; while (i < n) { s += 2 * i + 1; i++; } return s; }
    static int SumOdd_DoWhile(int n) { int s = 0, i = 0; do { s += 2 * i + 1; i++; } while (i < n); return s; }

    static int SumMultiples5_For(int n) { int s = 0; for (int i = 0; i < n; i++) s += 5 * i; return s; }
    static int SumMultiples5_While(int n) { int s = 0, i = 0; while (i < n) { s += 5 * i; i++; } return s; }
    static int SumMultiples5_DoWhile(int n) { int s = 0, i = 0; do { s += 5 * i; i++; } while (i < n); return s; }
    #endregion

    #region 9-11 Factorial Series
    static double SeriesNFact_For(int n) { double s = 0; for (int i = 1; i <= n; i++) s += (double)i / Factorial_For(i); return s; }
    static double SeriesNFact_While(int n) { double s = 0; int i = 1; while (i <= n) { s += (double)i / Factorial_While(i); i++; } return s; }
    static double SeriesNFact_DoWhile(int n) { double s = 0; int i = 1; do { s += (double)i / Factorial_DoWhile(i); i++; } while (i <= n); return s; }

    static double SeriesEvenFact_For(int n) { double s = 0; for (int i = 1; i <= n; i++) { int t = 2 * i; s += (double)t / Factorial_For(t); } return s; }
    static double SeriesEvenFact_While(int n) { double s = 0; int i = 1; while (i <= n) { int t = 2 * i; s += (double)t / Factorial_While(t); i++; } return s; }
    static double SeriesEvenFact_DoWhile(int n) { double s = 0; int i = 1; do { int t = 2 * i; s += (double)t / Factorial_DoWhile(t); i++; } while (i <= n); return s; }

    static double SeriesOddFact_For(int n) { double s = 0; for (int i = 0; i < n; i++) { int t = 2 * i + 1; s += (double)t / Factorial_For(t); } return s; }
    static double SeriesOddFact_While(int n) { double s = 0; int i = 0; while (i < n) { int t = 2 * i + 1; s += (double)t / Factorial_While(t); i++; } return s; }
    static double SeriesOddFact_DoWhile(int n) { double s = 0; int i = 0; do { int t = 2 * i + 1; s += (double)t / Factorial_DoWhile(t); i++; } while (i < n); return s; }
    #endregion

    #region 12 Factorial
    static long Factorial_For(int n) { long f = 1; for (int i = 1; i <= n; i++) f *= i; return f; }
    static long Factorial_While(int n) { long f = 1; int i = 1; while (i <= n) { f *= i; i++; } return f; }
    static long Factorial_DoWhile(int n) { long f = 1; int i = 1; do { f *= i; i++; } while (i <= n); return f; }
    #endregion

    #region 13-14 Prime
    static bool IsPrime_For(int n) { if (n <= 1) return false; for (int i = 2; i <= n / 2; i++) if (n % i == 0) return false; return true; }
    static bool IsPrime_While(int n) { if (n <= 1) return false; int i = 2; while (i <= n / 2) { if (n % i == 0) return false; i++; } return true; }
    static bool IsPrime_DoWhile(int n) { if (n <= 1) return false; int i = 2; do { if (n % i == 0) return false; i++; } while (i <= n / 2); return true; }

    static void PrintPrimes_For(int limit) { Console.Write("14. Primes(for): "); for (int i = 2; i <= limit; i++) if (IsPrime_For(i)) Console.Write(i + " "); }
    static void PrintPrimes_While(int limit) { Console.Write("14. Primes(while): "); int i = 2; while (i <= limit) { if (IsPrime_While(i)) Console.Write(i + " "); i++; } }
    static void PrintPrimes_DoWhile(int limit) { Console.Write("14. Primes(do-while): "); int i = 2; do { if (IsPrime_DoWhile(i)) Console.Write(i + " "); i++; } while (i <= limit); }
    #endregion

    #region 15-16 Armstrong
    static bool IsArmstrong_For(int n)
    {
        int orig = n, digits = 0, sum = 0;
        for (int t = n; t > 0; t /= 10) digits++;
        for (int t = n; t > 0; t /= 10) { int d = t % 10; sum += Power_For(d, digits); }
        return sum == orig;
    }
    static bool IsArmstrong_While(int n)
    {
        int orig = n, digits = 0, sum = 0, t = n;
        while (t > 0) { digits++; t /= 10; }
        t = n; while (t > 0) { int d = t % 10; sum += Power_While(d, digits); t /= 10; }
        return sum == orig;
    }
    static bool IsArmstrong_DoWhile(int n)
    {
        int orig = n, digits = 0, sum = 0, t = n;
        do { digits++; t /= 10; } while (t > 0);
        t = n; do { int d = t % 10; sum += Power_DoWhile(d, digits); t /= 10; } while (t > 0);
        return sum == orig;
    }

    static void PrintArmstrong_For(int limit) { Console.Write("16. Armstrong(for): "); for (int i = 0; i <= limit; i++) if (IsArmstrong_For(i)) Console.Write(i + " "); }
    static void PrintArmstrong_While(int limit) { Console.Write("16. Armstrong(while): "); int i = 0; while (i <= limit) { if (IsArmstrong_While(i)) Console.Write(i + " "); i++; } }
    static void PrintArmstrong_DoWhile(int limit) { Console.Write("16. Armstrong(do-while): "); int i = 0; do { if (IsArmstrong_DoWhile(i)) Console.Write(i + " "); i++; } while (i <= limit); }

    static int Power_For(int b, int e) { int r = 1; for (int i = 1; i <= e; i++) r *= b; return r; }
    static int Power_While(int b, int e) { int r = 1; int i = 1; while (i <= e) { r *= b; i++; } return r; }
    static int Power_DoWhile(int b, int e) { int r = 1; int i = 1; do { r *= b; i++; } while (i <= e); return r; }
    #endregion

    #region 17 Fibonacci
    static void PrintFibonacci_For(int terms)
    {
        Console.Write("17. Fibonacci(for): 0 1 ");
        int a = 0, b = 1; for (int i = 3; i <= terms; i++) { int c = a + b; Console.Write(c + " "); a = b; b = c; }
    }
    static void PrintFibonacci_While(int terms)
    {
        Console.Write("17. Fibonacci(while): 0 1 ");
        int a = 0, b = 1, count = 2; while (count < terms) { int c = a + b; Console.Write(c + " "); a = b; b = c; count++; }
    }
    static void PrintFibonacci_DoWhile(int terms)
    {
        Console.Write("17. Fibonacci(do-while): 0 1 ");
        int a = 0, b = 1, count = 2; do { int c = a + b; Console.Write(c + " "); a = b; b = c; count++; } while (count < terms);
    }
    #endregion

    #region 18 Table 5
    static void PrintTable5_For() { Console.Write("18. 5 Table(for): "); for (int i = 1; i <= 10; i++) Console.WriteLine(i + "*5=" + i * 5); }
    static void PrintTable5_While() { Console.Write("18. 5 Table(while): "); int i = 1; while (i <= 10) { Console.WriteLine(i + "*5=" + i * 5); i++; } }
    static void PrintTable5_DoWhile() { Console.Write("18. 5 Table(do-while): "); int i = 1; do { Console.WriteLine(i + "*5=" + i * 5); i++; } while (i <= 10); }
    #endregion

    #region 19 Sum Digits
    static int SumDigits_For(int n) { int s = 0; for (int t = n; t > 0; t /= 10) s += t % 10; return s; }
    static int SumDigits_While(int n) { int s = 0; int t = n; while (t > 0) { s += t % 10; t /= 10; } return s; }
    static int SumDigits_DoWhile(int n) { int s = 0; int t = n; if (t == 0) return 0; do { s += t % 10; t /= 10; } while (t > 0); return s; }
    #endregion

    #region 20 Palindrome
    static bool IsPalindrome_For(string s)
    {
        s = s.ToLower();
        for (int i = 0, j = s.Length - 1; i < j; i++, j--) 
            if (s[i] != s[j])
                return false; 
        return true;
    }
    static bool IsPalindrome_While(string s)
    {
        s = s.ToLower();
        int l = 0, r = s.Length - 1; 
        while (l < r) { if (s[l] != s[r]) return false; 
            l++; r--; }
        return true;
    }
    static bool IsPalindrome_DoWhile(string s)
    {
        s = s.ToLower(); int l = 0, r = s.Length - 1; if (s.Length > 1) do { if (s[l] != s[r]) return false; l++; r--; } while (l < r); return true;
    }
    #endregion
}
