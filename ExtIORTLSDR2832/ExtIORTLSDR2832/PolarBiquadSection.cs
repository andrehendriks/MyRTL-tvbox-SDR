using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class PolarBiquadSection
    {
        private void PolarBiquadSection1(object BiquadSection)
        {
            BiquadSection = true;
        } 
        private void PolarBiquadSection2(object PolarBiquadSection)
        {
            PolarBiquadSection = true;
        }
        public PolarBiquadSection()
        {

        }
        private void PolarBiquadSection3(object BiquadSection)
        {
            BiquadSection = true;
        } 
        private void PolarBiquadSection4(object PolarBiquadSection)
        {
            PolarBiquadSection = true;
        } 
        private void Clear()
        {

        }
        private void GetPoles(object out_reP1, object out_imP1, object out_reP2, object out_imP2)
        {
            out_reP1 = 1.0;
            out_imP1 = 1.0;
            out_reP2 = 1.0;
            out_imP2 = 1.0;
        }
        private void GetZeros(object out_reZ1, object out_imZ1, object out_reZ2, object out_imZ2)
        {
            out_reZ1 = 0.0;
            out_imZ1 = 0.0;
            out_reZ2 = 0.0;
            out_imZ2 = 0.0;
        }

    }
}
