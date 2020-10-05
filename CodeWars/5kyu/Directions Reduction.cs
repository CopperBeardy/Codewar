using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars._5kyu
{
    public class Directions_Reduction
    {
        public void Solve()
        {
            string[] a = new string[] { "NORTH", "EAST", "SOUTH",  "WEST" };
            string[] result = dirReduc(a);

        }

        public static string[] dirReduc(string[] a)
        {
           var t = CheckDirections(a.ToList(),0).ToArray();
            return t;
          
        }

        public static List<string> CheckDirections(List<string> directions,int index)
        { 
            bool isBad = true;
            if(directions.Count == index +1)
            {
                return directions;
            }
            isBad = BadDirection(directions[index], directions[index +1]);
            if (isBad)
            {
                directions.RemoveAt(index + 1);
                directions.RemoveAt(index);
                index = 0;
            } else {
                index++;
              
            }


            if(index < directions.Count)  
            { 
                directions = CheckDirections(directions,index);
            }

            return directions;

        }

        public static bool BadDirection(string directionA, string directionB)
        {
            // if north != south
            // if west != east
            var a = directionA.ToUpper();
            var b = directionB.ToUpper();

            switch (a)
            {
                case "NORTH" when b != "SOUTH":
                case "SOUTH" when b != "NORTH":
                case "EAST" when b != "WEST":
                case "WEST" when b != "EAST":
                    return false;
            }
            return true;
        }
    }
}
