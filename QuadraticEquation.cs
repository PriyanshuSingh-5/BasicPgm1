using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class QuadraticEquation
        {
            public static void RootsOfEquation()
            {
                //quadratic equation problem
                Console.WriteLine("Enter the Value of a:");
                int a = Convert.ToInt32(Console.ReadLine());//conversion to integer
                Console.WriteLine("Enter the Value of b:");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Value of c:");
                int c = Convert.ToInt32(Console.ReadLine());
                double delta = b * b - (4 * a * c);    //calculation of first part
                double sqr = Math.Sqrt(delta);  //storing the result
                double root1 = (-b + sqr) / (2 * a); //calculation of the root value
                double root2 = (-b - sqr) / (2 * a); //calculation of the root value

                Console.WriteLine("The value of root1 " + root1);
                Console.WriteLine("The value of root2 " + root2);

            }
        }
    }


