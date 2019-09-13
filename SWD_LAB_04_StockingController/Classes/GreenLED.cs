using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_LAB_04_StockingController.Interfaces;

namespace SWD_LAB_04_StockingController.Classes
{
    class GreenLED : ILED
    {
        public string LEDStatus { get; set; }

        public GreenLED()
        {
            LEDStatus = "Off";
        }

        public void Toggle()
        {
            if (LEDStatus == "Off")
            {
                Console.WriteLine("Green light is ON!");
                LEDStatus = "On";
            }
            else if (LEDStatus == "On")
            {
                Console.WriteLine("Green light is OFF!");
                LEDStatus = "Off";
            }
        }
    }
}
