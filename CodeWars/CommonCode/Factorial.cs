using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars.CommonCode
{
    public static class Factorial
    {
        public static int GetFactorial(int n)=>
            (n == 1 || n == 0) ? 1 : n * GetFactorial(n - 1);        
    }
}
