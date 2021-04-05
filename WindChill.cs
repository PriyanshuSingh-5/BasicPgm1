using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class WindChill
    {
        public void ReadInput()
        {
            Console.WriteLine(" Enter temperature (in Fahrenheit) value :");
            string input1 = Console.ReadLine();
            double t = Convert.ToInt32(input1);
            Console.WriteLine("Enter v (in miles per hour), value: ");
            string input2 = Console.ReadLine();
            double v = Convert.ToInt32(input2);
            WindChillProblem(t, v);
        }
        private void WindChillProblem(double t, double v)
        {
            if (t < 50)
            {
                if (v < 120)
                {
                    if (v > 3)
                    {
                        double WindChillProblem = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                        Console.WriteLine(WindChillProblem);
                    }
                    else
                    {
                        Console.WriteLine(" v velocity less than 3");
                    }
                }
                else
                {
                    Console.WriteLine(" v velocity larger than 120");
                }
            }
            else
            {
                Console.WriteLine(" t (in Fahrenheit) larger than 50");
            }
        }
    }
}

