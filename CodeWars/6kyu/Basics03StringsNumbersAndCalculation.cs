using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._6kyu
{
    public class Basics03StringsNumbersAndCalculation
    {
        public void Solve()
        {
            string input = "fsdfsd235???34.4554s4234df-sdfgf2g3h4j442";
            string result = ParseString(input);
            Console.WriteLine(result);
        }
        string ParseString(string input)
        {
            string symbol = input.First(x =>
            x.Equals('-') ||
            x.Equals('*') ||
            x.Equals('+') ||
            x.Equals('/')
            ).ToString();
            var splitString = input.Split(symbol);

            var first = splitString[0]
                .Where(x => char.IsDigit(x) || x.Equals('.'))
                .Aggregate("", (accumulator, x) => accumulator += x);
            var second = splitString[1]
                .Where(x => char.IsDigit(x) || x.Equals('.'))
                .Aggregate("", (accumulator, x) => accumulator += x);



            var result = symbol switch
            {
                "*" => double.Parse(first) * double.Parse(second),
                "/" => double.Parse(first) / double.Parse(second),
                "-" => double.Parse(first) - double.Parse(second),
                "+" => double.Parse(first) + double.Parse(second)                
            };
            var output = Math.Round(result).ToString();
            return output;
           
        }
    }
}
