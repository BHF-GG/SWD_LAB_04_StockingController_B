using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using SWD_LAB_04_StockingController.Classes;
using SWD_LAB_04_StockingController.Interfaces;

namespace CompressionStockingApplication.Classes
{
    class TimedPump1 : ICompressionCtrl
    {
        //NYT
        private readonly ILED _ledG = new GreenLED();
        private readonly ILED _ledR = new RedLED();
        private readonly IVibrator _vibrator = new Vibrator();
        private System.Timers.Timer _aTimer = new System.Timers.Timer();
        private System.Timers.Timer _bTimer = new System.Timers.Timer();

        public void Compress()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("TimedPump1::Compress() called");
            _ledG.Toggle();
            _vibrator.ToggleVibrator();
            _bTimer.Interval = 5000;
            _bTimer.Elapsed += CompressTimeout;
            _bTimer.Start();
        }

        public void Decompress()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("TimedPump1::Decompress() called");
            _ledR.Toggle();
            _vibrator.ToggleVibrator();
            _aTimer.Interval = 2000;
            _aTimer.Elapsed += DecompressTimeout;
            _aTimer.Start();
        }

        private void CompressTimeout(object sender, System.Timers.ElapsedEventArgs e)
        {
            _bTimer.Stop();
            Console.WriteLine("Done Compressing");
            _ledG.Toggle();
            _vibrator.ToggleVibrator();
            Console.WriteLine("-------------------------");
        }

        private void DecompressTimeout(object sender, System.Timers.ElapsedEventArgs e)
        {
            _aTimer.Stop();
            Console.WriteLine("Done decompressing");
            _ledR.Toggle();
            _vibrator.ToggleVibrator();
            Console.WriteLine("-------------------------");
        }

    }
}
