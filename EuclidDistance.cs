using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class EuclidDistance
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter x value:");//read input for x
            string input1 = Console.ReadLine();
            int x = Convert.ToInt32(input1);  //converting the string to integer
            Console.WriteLine("Enter y value");//read input for y
            string input2 = Console.ReadLine();
            int y = Convert.ToInt32(input2);
            Distance(x, y); //calling the method

        }
        private void Distance(int x,int y)
        {
            double distance = Math.Sqrt(x * x + y * y);//distance formula
            Console.WriteLine(distance);
        }
    }
}
