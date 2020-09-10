using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._6kyu
{
    /**
     * Assume "#" is like a backspace in string. 
     * This means that string "a#bc#d" actually is "bd"
     * 
     * Your task is to process a string with "#" symbols.
     * 
     * "abc#d##c"      ==>  "ac"
     * "abc##d######"  ==>  ""
     * "#######"       ==>  ""
     * ""              ==>  ""
     * 
     * */
    public class Backspaces_in_string
    {
        internal void Solve()
        {
            string input = "abc#d##c";
            // string result = "abc####d##c#"
            var output = ParseString(input);

            Console.WriteLine(output);
        }
        
        public string ParseString(string input)
        {
           StringBuilder outputString = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                char comparisonChar = input[i];
                //    outputString.Append(input[i]);
                if (comparisonChar != '#')
                {
                    outputString.Append(comparisonChar);
                }
                else if(outputString.Length > 0)
                {
                    //TODO: check for the length of the output string.
                    outputString.Remove(outputString.Length-1, 1);
                  
                }
                
            }
 return outputString.ToString();
        }
    }
}
