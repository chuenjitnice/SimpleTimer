using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTimer
{
    public class BeepSoundService
    {
        public void PlayCountDownSecond(int hh, int mm, int ss, int second)
        {
            if (hh == 0 && mm == 0 && ss <= second)
            {
                Console.Beep(3000, 20);
            }
        }

        public void PlayHighBeep()
        {
            Console.Beep(5000, 100);
        }
    }
}
