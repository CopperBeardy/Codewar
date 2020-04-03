using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._5kyu
{
    public class TheClockworkSpiral
    {
        public void Output()
        {
            int size = 10;
            var result = CreateSpiral(size);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static int[,] CreateSpiral(int N)
        {
            if (N < 1)
            {
                return new int[0,0];
            }

            if (N == 1)
            {
                var tem = new int[1, 1];
                tem.SetValue(1, tem[1,1]);

                return tem;

            }

            // create the grid using a multi-dimension array
            int[,] temp = new int[N,N];
         


            int count = N * N;
            int increment = 1;
            int maxRow = N-1;
            int maxCol = N-1;
            int minRow = 0;
            int minCol = 0;
            int currentRow = minRow;
            int currentCol = minCol;
                    
         
            while(increment <= count)
            {
                //right              
                for(var c =currentCol; c <= maxCol; c++) 
                { 
                    if(increment > count)
                    {
                        break;
                    }
                    temp.SetValue(increment,currentRow, currentCol );
                
                    increment++;
                   
                
                if (currentCol == maxCol)
                    {
                        currentRow++;
                        minRow++;
                        break;
                    } 
                    currentCol++;
                }
                
             //down
                for (int r = currentRow; r <= maxRow; r++)
                {
                    if (increment > count)
                    {
                        break;
                    }
                    temp.SetValue(increment, currentRow, currentCol);
                 

                    increment++;
                   
                    if (currentRow == maxRow )
                    {
                        currentCol--;
                        maxCol--;
                        break;
                    }
                    currentRow++;
                }



                //left
                for (int c = currentCol; c >= minCol; c--)
                {  
                    if (increment > count)
                    {
                        break;
                    }
                    temp.SetValue(increment, currentRow, currentCol);
                 

                    increment++;
                  
                    if (currentCol == minCol)
                    {
                        currentRow--;
                        maxRow--;
                        break;
                    } 
                    currentCol--;
                }

                //up
                for (int r = currentRow; r >= minRow; r--)
                {
                    if (increment > count)
                    {
                        break;
                    }
                    temp.SetValue(increment, currentRow, currentCol);
                
                    increment++;
                    
                    if (currentRow == minRow)
                    {
                        currentCol++;
                        minCol++;
                        break;

                    } 
                    currentRow--;
                }


               
            }

          
            return temp;
        }
    }
}
