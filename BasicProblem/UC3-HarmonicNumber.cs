using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class UC3_HarmonicNumber
    {
        public void Harmonic(int num)
        {
            int result = 0;
            for(int i = 1; i <=num; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine(result);
        }
    }
}
