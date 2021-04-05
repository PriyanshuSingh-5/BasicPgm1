using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicpgm
{
    class Coupons
    {
        public static void ReadNumOfCoupons()
        {
            Console.WriteLine("Enter a number for Distinct Coupons");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            FindOutRandomCount(couponNo);
        }
        private static void FindOutRandomCount(int couponNo)
        {
            int distinct = 0,count = 0;
            bool[] isCollected = new bool[couponNo];//use of boolean for true or false statement
            while(distinct<couponNo)
            {
                Random random = new Random();
                int newRandom = Convert.ToInt32(random.Next(0, couponNo));//use of random number to find coupon
                count++;
                if(!isCollected[newRandom])  
                {
                    distinct++;
                    isCollected[newRandom] = true;
                }
            }
            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);
        }
    }
}
