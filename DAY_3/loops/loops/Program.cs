using System;

class Program
{
    static void Main()
    {
        #region 1. Series 1 to 20
        Console.WriteLine("1. Series 1 2 3 4 5 6 7 8 ... 20");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        #endregion

        #region 2. Odd series 1 to 19
        Console.WriteLine("2. Odd series: 1 3 5 7 9 ... 19");
        for (int i = 1; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        #endregion

        #region 3. Even series 0 to 20
        Console.WriteLine("3. Even series: 0 2 4 6 8 ... 20");
        for (int i = 0; i <= 20; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        #endregion

        #region 4. 5 series 0 to 25
        Console.WriteLine("4. 5 series: 0 5 10 15 20 25");
        for (int i = 0; i <= 25; i += 5)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        #endregion

        #region 5. Sum 1+2+3+...+20
        Console.WriteLine("5. Sum 1+2+3+...+20");
        int sum5 = 0;
        for (int i = 1; i <= 20; i++)
        {
            sum5 += i;
            Console.Write(i + (i < 20 ? " + " : " = "));
        }
        Console.WriteLine(sum5);
        #endregion

        #region 6. Sum even 0+2+4+...+20
        Console.WriteLine("6. Sum 0+2+4+...+20");
        int sum6 = 0;
        for (int i = 0; i <= 20; i += 2)
        {
            sum6 += i;
            Console.Write(i + (i < 20 ? " + " : " = "));
        }
        Console.WriteLine(sum6);
        #endregion

        #region 7. Sum odd 1+3+5+...+19
        Console.WriteLine("7. Sum 1+3+5+...+19");
        int sum7 = 0;
        for (int i = 1; i <= 19; i += 2)
        {
            sum7 += i;
            Console.Write(i + (i < 19 ? " + " : " = "));
        }
        Console.WriteLine(sum7);
        #endregion

        #region 8. Sum 0+5+10+...+25
        Console.WriteLine("8. Sum 0+5+10+...+25");
        int sum8 = 0;
        for (int i = 0; i <= 25; i += 5)
        {
            sum8 += i;
            Console.Write(i + (i < 25 ? " + " : " = "));
        }
        Console.WriteLine(sum8);
        #endregion

        #region 9. Series 1/1! + 2/2! + 3/3! + ... (10 terms)
        Console.WriteLine("9. Series 1/1! + 2/2! + 3/3! + ...");
        double sum9 = 0;
        double fact = 1;
        for (int i = 1; i <= 10; i++)
        {
            fact *= i;
            double term = (double)i / fact;
            sum9 += term;
            Console.Write("{0}/{1}! + ", i, i);
        }
        Console.WriteLine("= {0:F6}", sum9);
        #endregion

        #region 10. Series 0 + 2/2! + 4/4! + 6/6! + ...
        Console.WriteLine("10. Series 0 + 2/2! + 4/4! + 6/6! + ...");
        double sum10 = 0;
        fact = 1;
        for (int i = 0; i <= 10; i += 2)
        {
            if (i > 0)
            {
                fact *= i * (i - 1);
                double term = (double)i / fact;
                sum10 += term;
                Console.Write("{0}/{1}! + ", i, i);
            }
            else
            {
                Console.Write("0 + ");
            }
        }
        Console.WriteLine("= {0:F6}", sum10);
        #endregion

        #region 11. Series 1/1! + 3/3! + 5/5! + ...
        Console.WriteLine("11. Series 1/1! + 3/3! + 5/5! + ...");
        double sum11 = 0;
        fact = 1;
        for (int i = 1; i <= 19; i += 2)
        {
            fact *= i * (i - 1);
            double term = (double)i / fact;
            sum11 += term;
            Console.Write("{0}/{1}! + ", i, i);
        }
        Console.WriteLine("= {0:F6}", sum11);
        #endregion

      
    }
}
