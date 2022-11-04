using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Stopwatch
    {
        TimeSpan timeSpan = TimeSpan.Zero;
        public void Start()
        {
            int startHr = timeSpan.Hours;
            int startMin = timeSpan.Minutes;
            int startSec = timeSpan.Seconds;
            int startMilliSec = timeSpan.Milliseconds;
            Console.WriteLine("press s to start");
            string data = Console.ReadLine().ToLower();
            if (data.Equals("s"))
            {
                Console.WriteLine(startMilliSec);
                Console.WriteLine("press x foe exit");
                string stop = Console.ReadLine().ToLower();
                if (data.Equals("x"))
                {
                    DateTime dateTime1 = DateTime.Now;
                    Console.WriteLine(dateTime1.Millisecond);
                    int stopHr = timeSpan.Hours;
                    int stopMin = timeSpan.Minutes;
                    int stopSec = timeSpan.Seconds;
                    int stopMilliSec = timeSpan.Milliseconds;
                    Console.WriteLine("stopwatch details: Hours: " + (stopHr - startHr) + "minutes" + (stopMin - startMin) + "seconds" + (stopSec - startSec) + "milliseconds" + (stopMilliSec - startMilliSec));
                }
            }

        }
    }
}