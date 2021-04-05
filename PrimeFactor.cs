using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class PrimeFactor
    {
        public static void ReadInputs()
        {
            Console.WriteLine("Enter number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine()); //convertion to integer
            int divisors = 0;
            for (int i = 1; i <= number; i++) 
            {
                if (number % i == 0)  //checking the divisibility 
                {
                    divisors++;
                }
            }
            if (divisors == 2)   
            {
                Console.WriteLine("The entered number is a prime number");
            }
            else
            {
                Console.WriteLine("The entered number is not a Prime Number");
            }
            Console.ReadLine();

        }
    }
}
    
 


