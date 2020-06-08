using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CodeWars._6kyu
{
    public class Buying_a_car
    {
        public void Solve() 
        {
            var result = nbMonths(8000, 12000, 500, 1);
            Console.WriteLine($"The number of months is {result[0]}, with {result[1]}");
            Console.ReadLine();
        }
        public static int[] nbMonths(int startPriceOld, int startPriceNew,
            int savingPerMonth, double percentLossByMonth)
        {
            Console.WriteLine($"{startPriceOld}, {startPriceNew}, { savingPerMonth},{  percentLossByMonth}");
            double currentOldPrice = startPriceOld;
            double currentNewPrice = startPriceNew;
            double monthlySavings = savingPerMonth;

            int[] returns = new int[2];
            if(currentOldPrice >=currentNewPrice)
            {
                returns[0] = 0;
                returns[1] = (int)Math.Round(currentOldPrice -currentNewPrice  );
                return returns;
            }

            int month = 1;

            while(true)
            {
                
                   
                if(month % 2 == 0)
                {
                    percentLossByMonth += 0.5;
                }
                currentOldPrice -= currentOldPrice * (percentLossByMonth /100);
                currentNewPrice -= currentNewPrice * (percentLossByMonth /100);

                if(currentOldPrice + monthlySavings >= currentNewPrice)
                {
                    returns[0] = month;
                    returns[1] = (int)Math.Round( currentOldPrice + monthlySavings - currentNewPrice  );
                    return returns;
                }
              
                    monthlySavings += savingPerMonth;
              
                    month++; 


            }                
        }
    }
}
