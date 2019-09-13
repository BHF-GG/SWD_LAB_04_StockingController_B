using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStockingApplication.Interfaces;

namespace CompressionStockingApplication.Classes
{
    class Timer
    {
        private int _secunds;
        public void Register(int s, ITimerClient c)
        {
            _secunds = s;
            
        }
    }
}
