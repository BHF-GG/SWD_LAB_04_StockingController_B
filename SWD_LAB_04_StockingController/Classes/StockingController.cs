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
        }

        public void StopBtnPushed()
        {
            _compressionCtrl.Decompress();
        }


    }
}
