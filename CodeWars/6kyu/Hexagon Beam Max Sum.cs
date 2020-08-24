using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
    public class Hexagon_Beam_Max_Sum
    {
        internal void Solve()
        {
            var n = 4;
            var seq = new int[] { 1, 0, 4, -6 };
            var result = MaxHexagonBeam(n,seq);
            Console.WriteLine(result);
        }

        public static int MaxHexagonBeam(int n, int[] seq)
        {
            var side = 2 * n - 1;
            List<List<int>> hex = populateHex(n, seq, side);
            int currentMax = CheckHorizontalBeams(hex);
            hex = populateHex(n, seq, side);
            int checkUp = CheckDownLeft( hex,n,side, "");
            if ( checkUp > currentMax) 
            {
                currentMax = checkUp;
            }
             hex = populateHex(n, seq, side);
            int checkDown = CheckDownRight( hex, n, side, "d");
            if (checkDown > currentMax)
            {
                currentMax = checkDown;
            }

            
            return currentMax;
        }
        static int CheckDownRight(List<List<int>> hex, int n, int side, string str)
        {
            throw new NotImplementedException();
        }

        private static int CheckDownLeft( List<List<int>> hex,int n,int side, string v)
        {
            List<List<int>> _hex = hex;
            
            int temp = 0;
            int totalToCountPerLine = n;
            int maxLines = side;
            int currentline = 1;
            int loopStartindex = 0;
            while (currentline < maxLines)
            {

               
                int currCount = 0;
                for (int i =loopStartindex ; i < totalToCountPerLine; i++)
                {
                    var tem = hex[i];
                    currCount += tem[0];
                    tem.Remove(tem[0]);
                    if(tem.Count <= 0)
                    {
                        loopStartindex++;
                    }
                     
                }
                if (currCount > temp) 
                {
                    temp = currCount;
                }

              
                currentline++;
                if(currentline> n)
                {
                    totalToCountPerLine--;
                }else
                {
                    totalToCountPerLine++;
                }

            }


            return temp;
        }

        private static int CheckHorizontalBeams(List<List<int>> hex)
        {
            int temp = 0;
            foreach (var item in hex)
            {
                var arr = item.ToArray();
                var result = arr.Sum();
                if(result > temp)
                {
                    temp = result;
                }
            }
            return temp;
        }

        private static List<List<int>> populateHex(int n, int[] seq, int side)
        {
            List<List<int>> hex = new List<List<int>>();
            // your code goes here
            int seqIndex = 0;
            int max = n;
            for (int i = 0; i < side; i++)
            {

                List<int> temp = new List<int>();
                for (int j = 0; j < max; j++)
                {
                    seqIndex = checkSeq(seq, seqIndex);
                    temp.Add(seq[seqIndex]);
                    seqIndex++;
                }
                hex.Add(temp);
                if (hex.Count >= n)
                {
                    max--;
                }
                else
                {
                    max++;
                }
            }
            return hex;
        }

        private static int checkSeq(int[] seq, int seqIndex)
        {
            if (seqIndex >= seq.Length )
            {
                seqIndex = 0;
            }

            return seqIndex;
        }
    }
}
