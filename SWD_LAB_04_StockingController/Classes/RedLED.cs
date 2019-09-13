using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_LAB_04_StockingController.Interfaces;

namespace SWD_LAB_04_StockingController.Classes
{
    class RedLED : ILED
    {
        public string LEDStatus { get; set; }

        public RedLED()
        {
            LEDStatus = "Off";
        }

        public void Toggle()
        {
            if (LEDStatus == "Off")
            {
                Console.WriteLine("Red light is ON!");
                LEDStatus = "On";
            }
            else if (LEDStatus == "On")
            {
                Console.WriteLine("Red light is OFF!");
                LEDStatus = "Off";
            }
        }
    }
}
