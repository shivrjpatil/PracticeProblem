using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class EvenOdd
    {
        public void check(double a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
                Console.WriteLine("the number is odd");
        }
    }
}
