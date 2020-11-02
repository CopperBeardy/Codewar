using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CodeWars.CommonCode
{
    public static class PrimeFactorials
    {
        public static List<int> GetPrimeFactorials(int input) 
        {
            List<int> primeFactorials = new List<int>();  
            for (int token = 2 ; token <= input; token++)
            {
                if(input % token == 0)
                {
                    primeFactorials.Add(token);
                }
            }

            return primeFactorials;
        }
    }
}
