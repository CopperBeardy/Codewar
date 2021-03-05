using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            string temp = str;
            if (str.Length % 2 != 0)
            {
                str += "_";
            }

            string[] result = new string[str.Length / 2];
            for (int i = 0, j=0; i < str.Length ; i+=2 ,j++)
            {
                result[j] = str.Substring(i, 2);
            }
            return result;
        }

        string[] solution = Solution("abcde");

        public void output()
        {
            foreach(var item in solution)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
