using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._6kyu
{
    public class New_Cashier_Does_Not_Know_About_Space_or_Shift
    {
        List<string> menu = new List<string>() {

            "Burger",
                "Fries",
                "Chicken",
                "Pizza",
                "Sandwich",
                "Onionrings",
                "Milkshake",
                "Coke"
        };
        
        public void Solve()
        {            
            string input = "milkshakepizzachickenfriescokeburgerpizzasandwichmilkshakepizza";
            Console.WriteLine(SplitInput(input).Trim());
        }

        public string SplitInput(string input)
        {
            string output = "";
            foreach (var item in menu)
            {
                var temp = Regex.Matches(input, item.ToLower()).Count();
               
                    for (int i = 0; i < temp; i++)
                    { 
                        output += item + " ";
                    }                  
               
            }
            return output;

        } 
       

    }
}
