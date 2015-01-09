using System;
using System.Numerics;
using System.Diagnostics;

namespace Power_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose an integer");
            string numStr = Console.ReadLine();
            Console.WriteLine("Please choose the power of {0}", numStr);
            string powerStr = Console.ReadLine();

            int num = int.Parse(numStr);
            int power = int.Parse(powerStr);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            double sum = PowerOffx(num,power);
            Console.WriteLine("\nThe sum of all the numbers is {0}", sum);
            sw.Stop();
            Console.WriteLine("\nTime elapsed:\n{0} Seconds\n{1} Milliseconds", sw.Elapsed.Seconds, sw.Elapsed.Milliseconds);
            Console.ReadLine();
        }

        static double PowerOffx(int num, int power)
        {
            int finalSum = 0;

            BigInteger sum = new BigInteger();

            sum = BigInteger.Pow(num, power);

            Console.WriteLine("\n{0} ^ {1} = {2}", num, power, sum);

            char[] sumCharArr = sum.ToString().ToCharArray();

            foreach (char number in sumCharArr)
            {
                int val = (int)Char.GetNumericValue(number);
                finalSum = val + finalSum;
            }

            return finalSum;
        }
    }
}
