using System;
using System.Linq;

namespace CodeWars._6kyu
{
    public class Does_my_number_look_big_in_this
    {
        public void Solve()
        {
            int input = 153;
            bool result = IsNarcissisticNumber(input);

            Console.WriteLine(result);

        }
        public bool IsNarcissisticNumber(int value)
        {
            bool result = false;
            //get the  number of digits in input
            int numberLength = value.ToString().Length;

            //convert input into single digit number array
            int[] values = value.ToString().Select(n => int.Parse(new string(n, 1))).ToArray();

            int count = values.Aggregate(0, (accumulator, v) => accumulator +=
            (int)Math.Pow(v * 1.0, numberLength * 1.0));

            result = count == value;

            return result;
        }
    }
}
