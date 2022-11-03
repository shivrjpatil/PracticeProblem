using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class UC1_LeapYear
    {
        public void check(int year)
        {
            if(year%4==0&& year%100!=0)
            
                Console.WriteLine("Leap year");
                else
                    Console.WriteLine("not a leapyear");
            
        }
    }
}
