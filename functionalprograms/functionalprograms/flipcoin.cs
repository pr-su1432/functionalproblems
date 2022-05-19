using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalprograms
{
    internal class flipcoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's flip a coin 50 times");
            Coinflip();
        }

        private static int Coinflip()
        {
            Random Rand = new Random();
            int heads = 0;
            int tails = 0;
            int headspercentage = 0;
            int tailspercentage = 0;
            int result = 0;


            for (int i = 0; i < 50; i++)
            {
                result = Rand.Next(0, 2);
                headspercentage = heads / 5;
                tailspercentage = 50 - headspercentage;

                if (result == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }

            }
            Console.WriteLine("heads was flipped {0} times", heads);
            Console.WriteLine("tails was flipped  {0} times", tails);
            Console.WriteLine("Heads Percentage : " + (headspercentage));
            Console.WriteLine("Tails Percentage :" + (tailspercentage));
            return result;
        }
    }
}
