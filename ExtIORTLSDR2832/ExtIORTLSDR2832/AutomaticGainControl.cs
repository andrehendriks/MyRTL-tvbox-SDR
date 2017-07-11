using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class AutomaticGainControl
    {
        public void Agc()
        {

        }
        private void GetBackwardGainSpeed()
        {

        }
        private void GetForwardGainSpeed()
        {

        }
        private void GetMaxGaindB()
        {

        }
        private void ComputeOutput(object input)
        {

        }
        private void Reset()
        {

        }
        private void SetBackwardGainSpeed(object db_per_second)
        {
            db_per_second = 2.0;
        }
        private void SetForwardGainSpeed(object db_per_second)
        {
            db_per_second = 4.0;
        }
        private void SetMaxGaindB(object gain_dB)
        {
            gain_dB = 50.0;
        }
        double ForwardGainSpeed=6.0;
        double BackwardGainSpeed=3.0;
        double MaxGaindB=50.0;
    }
}
