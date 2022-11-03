using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class TempratureConversion
    {
        public void Celsius(double deg)
        {
            double Farenhit = (deg * (9 / 5) + 32);
                Console.WriteLine(Farenhit);
        }
        public void Farenhit(double deg)
        {
            double Celsius = (deg - 32) * 5 / 9;
            Console.WriteLine(Celsius);
        }

    }
}
