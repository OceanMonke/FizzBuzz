using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            //For loop to do the magic
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz!");
                } else if (i % 5 ==0)
                {
                    Console.WriteLine("Buzz!");
                } 
            }
            // ReadLine added to check if the results are correct and terminate the programme by hand
            Console.ReadLine();

        }
    }
}
