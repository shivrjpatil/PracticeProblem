using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Division
    {
        public void Div(int a,int b)
        {
            int Quotient = a / b;
            int Rem = a % b;
            Console.WriteLine("the quoetient and remiander is :" + Quotient,+ Rem);
            Console.WriteLine( Rem);    
        }
    }
} 
