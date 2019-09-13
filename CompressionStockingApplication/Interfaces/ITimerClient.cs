using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStockingApplication.Interfaces
{
    interface ITimerClient
    {
        void TimeOutCompression();
        void TimeOutDecompression();
    }
}
