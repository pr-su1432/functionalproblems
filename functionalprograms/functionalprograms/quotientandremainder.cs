using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functionalprograms
{
    public class quotientandremainder
    {
        public static void Main()
        {
            int dividend = 30;
            int divisor = 7;
            int remainder;
            int quotient = Math.DivRem(dividend, divisor, out remainder);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
