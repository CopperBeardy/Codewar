using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class The_Deaf_Rats_of_Hamelin
    {
        public void Solve()
        {
            var str = "~0~0~0~0 P";
            var str2 = "P O~ O~ ~O O~";
            var str3 = "~O~O~O~OP~O~OO~";
            Console.WriteLine( CountDeafRats(str3));
            Console.ReadLine();
        }
        public static int CountDeafRats(string town)
        {
            town = town.Replace(" ",""); 
          
            string[] mice = town.Split('P');
            int count = 0;

            for (int i = 0; i < mice[0].Length -1; i+=2)
                {                    
                    if (!mice[0][i].Equals('~') )
                    {
                        count++;
                    }                 
                }
           
                for (int i = 0; i < mice[1].Length -1;  i +=2)
                {
                    if (mice[1][i].Equals('~'))
                    {
                        count++;
                    }
                }
         

            // Your code here
            return count;
        }
    }
}
