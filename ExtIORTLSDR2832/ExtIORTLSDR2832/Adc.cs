using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class Adc
    {
        Adc()
        {

        }
        private void IsEvent(object Event, object notification) { }
        private void IsFormatSupported(object samplesPerSec, object numbChannels, object bitsPerSample)
        {
            samplesPerSec = 44100;
            numbChannels = 2;
            bitsPerSample = 8;
        }
        //samplesPerSec: 44100, 22050, 11025, ... numbChannels : 1, 2, ... bitsPerSample : 8, 16, 24, ...

        private void IsRecording() { }
        private void Stop() { }
        private void Start(object samplesPerSec, object numbChannels, object bitsPerSample, object bufferSize)
        {
            samplesPerSec = 44100;
            numbChannels = 2;
            bitsPerSample = 8;
            bufferSize = 64;
        }
            //samplesPerSec : 44100, 22050, 11025, ... numbChannels : 1, 2, ... bitsPerSample : 8, 16, 24, ... bufferSize : 4096, 8192, 16384, ...

        private void GetBufferDuration()
        {

        }
        private void GetNumberOfDevices()
        {

        }
        //It returns the number of waveform - audio input devices present in the system
    }
}
