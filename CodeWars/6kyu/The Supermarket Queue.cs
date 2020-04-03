using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._6kyu
{
   public  class The_Supermarket_Queue
    {
        /// <summary>
        /// There is a queue for the self-checkout tills at the supermarket. Your task is write a function
        /// to calculate the total time required for all the customers to check out!
        /// 
        /// input
        ///     customers: an array of positive integers representing the queue.Each integer represents a customer,
        ///     and its value is the amount of time they require to check out.
        ///     n: a positive integer, the number of checkout tills.
        /// output
        ///    The function should return an integer, the total time required.        ///    
        /// 
        /// Clarifications
        /// There is only ONE queue serving many tills, and
        /// The order of the queue NEVER changes, and
        /// The front person in the queue(i.e.the first element in the array/list) proceeds to a till as soon as it becomes free.
        /// </summary>
        public void Solve()
        {
          //should return 12
          //var result = QueueTime(new int[] {5,3,4 },1);

            //should return 10  
             //var result = QueueTime(new int[] { 10, 2, 3, 3 }, 2)  ;   

            //should return 12  
             var result = QueueTime(new int[] { 2,3,10 }, 2)  ; 

            Console.WriteLine(result);
            Console.ReadLine();
        }
       
        public long QueueTime(int[] customers, int n)
        {
            if(n == 1)
            {
                return customers.Sum();
            } 
            
            long[] tillTime = new long[n];

            long currentCustomer = 0;
            while (currentCustomer < customers.Length)
            {
                tillTime[0] += customers[currentCustomer];
                Array.Sort(tillTime);
                currentCustomer++;
            }
            Array.Sort(tillTime);
            var result = tillTime.Last();           


            return result;
        }
    }
}
