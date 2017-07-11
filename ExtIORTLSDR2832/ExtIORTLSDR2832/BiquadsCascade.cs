using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class BiquadsCascade
    {
        public BiquadsCascade()
        {
        }
        private void BiquadsCascade2(object BiquadsCascade)
        {
            BiquadsCascade = true;
        }
        private void BiquadsCascade3(object PolarBiquadsCascade)
        {
            PolarBiquadsCascade = true;
        }
        private void BiquadSection (object index)
        {
            
        }
    private void BiquadsCascade4(object BiquadsCascade)
    {
        BiquadsCascade = true;
    }
    private void BiquadsCascade5(object PolarBiquadsCascade)
    {
        PolarBiquadsCascade = true;
    }
    private void SetSize(object numberBiquadSections)
    {
        numberBiquadSections = 2;
    }
    private void BiquadSection(long index)
    {
         
    }
        private void ComputeOutput(double x)
        {
    x = 1.0;
        }
        //It returns y[n] given a value of x[n]


        private void GetSize()
        {
            return;
        }

        private void ComputeOutput2(object buffer, object numSamples)
        {
    buffer = 64;
    numSamples = 44100;
        }
        //It modifies the samples in buffer, the operation is in place(that is the output is written in the same buffer)


        private void ComputeOutput2_2Channels(object buffer, object numSamples)
        {
    buffer = 128;
    numSamples = 88200;
        }
        //It modifies the samples in buffer, the operation is in place(that is the output is written in the same buffer) buffer has two channels, i.e., ch1, ch2, ch1, ch2, ch1, ch2(numSamples is 3)


        private void Delete()
        {

        }
    }
}