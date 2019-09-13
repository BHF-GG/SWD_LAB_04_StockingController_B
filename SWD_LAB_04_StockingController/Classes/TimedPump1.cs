using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SWD_LAB_04_StockingController.Interfaces;

namespace CompressionStockingApplication.Classes
{
    class TimedPump1 : ICompressionCtrl, ITimerClient
    {
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
            Console.WriteLine("-------------------------");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Decompressing for 1 second!...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Done Decompressing!");
            Console.WriteLine("-------------------------");
        }
        public void TimeOutCompression()
        {
            Console.WriteLine("-------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Compressing for 1 second!...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Done compressing!");
            Console.WriteLine("-------------------------");
        }
    }
}
