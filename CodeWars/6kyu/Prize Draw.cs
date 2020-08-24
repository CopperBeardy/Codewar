using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace CodeWars._6kyu
{
    public class Prize_Draw
    {
        public void Solve()
        {
            //string names = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            //int[] weights = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            //int rank = 4;
            //string names = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            //int[] weights = new int[] { 4, 2, 1, 4, 3, 1, 2 };
            //int rank = 4;
            string names = "Elijah,Chloe,Elizabeth,Matthew,Natalie,Jayden";
            int[] weights = new int[] { 1, 3, 5, 5, 3, 6 };
            var rank = 2;
            //string names = "COLIN,AMANDBA,AMANDAB,CAROL,PauL,JOSEPH";
            //int[] weights = new int[] { 1, 4, 4, 5, 2, 1 };
            //var rank = 4;
            //string names = "Chloe,Abigail,Emma";
            //int[] weights = new int[] { 2,3,2 };
            //var rank = 1;
            var anwser = PrizeDraw(names, weights, rank);
            Console.WriteLine(anwser);
        }

        private string PrizeDraw(string names, int[] weights, int rank)
        {
            Console.WriteLine(names);
            var output = "";
            foreach (var item in weights)
            {
                output += item + ",";
            }
            Console.WriteLine(output);
            if (names.Length == 0)
            {
                return "No participants";
            }
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray().ToList();
            string[] tempNames = names.Split(',');
            if(rank >= tempNames.Length) 
            {
                return "Not enough participants";
            }
            List<(string name, int number)> winningnumbers = new List<(string name, int number)>();
            for (int i = 0; i < tempNames.Length; i++)
            {
                var count = 0;
                var name = tempNames[i];
                for (int j = 0; j < name.Length; j++)
                {
                    var tempname = names.ToLower();
                    count += alphabet.IndexOf(tempname[j]) ;
                }
                count += name.Length;
                count = count * weights[i];
                winningnumbers.Add((name, count));
            }
            List<(string name, int number)> result = winningnumbers.OrderByDescending(x => x.number).ThenBy(y => y.name).ToList();

           

            return result[rank  ].name ;
        }

    }
    
    
}
