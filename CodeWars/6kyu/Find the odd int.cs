using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Find_the_odd_int
    {
        public void Solve()
        {
            int[] nums = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            var result = find_it(nums);

            Console.WriteLine($"the odd int is {result}" );
            Console.ReadLine();

        }
        public static int find_it(int[] seq)
        {
            Array.Sort(seq);
            for (int i = 0; i < seq.Length; i++)
            {
                var number = seq[i];
                var count = 0;
                for (int j = 0; j < seq.Length; j++)
                {
                    if(seq[j] == number)
                    {
                        count++;
                    }

                }

                if(count % 2 != 0)
                    return number;  

            }


            return 0;
        }

    }

}
