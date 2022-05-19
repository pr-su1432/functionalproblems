using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalprograms
{
    internal class poweroftwo
    {
        public void powerOfTwo()
        {
            int twosPower = 1;
            Console.WriteLine("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n < 31)
            {
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(i + " to the power of 2:" + twosPower);
                    twosPower = twosPower * 2;
                }
            }
            else
                Console.WriteLine("Enter N's value below 31");
        }
    }
}
