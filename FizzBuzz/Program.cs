using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        /* 
         * Write a program that prints the numbers from 1 to 100. 
         * But for multiples of three print “Fizz” instead of the number 
         * and for the multiples of five print “Buzz”. 
         * For numbers which are multiples of both three and five print “FizzBuzz”." 
        */

        static void Main(string[] args)
        {
            for (int ndx = 1; ndx <= 100; ndx++)
            {
                var fizz = ndx % 3 == 0;
                var buzz = ndx % 5 == 0;

                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if(fizz) 
                    Console.WriteLine("Fizz");
                else if(buzz)
                    Console.WriteLine("Buzz");
                else
                   Console.WriteLine(ndx); 
            }

            Console.WriteLine("Done! Press <Enter> to exit.");
            Console.ReadLine();
        }
    }
}
