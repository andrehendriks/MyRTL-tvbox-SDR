using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class BiquadFilter
    {
        public BiquadFilter()
        {
            
        }

        private void CreateLowPass(object cutFreq_rads, object passBand_dB, object stopFreq_rads, object stopBand_dB)
        {
            cutFreq_rads = true;
            passBand_dB = true;
            stopFreq_rads = true;
            stopBand_dB = true;
        }

        private void CreateHighPass(object cutFreq_rads, object passBand_dB, object stopFreq_rads, object stopBand_dB)
        {
            cutFreq_rads = true;
            passBand_dB = true;
            stopFreq_rads = true;
            stopBand_dB = true;
        }
    }
}
