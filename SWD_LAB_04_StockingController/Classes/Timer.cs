using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SWD_LAB_04_StockingController.Interfaces;

namespace CompressionStockingApplication.Classes
{
    class Timer
    {
        public void Register(int s, ITimerClient c)
        {
            if (s == 2)
            {
                c.TimeOutDecompression();
            }
            else if (s == 5)
            {
                c.TimeOutCompression();
            }
        }
    }
}
