using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class UC_2Powerof2
    {
        public void Power(int num)
        {
            for(int i= 0; i <=num; i++)
            {
                Console.WriteLine("2^"+i+"="+Math.Pow(2,i));
            }
        }
    }
}
