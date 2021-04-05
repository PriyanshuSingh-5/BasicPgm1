using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class Power
    {
        public static void PowerOfTwo()
        {
            int number, power;
            int result = 1;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the powerr");
            power = Convert.ToInt32(Console.ReadLine());

            while (power != 0)
            {
                result *= number;
                --power;
            }
            Console.WriteLine("Answer is :" + result);
            Console.ReadKey();
        }
    }
}
