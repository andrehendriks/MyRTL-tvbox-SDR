using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class PolarBiquadSection
    {
        static public PolarBiquadSection operator -(object BiquadSection)
        {
            BiquadSection = true;
        } 
        static public PolarBiquadSection operator +(object PolarBiquadSection)
        {
            PolarBiquadSection = true;
        }
        PolarBiquadSection()
        {

        }
        private void PolarBiquadSection(object BiquadSection)
        {
            BiquadSection = true;
        } 
        private void PolarBiquadSection(object PolarBiquadSection)
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
