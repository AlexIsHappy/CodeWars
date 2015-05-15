using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digPow(46288, 3));
            Console.ReadLine();
        }

        public static long digPow(int n, int p)
        {
           int[] numbers = n.ToString().Select(x => Convert.ToInt32(x) - 48).ToArray();
            var result = 0;
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += Pow(numbers[count], p + i);
                count++;
            }

            return result % n == 0 ? result / n : -1; 
        }

        public static int Pow(int num, int p)
        {
            int res = num;

           while (p > 1)
           {
               res *= num;
               p--;
           }
           return res;
        }
    }
}
