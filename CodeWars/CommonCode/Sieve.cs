using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.CommonCode
{
    public static class Sieve
    {
        public static List<int> SieveOfEratosthenes(int n )
        {
            List<int> uniquePrimes = new List<int>();
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, 
                // then it is a prime 
                if (prime[p] == true)
                {
                    // Update all multiples of p 
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int i = 2; i <= prime.Length -1; i++)
            {
                if(prime[i] == true)
                {
                    uniquePrimes.Add(i);
                }
            }
            return uniquePrimes;
        }
    }
}
