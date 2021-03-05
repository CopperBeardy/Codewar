using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Baby_Magpies
    {
        public void Solve()
        {            

         string m1 = "WWWWBWWBWB";
         string m2 = "BWBWBB";
         string m3 = "BWWBWBBWBW";
         //var result = Child(m1,m2);
            var result2 = Grandchild(m1, m3);

            Console.WriteLine("");

        }
    
  

        public static bool Child(string bird1, string bird2)
        {
            var dif = 0;
            dif = Differneces(bird1, bird2, dif);
            if (dif != 1 || dif != 2)
            {
                return false;
            }
            return true;
        }
        public static bool Grandchild(string bird1, string bird2)
        {
            var dif = 0;
            dif = Differneces(bird1, bird2, dif);

            if (dif >=1 && dif <=3)
            {
                return true;
            }
            return false;
        }

        private static int Differneces(string bird1, string bird2, int dif)
        {
            for (int i = 0; i < bird1.Length; i++)
            {
                if (bird1[i] != bird2[i])
                {
                    dif++;
                }
            }

            return dif;
        }

       

    } 
}
