using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public static class is_my_friend_Cheating
    {
        public static List<long[]> removNb(long n)
        {
            long summed = (n * (n + 1)) / 2;

            var values = new List<long[]>();

            for (long b = n - 1; b > 1; b--)
            {
                long a = (summed - b) / (b + 1);

                if (a < n && a * b == summed - (a + b))
                {
                    values.Add(new long[] { a, b });
                }
            }
            return values;
        }

    }
}
