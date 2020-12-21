using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    class Playing_With_Toy_Blocks
    {
        public void Solve()
        {
            var result = BuildSquare(new int[]{ 4, 3, 2, 1, 3, 1, 1, 2, 3, 1, 1});
            Console.WriteLine(result); 
        }
        public static bool BuildSquare(int[] blocks)
        {
            int[] counts = new int[] {
                blocks.Count(e => e == 1),
                blocks.Count(e => e == 2),
                blocks.Count(e => e == 3),
                blocks.Count(e => e == 4)
                };

          
            int  wholeblocks = counts[3];
            if(wholeblocks < 4)
            {
               while(counts[2] > 0 && counts[0] > 0)
                {
                    wholeblocks++;
                    counts[2]--;
                    counts[0]--;
                }
               while(counts[1] >= 2)
                {
                    wholeblocks++;
                    counts[1] -= 2;

                }
               if(counts[1] == 1 && counts[0]>= 2)
                {
                    wholeblocks++;
                    counts[1] = 0;
                    counts[0] -= 2;
                }
               while(counts[0] >= 4)
                {
                    wholeblocks++;
                    counts[0] -= 4;
                }
            }
            if(wholeblocks >= 4)
            {
                return true;
            }
            return false;
        }
    }
}
