using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lletres_repetides
{
    class milestone3
    {
        public static void tictac()
        {
            int hour = 0;
            int minutes = 0;
            int seconds = 0;

            bool finalizar = false;
            Console.Clear();
            while (!finalizar)
            {
                if (hour <= 9)
                {
                    Console.Write("0");
                }
                Console.Write(hour + ":");
                if (minutes <= 9)
                {
                    Console.Write("0");
                }
                Console.Write(minutes + ":");
                if (seconds <= 9)
                {
                    Console.Write("0");
                }
                Console.Write(seconds);
                if (seconds == 59)
                {
                    minutes++;
                    seconds = -1;
                }
                if (minutes == 60)
                {
                    hour++;
                    minutes = 0;
                }
                if (hour == 24)
                {
                    hour = 0;
                }

                Thread.Sleep(1000);
                seconds++;
                Console.Clear();
            }
        }

    }
}
