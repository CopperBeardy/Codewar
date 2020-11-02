using System;
using System.Collections.Generic;
using System.Text;
using CodeWars.CommonCode;
namespace CodeWars._5kyu
{
    public class Factorial_decomposition
    {
        public void Solve()
        {
            var result = Decompositions(22);          
                

          
        }

        public string Decompositions(int n)
        {
            string result = "";
            var factorial = Factorial.GetFactorial(n);
            var primes = Sieve.SieveOfEratosthenes(n);

            foreach (int prime in primes)
            {
                var temp = exponentFactor(n, prime);

              
                if (temp > 1)
                {
                    result += $"* {prime}^{temp} ";
                }
                else
                {
                    result += $"* {prime} ";
                }
                
            }
           
            return  result.Remove(0, 1).Trim();
        }


       static int exponentFactor(int n, int p)
        {
            int x = p;
            int exponent = 0;
            while ((n / x) > 0)
            {
                exponent += n / x;
                x *= p;
            }
            return exponent;
        }

    
    }
}
