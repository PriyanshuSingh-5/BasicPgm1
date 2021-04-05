using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class Gambler
    {
        public static void ReadStakeAmountAndGoal()
        {
            int wons = 0; //initialize values for win loose
            int loose = 0;
            Console.WriteLine("Enter Stake amount");
            int amount = Convert.ToInt32(Console.ReadLine());// converting to string
            Console.WriteLine("Enter Goal amount");
            int goal = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();

            for(int i=1;i>0;i++)
            {
                if(amount>0) //checking amount value
                {
                    int randomValue = random.Next(0, 2); //use of random and next to print 3 values
                    //Console.WriteLine(Generated random value"+randomValue);
                    if(randomValue ==1)
                    {
                        amount = amount + 1;
                        wons++;

                        if(amount == goal)  //comparing amount and goal
                        {
                            Console.WriteLine("number of bets played in the game" +i);
                            Console.WriteLine("number of wons" + wons);
                            Console.WriteLine("number of loose" + loose);
                            break;
                        }
                    }
                    else
                    {
                        amount = amount - 1;
                        loose++;

                    }
                }
                else
                {
                    Console.WriteLine("Game broken that means amount is not sufficient");
                    break;
                }
            }
            Console.WriteLine("final amount either it may reaches to goal or broke the game" + amount);
        }


    }
}
