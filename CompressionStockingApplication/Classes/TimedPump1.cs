using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CompressionStocking;
using CompressionStockingApplication.Interfaces;

namespace CompressionStockingApplication.Classes
{
    class TimedPump1 : ICompressionCtrl, ITimerClient
    {
        private Timer _timer = new Timer();
        
        public void Compress()
        {
            Console.WriteLine("TimedPump1::Compress() called");
            
        }
        public void Decompress()
        {
            Console.WriteLine("TimedPump1::Decompress() called");

        }

        public void TimeOutDecompression()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Decompressing for 1 second!...");
                Thread.Sleep(1000);
            }
        }
        public void TimeOutCompression()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Compressing for 1 second!...");
                Thread.Sleep(1000);
            }
        }
    }
}
