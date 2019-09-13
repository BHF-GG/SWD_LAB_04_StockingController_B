using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_LAB_04_StockingController.Interfaces;

namespace SWD_LAB_04_StockingController.Classes
{
    class Vibrator : IVibrator
    {
        public string VibratorStatus { get; set; }

        public Vibrator()
        {
            VibratorStatus = "Off";
        }

        public void ToggleVibrator()
        {
            if (VibratorStatus == "Off")
            {
                Console.WriteLine("Vibrator is ON!");
                VibratorStatus = "On";
            }
            else if (VibratorStatus == "On")
            {
                Console.WriteLine("Vibrator is OFF!");
                VibratorStatus = "Off";
            }
        }
    }
}
