using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SWD_LAB_04_StockingController.Interfaces;

namespace SWD_LAB_04_StockingController.Classes
{
    public class StockingController : IBtnHandler
    {
        private readonly ICompressionCtrl _compressionCtrl;


        public StockingController(ICompressionCtrl compressionCtrl)
        {
            _compressionCtrl = compressionCtrl;
        }
        // From IBtnHandler
        public void StartBtnPushed()
        {
            _compressionCtrl.Compress();

            //_ledG.Toggle();
            //_vibrator.ToggleVibrator();
            //_vibrator.ToggleVibrator();
            //_ledG.Toggle();
        }

        public void StopBtnPushed()
        {
            //_ledR.Toggle();
            //_vibrator.ToggleVibrator();
            _compressionCtrl.Decompress();
            //_vibrator.ToggleVibrator();
            //_ledR.Toggle();
        }


    }
}
