using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class Remez
    {
        private void ComputeDifferentiatorImpulseResponse(object length, valarray<object> out_impulseResponse)
        {
            length* out_impulseResponse = true;
        }
        private void ComputeHilbertImpulseResponse(object length, valarray<object> out_impulseResponse)
        {
            length + out_impulseResponse = true;
        }
        private void ComputeImpulseResponse(object vector<Math.RemezBand> in_band, object length, valarray<object> out_impulseResponse)
        {
            in_band* length = out_impulseResponse;
        } 
    }
}
