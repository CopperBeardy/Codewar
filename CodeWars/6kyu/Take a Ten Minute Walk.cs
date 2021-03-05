using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Take_a_Ten_Minute_Walk
    {
        public void Solve()
        {
            var str = new string[] { "n", "s", "n", "s", "e", "w", "n", "s", "n", "s" };
            Console.WriteLine(IsValidWalk(str));
        }
        public static bool IsValidWalk(string[] walk)
        {
            
            if (walk.Length != 10)
            {
                return false;
            }

            var x = 0;
            var y = 0;
            foreach (var move in walk)
            {
                _ = (move switch
                {
                    "n" => y++,
                    "s" => y--,
                    "e" => x++,
                    "w" => x--
                });
            }

            if(x != 0 || y != 0)
            {
                return false;
            }

            return true;
        }

    }
}
