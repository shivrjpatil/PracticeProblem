using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Monthlypayment
    {
        public void pay()
        {
            Console.WriteLine("enter the principle amount:");
            double P=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year:");
            double Y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the intrest:");
            double R=Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);

            double a = (1 + r);
            double b = (-n);

            double payment = (P * r) / 1 - Math.Pow(a,b);
            Console.WriteLine(payment);


        }
    }
}
