using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== 20 PROGRAMS - FOR, WHILE, DO-WHILE (NO FUNCTIONS) ===");
        Console.WriteLine("All programs run automatically with sample inputs.\n");

        #region 1. Series 1 to 20
        Console.Write("1. 1-20 (for):    ");
        for (int i = 1; i <= 20; i++) Console.Write(i + " ");
        Console.WriteLine();

        Console.Write("1. 1-20 (while):  ");
        { int i = 1; while (i <= 20) { Console.Write(i + " "); i++; } }
        Console.WriteLine();

        Console.Write("1. 1-20 (do):     ");
        { int i = 1; do { Console.Write(i + " "); i++; } while (i <= 20); }
        Console.WriteLine();
        #endregion

        #region 2. Odd series 1-19
        Console.Write("2. Odds (for):    ");
        for (int i = 1; i <= 20; i += 2) Console.Write(i + " ");
        Console.WriteLine();

        Console.Write("2. Odds (while):  ");
        { int i = 1; while (i <= 20) { Console.Write(i + " "); i += 2; } }
        Console.WriteLine();

        Console.Write("2. Odds (do):     ");
        { int i = 1; do { Console.Write(i + " "); i += 2; } while (i <= 20); }
        Console.WriteLine();
        #endregion

        #region 3. Even series 0-20
        Console.Write("3. Evens (for):   ");
        for (int i = 0; i <= 20; i += 2) Console.Write(i + " ");
        Console.WriteLine();

        Console.Write("3. Evens (while): ");
        { int i = 0; while (i <= 20) { Console.Write(i + " "); i += 2; } }
        Console.WriteLine();

        Console.Write("3. Evens (do):    ");
        { int i = 0; do { Console.Write(i + " "); i += 2; } while (i <= 20); }
        Console.WriteLine();
        #endregion

        #region 4. Multiples of 5 (0-25)
        Console.Write("4. 5s (for):      ");
        for (int i = 0; i <= 25; i += 5) Console.Write(i + " ");
        Console.WriteLine();

        Console.Write("4. 5s (while):    ");
        { int i = 0; while (i <= 25) { Console.Write(i + " "); i += 5; } }
        Console.WriteLine();

        Console.Write("4. 5s (do):       ");
        { int i = 0; do { Console.Write(i + " "); i += 5; } while (i <= 25); }
        Console.WriteLine();
        #endregion

        #region 5. Sum 1+2+3+... (n=10)
        Console.WriteLine("5. Sum 1+2+...+10:");
        { int sum = 0; for (int i = 1; i <= 10; i++) sum += i; Console.WriteLine("for: " + sum); }
        { int sum = 0, i = 1; while (i <= 10) { sum += i; i++; } Console.WriteLine("while: " + sum); }
        { int sum = 0, i = 1; do { sum += i; i++; } while (i <= 10); Console.WriteLine("do: " + sum); }
        #endregion

        #region 6. Sum evens 0+2+4+... (10 terms)
        Console.WriteLine("6. Sum 0+2+4+...:");
        { int sum = 0; for (int i = 0; i < 10; i++) sum += 2 * i; Console.WriteLine("for: " + sum); }
        { int sum = 0, i = 0; while (i < 10) { sum += 2 * i; i++; } Console.WriteLine("while: " + sum); }
        { int sum = 0, i = 0; do { sum += 2 * i; i++; } while (i < 10); Console.WriteLine("do: " + sum); }
        #endregion

        #region 7. Sum odds 1+3+5+... (10 terms)
        Console.WriteLine("7. Sum 1+3+5+...:");
        { int sum = 0; for (int i = 0; i < 10; i++) sum += 2 * i + 1; Console.WriteLine("for: " + sum); }
        { int sum = 0, i = 0; while (i < 10) { sum += 2 * i + 1; i++; } Console.WriteLine("while: " + sum); }
        { int sum = 0, i = 0; do { sum += 2 * i + 1; i++; } while (i < 10); Console.WriteLine("do: " + sum); }
        #endregion

        #region 8. Sum 0+5+10+... (10 terms)
        Console.WriteLine("8. Sum 0+5+10+...:");
        { int sum = 0; for (int i = 0; i < 10; i++) sum += 5 * i; Console.WriteLine("for: " + sum); }
        { int sum = 0, i = 0; while (i < 10) { sum += 5 * i; i++; } Console.WriteLine("while: " + sum); }
        { int sum = 0, i = 0; do { sum += 5 * i; i++; } while (i < 10); Console.WriteLine("do: " + sum); }
        #endregion

        #region 9. Series n/n! (n=5)
        Console.WriteLine("9. 1/1!+2/2!+...:");
        { double sum = 0; for (int i = 1; i <= 5; i++) { double f = 1; for (int j = 1; j <= i; j++) f *= j; sum += (double)i / f; } Console.WriteLine("for: " + sum); }
        { double sum = 0; int i = 1; while (i <= 5) { double f = 1; int j = 1; while (j <= i) { f *= j; j++; } sum += (double)i / f; i++; } Console.WriteLine("while: " + sum); }
        { double sum = 0; int i = 1; do { double f = 1; int j = 1; do { f *= j; j++; } while (j <= i); sum += (double)i / f; i++; } while (i <= 5); Console.WriteLine("do: " + sum); }
        #endregion

        #region 10. Series even/n! (4 terms)
        Console.WriteLine("10. 0+2/2!+4/4!+...:");
        { double sum = 0; for (int i = 1; i <= 4; i++) { int t = 2 * i; double f = 1; for (int j = 1; j <= t; j++) f *= j; sum += (double)t / f; } Console.WriteLine("for: " + sum); }
        { double sum = 0; int i = 1; while (i <= 4) { int t = 2 * i; double f = 1; int j = 1; while (j <= t) { f *= j; j++; } sum += (double)t / f; i++; } Console.WriteLine("while: " + sum); }
        { double sum = 0; int i = 1; do { int t = 2 * i; double f = 1; int j = 1; do { f *= j; j++; } while (j <= t); sum += (double)t / f; i++; } while (i <= 4); Console.WriteLine("do: " + sum); }
        #endregion

        #region 11. Series odd/n! (4 terms)
        Console.WriteLine("11. 1/1!+3/3!+...:");
        { double sum = 0; for (int i = 0; i < 4; i++) { int t = 2 * i + 1; double f = 1; for (int j = 1; j <= t; j++) f *= j; sum += (double)t / f; } Console.WriteLine("for: " + sum); }
        { double sum = 0; int i = 0; while (i < 4) { int t = 2 * i + 1; double f = 1; int j = 1; while (j <= t) { f *= j; j++; } sum += (double)t / f; i++; } Console.WriteLine("while: " + sum); }
        { double sum = 0; int i = 0; do { int t = 2 * i + 1; double f = 1; int j = 1; do { f *= j; j++; } while (j <= t); sum += (double)t / f; i++; } while (i < 4); Console.WriteLine("do: " + sum); }
        #endregion

        #region 12. Factorial 5! = 120
        Console.WriteLine("12. 5! = 120:");
        { long f = 1; for (int i = 1; i <= 5; i++) f *= i; Console.WriteLine("for: " + f); }
        { long f = 1; int i = 1; while (i <= 5) { f *= i; i++; } Console.WriteLine("while: " + f); }
        { long f = 1; int i = 1; do { f *= i; i++; } while (i <= 5); Console.WriteLine("do: " + f); }
        #endregion

        #region 13. Prime check (29)
        Console.WriteLine("13. 29 Prime?:");
        { bool p = true; int n = 29; if (n > 1) for (int i = 2; i <= n / 2; i++) if (n % i == 0) { p = false; break; } Console.WriteLine("for: " + (p ? "Yes" : "No")); }
        { bool p = true; int n = 29; if (n > 1) { int i = 2; while (i <= n / 2) { if (n % i == 0) { p = false; break; } i++; } } Console.WriteLine("while: " + (p ? "Yes" : "No")); }
        { bool p = true; int n = 29; if (n > 1) { int i = 2; do { if (n % i == 0) { p = false; break; } i++; } while (i <= n / 2); } Console.WriteLine("do: " + (p ? "Yes" : "No")); }
        #endregion

        #region 14. Prime series 1-50
        Console.Write("14. Primes 1-50 (for):  ");
        { for (int n = 2; n <= 50; n++) { bool p = true; for (int i = 2; i <= n / 2; i++) if (n % i == 0) { p = false; break; } if (p) Console.Write(n + " "); } }
        Console.WriteLine();

        Console.Write("14. Primes 1-50 (while):");
        { int n = 2; while (n <= 50) { bool p = true; int i = 2; while (i <= n / 2) { if (n % i == 0) { p = false; break; } i++; } if (p) Console.Write(n + " "); n++; } }
        Console.WriteLine();

        Console.Write("14. Primes 1-50 (do):  ");
        { int n = 2; do { bool p = true; int i = 2; do { if (n % i == 0) { p = false; break; } i++; } while (i <= n / 2); if (p) Console.Write(n + " "); n++; } while (n <= 50); }
        Console.WriteLine();
        #endregion

        #region 15. Armstrong 153
        Console.WriteLine("15. 153 Armstrong?:");
        { int n = 153, t = n, d = 0, sum = 0; for (; t > 0; t /= 10) d++; t = n; for (; t > 0; t /= 10) { int x = t % 10; int p = 1; for (int j = 1; j <= d; j++) p *= x; sum += p; } Console.WriteLine("for: " + (sum == n ? "Yes" : "No")); }
        { int n = 153, t = n, d = 0; while (t > 0) { d++; t /= 10; } t = n; int sum = 0; while (t > 0) { int x = t % 10; int p = 1; int j = 1; while (j <= d) { p *= x; j++; } sum += p; t /= 10; } Console.WriteLine("while: " + (sum == n ? "Yes" : "No")); }
        { int n = 153, t = n, d = 0; do { d++; t /= 10; } while (t > 0); t = n; int sum = 0; do { int x = t % 10; int p = 1; int j = 1; do { p *= x; j++; } while (j <= d); sum += p; t /= 10; } while (t > 0); Console.WriteLine("do: " + (sum == n ? "Yes" : "No")); }
        #endregion

        #region 16. Armstrong series 0-1000
        Console.Write("16. Armstrong (for): ");
        { for (int n = 0; n <= 1000; n++) { int t = n, d = 0; for (int x = t; x > 0; x /= 10) d++; t = n; int sum = 0; for (int x = t; x > 0; x /= 10) { int dig = x % 10; int p = 1; for (int j = 1; j <= d; j++) p *= dig; sum += p; } if (sum == n) Console.Write(n + " "); } }
        Console.WriteLine();

        Console.Write("16. Armstrong (while): ");
        { int n = 0; while (n <= 1000) { int t = n, d = 0; int x = t; while (x > 0) { d++; x /= 10; } t = n; int sum = 0; x = t; while (x > 0) { int dig = x % 10; int p = 1; int j = 1; while (j <= d) { p *= dig; j++; } sum += p; x /= 10; } if (sum == n) Console.Write(n + " "); n++; } }
        Console.WriteLine();
        #endregion

        #region 17. Fibonacci (10 terms)
        Console.Write("17. Fibonacci (for): 0 1 ");
        { int a = 0, b = 1; for (int i = 3; i <= 10; i++) { int c = a + b; Console.Write(c + " "); a = b; b = c; } }
        Console.WriteLine();

        Console.Write("17. Fibonacci (while): 0 1 ");
        { int a = 0, b = 1, count = 2; while (count < 10) { int c = a + b; Console.Write(c + " "); a = b; b = c; count++; } }
        Console.WriteLine();

        Console.Write("17. Fibonacci (do): 0 1 ");
        { int a = 0, b = 1, count = 2; do { int c = a + b; Console.Write(c + " "); a = b; b = c; count++; } while (count < 10); }
        Console.WriteLine();
        #endregion

        #region 18. 5 Table (1-10)
        Console.WriteLine("18. 5 Table:");
        { for (int i = 1; i <= 10; i++) Console.WriteLine("for: " + i + " * 5 = " + (i * 5)); }
        { int i = 1; while (i <= 10) { Console.WriteLine("while: " + i + " * 5 = " + (i * 5)); i++; } }
        { int i = 1; do { Console.WriteLine("do: " + i + " * 5 = " + (i * 5)); i++; } while (i <= 10); }
        #endregion

        #region 19. Sum digits 12345
        Console.WriteLine("19. Sum digits 12345:");
        { int n = 12345, sum = 0; for (int t = n; t > 0; t /= 10) sum += t % 10; Console.WriteLine("for: " + sum); }
        { int n = 12345, sum = 0, t = n; while (t > 0) { sum += t % 10; t /= 10; } Console.WriteLine("while: " + sum); }
        { int n = 12345, sum = 0, t = n; do { sum += t % 10; t /= 10; } while (t > 0); Console.WriteLine("do: " + sum); }
        #endregion

        #region 20. Palindrome MALAYALAM
        Console.WriteLine("20. MALAYALAM Palindrome?:");
        { string s = "MALAYALAM".ToLower(); bool p = true; for (int i = 0, j = s.Length - 1; i < j; i++, j--) if (s[i] != s[j]) { p = false; break; } Console.WriteLine("for: " + (p ? "Yes" : "No")); }
        { string s = "MALAYALAM".ToLower(); bool p = true; int l = 0, r = s.Length - 1; while (l < r) { if (s[l] != s[r]) { p = false; break; } l++; r--; } Console.WriteLine("while: " + (p ? "Yes" : "No")); }
        { string s = "MALAYALAM".ToLower(); bool p = true; int l = 0, r = s.Length - 1; do { if (s[l] != s[r]) { p = false; break; } l++; r--; } while (l < r); Console.WriteLine("do: " + (p ? "Yes" : "No")); }
        Console.WriteLine("BAAB: " + (IsPalindromeInline("BAAB") ? "Yes" : "No"));
        #endregion

        
        Console.ReadKey();
    }

   
    static bool IsPalindromeInline(string s)
    {
        s = s.ToLower();
        for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            if (s[i] != s[j]) return false;
        return true;
    }
}
