using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Financing_Plan_on_Planet_XY140Z_n
    {

        public void Solve()
        {
            var result = finance(7);
            Console.WriteLine($"total saving = {result}");
            Console.ReadLine();
        }


        // n+1 sum of multiples
        public static ulong finance(ulong n)
        {
            ulong sum = 0;
            for (ulong i = 0; i < n+1; i++)
            {
                sum += (i + 1) * n;
            }
            return sum;
        }
    }
}
