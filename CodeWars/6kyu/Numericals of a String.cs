using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
   public  class Numericals_of_a_String
    {
      //LOGIC WORKS FINE HOWEVER IT IS CURRENT TO SLOW PROCESSING 
        // TO PASS THE CHALLENGE TESTS
      
      
        //1 1 1 2 1 1 1 1 2 1 3 1 1 2 1 1 1 1 3 1 2 2 4 1 3 2 4 1 2 2 3 2
        //1 1 1 2 1 1 1 1 2 1 3 1 1 2 1 1 1 1 3 1 2 2 4 1 3 2 4 1 1 1 2 2
        //H e l l o ,   W o r l d !   I t ' s   m e ,   J o m o P i p i !
        /// <summary>
        /// For each symbol in the string if it's the first character occurrence, replace it with a '1',
        /// else replace it with the amount of times you've already seen it...
        /// 
        /// Formated tested challenge
        /// </summary>
        public void Solve() 
        {
            //should return result  =  "1112111121311"
            string result = Numericals("Hello, World!");

            // should return result = "123456789101112"
           // string result = Numericals("aaaaaaaaaaaa");

            Console.WriteLine(result);
            Console.ReadLine();
        }
        public string Numericals(string s)
        {
            //this solution is by https://www.codewars.com/users/jymmiCoder
            //this works but is still not super fast.

            var times = new int[67000];
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                times[c]++;
                sb.Append(times[c].ToString());
            }
            return sb.ToString();


            //string numberString = "";

            //var take = 1;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    numberString += s.Take(take)
            //        .Where(c => c == s[i])
            //        .Count();
            //    take++;
            //}
            //return numberString;
        }
    }
}
