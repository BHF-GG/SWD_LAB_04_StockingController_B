﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStockingApplication.Classes;
using SWD_LAB_04_StockingController.Classes;
using SWD_LAB_04_StockingController.Interfaces;

namespace SWD_LAB_04_StockingController
{
    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            var compressionStocking = new StockingController(new TimedPump1());
            
            ConsoleKeyInfo consoleKeyInfo;

            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)
                {
                    compressionStocking.StartBtnPushed();
                    
                }

                if (consoleKeyInfo.Key == ConsoleKey.Z)
                {
                    compressionStocking.StopBtnPushed();
                }

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}