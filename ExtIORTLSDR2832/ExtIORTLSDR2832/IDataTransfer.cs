using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class IDataTransfer
    {
        private void OnData(object LPARAM, object lParam)
        {
            lParam = 0;
            LPARAM = 0;
        }
        private void OnDataStarted() { }
        private void OnDataStopped() { }
    }
    
}
