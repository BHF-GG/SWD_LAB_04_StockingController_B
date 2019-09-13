using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStockingApplication.Classes;

namespace SWD_LAB_04_StockingController.Interfaces
{
    interface ITimerClient
    {
        void TimeOutCompression();
        void TimeOutDecompression();
    }
}
