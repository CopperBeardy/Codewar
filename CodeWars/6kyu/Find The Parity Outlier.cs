using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace CodeWars._6kyu
{
    public class Find_The_Parity_Outlier
    {
        public void Solve()
        {

           

            int[] sample = new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 };
            int[] sample2 = new int[] { 160, 3, 1719, 19, 11, 13, -21};
            Console.WriteLine(Find(sample));
            Console.WriteLine(Find(sample2));
        }

        public static int Find(int[] integers)
        {
            var result = DecideOnType(integers);

            return FindOutlier(integers, result);
        }

        static int FindOutlier(int[] integers, type result)
        {
            for (int i = 0; i < integers.Length; i++)
            {
                switch (result)
                {
                    case type.even:
                        if (integers[i] % 2 != 0)
                            return integers[i];
                        break;
                    case type.odd:
                        if (integers[i] == 0 || integers[i] % 2 == 0)
                        {
                            return integers[i];
                        }

                        break;
                }
            }
            return 0;
        }
        public static type DecideOnType(int[] integers) 
        {
            int countOdd = 0;
            int countEven = 0;

            for (int i = 0; i < 4; i++)
            {
                if ( integers[i] % 2 == 0)
                {
                    countEven++;
                }
                else 
                {
                    countOdd++;
                }
            }
            if (countEven > countOdd)
            {
                return type.even;
            }
            return type.odd;
            

        }


    }

    public enum type
    {
        odd,
        even
    }

}
