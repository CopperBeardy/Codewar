using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars._6kyu
{
    public class Playing_with_digits
    {
        public void Solve()
        {
            var result = digPow(89 ,1);
            Console.WriteLine(result);
        }

        public static long digPow(int n, int p)
        {
          
            List<long> numberSplit = n.ToString()
                .ToCharArray()
                .Select(x => long.Parse(x.ToString()))
                .ToList();

            double count = 0;         
            foreach (long number in numberSplit)
            {
                count += Math.Pow(number, p);
                p++;
            }

            return count >= n && count % n== 0 ?
                long.Parse(Math.Round(count /n).ToString()) : -1;
        }

    }
}
