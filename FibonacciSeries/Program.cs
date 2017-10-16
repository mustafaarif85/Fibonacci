using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> series = new List<int>();
            int number = 1 , item=0 ;
            int limit = 4000000;
            int evenSum = 0;        


            while (number <= limit)
            {
                number = (item > 1 ? 0 : number) + (item == 0 ? 0 : series[item - 1]);
                if (item > 1) { number = number + series[item - 2]; }
                if (number < limit)
                {
                    series.Add(number);
                    Console.Write(number.ToString() + ",  ");
                    if (number % 2 == 0)
                    { evenSum = evenSum + number; }                   
                    item++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(string.Format("Sum of even terms in the Fibonacci Series is : {0}",evenSum));
            Console.ReadKey();
        }       
    }
}
