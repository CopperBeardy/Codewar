using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._6kyu
{
    public class Count_the_smiley_faces
    {
        public void Solve()
        {
            /** 
             * valid - :) :D ;-D :~)
             **/


           // var input = new string[] { ":D", ":~)", ";~D", ":)" };
           // var input = new string[] { ":)", ":(", ":D", ":O", ":;" };
            //  var input =new string[] { ";]", ":[", ";*", ":$", ";-D" };
             var input =  new string[] { ";", ")", ";*", ":$", "8-D" };

            var result = CountSmileys(input);
            Console.WriteLine(result);

        }

        public static int CountSmileys(string[] smileys)
        {          
            var regexPattern = new Regex(@"[:;][-~]*[)D]");
            return smileys.Count(pattern => regexPattern.IsMatch(pattern));
        }

    }
}
