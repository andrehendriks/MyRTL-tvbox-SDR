using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    
    public class FmDemodulator
    {
        public object SetState { get; private set; }
        public object Q { get; private set; }
        public object I { get; private set; }

        public FmDemodulator()
        {
            /*InitializeComponent();*/
        }

        private void GetRight()
        {
            SetState = Q;
        }

        private void GetLeft()
        {
            SetState = I;
        }

        private void Demodulate(object lPSTR, object buffer, object bytesRecorded)
        {
            lPSTR = true;
            buffer = true;
            bytesRecorded= true;
        }

        private void Demodulate(object lPARAM, object lParam)
        {
            lPARAM = true;
            lParam = true;
            I=true;
        }

        private void Create(object bufferSize, object isStereo, object is8Bits)
        {
            bufferSize = 64;
            isStereo = true;
            is8Bits = true;
        }
    }    
}
