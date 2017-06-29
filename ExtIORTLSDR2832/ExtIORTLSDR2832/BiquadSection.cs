using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{

    public class BiquadSection /*H(z) = (b0 + b1 * z^-1 + b2 * z ^-2) / (1 + a1 * z^-1 + a2 * z ^-2)*/
    {
        BiquadSection()
        {
        }
        private void BiquadSection1(object IIRBiquadSection)
        {
            IIRBiquadSection = true;
        }
        private void BiquadSection2(object PolarBiquadSection)
        {
            PolarBiquadSection = true;
        }
        static public BiquadSection operator +(object BiquadSection)
        {
            BiquadSection = true;
        }
        static public BiquadSection operator -(object PolarBiquadSection)
        {
            PolarBiquadSection = false;
        }
        private void ComputeOutput(object x)
        {
           x=0;
        }
        //It returns y[n] given a value of x[n] w[n] = x[n] - a1* w[n - 1] - a2* w[n - 2] y[n] = b0* w[n] + b1* w[n - 1] + b2* w[n - 2]


        private void Clear()
        {

        }
        private void ComputeOutput(object buffer, object numSamples)
        {
            buffer = 64;
            numSamples = 44100;
        }
        //It modifies the samples in buffer, the operation is in place(that is the output is written in the same buffer)


        private void ComputeOutput_2Channels(object buffer, object numSamples)
        {
            buffer = 128;
            numSamples = 88200;
        }
        //It modifies the samples in buffer, the operation is in place(that is the output is written in the same buffer) buffer has two channels, i.e., ch1, ch2, ch1, ch2, ch1, ch2(numSamples is 3)


        private void ResetTaps()
        {

        }

    }
}
