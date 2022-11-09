using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Vowel
    {
        public void Conso()
        {
            char alpha;
            Console.WriteLine("enter the alphabet:");
            alpha = Convert.ToChar(Console.ReadLine().ToLower());
            switch(alpha)
            {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break ;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("consonant");
                    break;
            }
        }
    }
}
