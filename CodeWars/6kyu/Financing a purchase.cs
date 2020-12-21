using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars._6kyu
{
    public class Financing_a_purchase
    {

        // Solved with the using smabuk solution as guide https://github.com/smabuk/Kata/blob/master/CodingWars/FinancingAPurchase.cs

        public void Solve()
        {
            var result = Amort(7.4, 10215, 24, 20);
        }


        public static string Amort(double rate, int bal, int term, int num_payments)
        { 
            
           
  double b = bal;
            double r = rate / (100 * 12); 
            double n = r * b;
            double d = 1 - Math.Pow((1 + r), -term);
            double c =  n / d;
           
          
            double princ = 0.0;

            for (int i = 0; i < num_payments; i++)
            {

                n = r * b;
                princ = c - n;            
               
                b -=  princ ;
            }
           
                string output = $"num_payments {num_payments} c {c:0} princ {princ:0} int {n:0}, bal {b:0},";

            return output;
        }
    }
}
