using System;
using System.Buffers;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CodeWars._6kyu
{
   public  class Array_Deep_Count
    {
       public void Solve() 
        {
           object[] items = new object[] { "x", "y", new object[] { "z" } };

           int totalItems = DeepCount(items);

           Console.WriteLine(totalItems);
           Console.ReadLine();
        }

       public int DeepCount(object a)
        {
            int count = 0;
            var array = a as object[];
            for(int i = 0; i < array.Length; i++)
            {
                var item = array[i];
                if(item.GetType() == typeof(object[]))
                {
                    count += DeepCount(item);
                }
                count++;
            }
            return count;
        }




         

    }
}
