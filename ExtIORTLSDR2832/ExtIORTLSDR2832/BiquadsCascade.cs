using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class BiquadsCascade
    {
        BiquadsCascade()
        {
        }
        private void BiquadsCascade(object BiquadsCascade)
        {
            BiquadsCascade = true;
        }
        private void BiquadsCascade(object PolarBiquadsCascade)
        {
            PolarBiquadsCascade = true;
        }
        static public BiquadSection operator [ ](long index)
        {
            long ch1 = 26965000;
        }
    static public BiquadsCascade operator -(object BiquadsCascade)
    {
        BiquadsCascade = true;
    }
    static public BiquadsCascade operator +(object PolarBiquadsCascade)
    {
        PolarBiquadsCascade = true;
    }
    private void SetSize(object numberBiquadSections)
    {
        numberBiquadSections = 2;
    }
    static public BiquadSection operator [ ](long index)const
    {
         long numbch = 10000000;
    }
        ComputeOutput(double x)
        {
    x = 1.0;
        }
        //It returns y[n] given a value of x[n]


        private void GetSize()
        {
            return;
        }

        ComputeOutput(object buffer, object numSamples)
        {
    buffer = 64;
    numSamples = 44100;
        }
        //It modifies the samples in buffer, the operation is in place(that is the output is written in the same buffer)


        ComputeOutput_2Channels(object buffer, object numSamples)
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