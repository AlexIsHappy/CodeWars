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
            foreach (int i in nbMonths(2000, 8000, 1000, 1.5))
            {
                Console.WriteLine(i);
            }   
            
            // return  int[] r = new int[] { 6, 766 };
            Console.ReadLine();
        }

        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingperMonth, double percentLossByMonth)
        {
            int sum = 0;
            var oldCarPrice = Convert.ToDouble(startPriceOld);
            var newCarPrice = Convert.ToDouble(startPriceNew);
            int countM = 0;

            while (newCarPrice > (sum + oldCarPrice))
            {
                sum += savingperMonth;
                oldCarPrice = oldCarPrice - (oldCarPrice * percentLossByMonth) / 100;
                newCarPrice = newCarPrice - (newCarPrice * percentLossByMonth) / 100;

                if (countM % 2 == 0)
                    percentLossByMonth += 0.5;

                countM++;
            }


            int res = Convert.ToInt16(sum + oldCarPrice - newCarPrice);
            return new int[] { countM, res};
        }
    }
}
