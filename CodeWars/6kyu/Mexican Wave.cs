using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class Mexican_Wave
    {
        public  void Solve()
        {
            var input = " gap ";
            List<string> result = wave(input);

            if(result.Count == 0)
            {
                
            }
            string output = "";
        }
        List<string> wave(string input)
        {
            List<string> wavedWords = new List<string>();
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            
            var upperChars= input.ToUpper().ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                
                char[] temp = input.ToArray();
                if (temp[i].Equals(' '))
                { continue; }    
                temp[i] = upperChars[i];
                var output = "";
                foreach (var item in temp)
                {
                    output += item.ToString();
                }
                wavedWords.Add(output);
               
            }
            return wavedWords;


        }
    }
}
