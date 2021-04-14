using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class HarmRange
    {
        public int Min { get; set; }
        public int Max { get; set; }


        public HarmRange(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }


}
