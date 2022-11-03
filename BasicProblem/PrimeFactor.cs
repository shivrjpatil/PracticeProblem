using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class PrimeFactor
    {
        public void Factors()
        {
            Console.WriteLine("Enter number to find Prime Factor");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 3; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("Prime Factor of Number" + "" + num + "is:-" + i); ;
                    }
                }
            }
        }

      
    }
}