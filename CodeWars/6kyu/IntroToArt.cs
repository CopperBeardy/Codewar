using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class IntroToArt
    {
        public void Solve()
        {

            var result = GetW(3);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();

        }
        
        public string[] GetW(int h)
       {
            if( h <= 2)
            {
                return new string[] { };
            }
            var width = h * 4 - 3;
            string[] stars = new string[h];

            int start = 0;
            int end = width-1 ;
            int centerleft = width / 2 ;
            int centerRight = width / 2 ;


            for (int i = 0; i < h; i++)
            {
                char[] temp = new char[width];

                temp[start] = '*';
                temp[end] = '*';
                temp[centerleft] = '*';
                temp[centerRight] = '*';

                start++;
                end--;
                centerleft--;
                centerRight++;
               
                stars[i] = new string(temp).Replace("\0"," ");


            }


            return stars;
       }
        
    }
}
