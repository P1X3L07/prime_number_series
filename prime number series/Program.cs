using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime: ");
            int Prime = Convert.ToInt32(Console.ReadLine());

            if(Prime > 0 && Prime % 2 == 1)
            {
                Console.WriteLine("It is a prime num");
            }
            else
            {
                Console.WriteLine("Not a prime num");
            }

            Console.ReadLine();
        }
    }
}
