using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Swap
    {
        public void Number(int a ,int b)
        {
            int c = a;
            a = b;
            b = c;
            
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
