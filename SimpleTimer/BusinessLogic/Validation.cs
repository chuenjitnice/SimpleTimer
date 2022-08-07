using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTimer
{
    class Validation
    {
        public static bool ValidateTimerValue(int hh, int mm, int ss)
        {
            return hh == 0 && mm == 0 && ss == 0;
        }
    }
}
