using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    class Matrix_Addition
    {
        internal void Solve()
        {
            var result = MatrixAddition(
                new int[][] 
                {
                    new int[] {1, 2},
                    new int[] {1, 2}
                },
                new int[][]
                {
                    new int[] {2, 3},
                    new int[] {2, 3}
                }
                ); 
        }

        public static int[][] MatrixAddition(int[][] a, int[][] b)
        {
            int[][] output = new int[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                var t = a[i];
                var x = b[i];
                var temp = new int[t.Length];
                for (int j = 0; j < t.Length; j++)
                {
                    temp[j] = t[j] + x[j];
                }
                output[i] = temp;
            }

            return output;


        }

    }
}
