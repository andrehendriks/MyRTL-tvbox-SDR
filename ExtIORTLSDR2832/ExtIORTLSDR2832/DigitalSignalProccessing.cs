using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class DigitalSignalProccessing
    {
       private static void Convolution(object valarray<complex<object>> input_x, object valarray<complex<object>> input_y, valarray<complex<object>> result)
        {

        } 
        private static void Convolution(object valarray<object> input_x, object valarray<object> input_y, valarray<object> result)
        {

        } 
        private static void DiscreteCosineTransform(object valarray<object> input, valarray<object> output)
        {

        }
        //It returns false, if not enough memory

        private static void DiscreteCosineTransform_II(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void FourierTransform(object MATRIXC input, MATRIXC output, object inverse)
        {

        } 
        private static void FourierTransform(object valarray<complex<object>> input, valarray<complex<object>> output, object inverse)
        {

        } 
        private static void FourierTransformRe(object MATRIX& input, MATRIXC& output)
        {

        } 
        private static void FourierTransformRe(object valarray<object> input, valarray<complex<object>> output)
        {

        } 
        private static void HighPass(object valarray<object> input, valarray<object> output, object cutFreqRad)
        {

        } 
        private static void InvDiscreteCosineTransform(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void InvDiscreteCosineTransform_II(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void InverseFourierTransformRe(object MATRIXC input, MATRIX output)
        {

        } 
        private static void InverseFourierTransformRe(object valarray<complex<object>> input, valarray<object> output)
        {

        } 
        private static void IsPowerOfTwo(object input)
        {

        }
        private static void LowPass(object valarray<object> input, valarray<object> output, object cutFreqRad)
        {

        } 
        private static void ShortConvolution(object valarray<complex<object>> input_x, object valarray<complex<object>> input_y, valarray<complex<object>> result)
        {

        } 
        private static void ShortConvolution(object valarray<object> input_x, object valarray<object> input_y, valarray<object> result)
        {

        } 
        private static void SpectrumFold(object valarray<complex<object>> input, valarray<complex<object>> output)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumFold(object valarray<object> input, valarray<object> output)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumUnfold(object valarray<complex<object>> input, valarray<complex<object>> output)
        {

        } 
        private static void SpectrumUnfold(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void SymmetricConvolution(object valarray<complex<object>> symmetricInput, object valarray<complex<object>> input_y, valarray<complex<object>> result)
        {

        } 
        private static void SymmetricConvolution(object valarray<complex<object>> symmetricInput, object valarray<object> input_y, valarray<complex<object>> result)
        {

        } 
        private static void SymmetricConvolution(object valarray<object> symmetricInput, object valarray<object> input_y, valarray<object> result)
        {

        } 
        private static void Fft(MATRIXC  in_out, object inverse)
        {

        } 
        private static void Fft(object MATRIX input_a, MATRIXC output_a, object inverse)
        {

        } 
        private static void Fft(object MATRIXC input_b, MATRIXC output_b, object inverse)
        {

        } 
        private static void Fft(object valarray<complex<object>> input, valarray<complex<object>> output, object inverse)
        {

        } 
        private static void Fft(object valarray<object> input, valarray<complex<object>> output, object inverse)
        {

        } 
        private static void Fft(valarray<complex<object>> in_out, object inverse)
        {

        }
        //output[0] is the lowest frequency(offset) pi/m, 2pi/m, 3pi/m, ...pi,.....,2pi-3pi/m, 2pi-2pi/m, 2pi-pi/m Let m = input.size() Then output[m / 2] is output[PI] And output[m - 1] is output[2PI - PI / m] For real domain series output is conjugate symmetric, i.e., 10, 8+3j, 2+4j, 5-6j, 0, 5+6j, 2-4j, 8-3j

        private static void Fft2D(object MATRIX input_a, MATRIXC output_a)
        {

        } 
        private static void Fft2D(object MATRIXC input_b, MATRIXC output_b)
        {

        } 
        private static void IFft2D(object isInputSymmetric, object MATRIXC input, MATRIXC output)
        {

        } 
        private static void Periodogram(object valarray<complex<object>> input, valarray<object> output)
        {

        } 
        private static void RealFft(MATRIX  in_out, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft(object MATRIX input, MATRIX output, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft(object valarray<object> input, valarray<complex<object>> output)
        {

        }
        //FFT optimized for real domain series, output is conjugate symmetric, i.e., 10, 8+3j, 2+4j, 5-6j, 0, 5+6j, 2-4j, 8-3j

        private static void RealFft(object valarray<object> input, valarray<object> output, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft(valarray<object> in_out, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void Spectrum(object MATRIX input_a, MATRIX output_a)
        {

        } 
        private static void Spectrum(object MATRIXC input_b, MATRIX output_b)
        {

        } 
        private static void Spectrum(object valarray<complex<object>> input, valarray<object> output)
        {

        } 
        private static void Spectrum(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void TwoFft(object valarray<object> input1, object valarray<object> input2, valarray<complex<object>> out_fft1, valarray<complex<object>> out_fft2)
        {

        } 
        private static void TwoIfft(object valarray<complex<object>> input_fft1, object valarray<complex<object>> input_fft2, valarray<object> output1, valarray<object> output2)
        {

        } 
        private static void AngleRotate(object x)
        {

        }
        private static void AngleRotate2(object x)
        {

        }
        private static void Circ(object x)
        {

        }
        private static void ComputeBeta(object stopBandGaindB)
        {

        }
        private static void Delta(object x)
        {

        }
        private static void Impulse(object n, object delay)
        {

        }
        //n is the discrete time d[n - delay]


        private static void Kaiser(object beta, object x)
        {

        }
        private static void Pi(object n, object delay, object duration)
        {

        }
        private static void Rect(object x)
        {

        }
        private static void Rectangular(object x, object period)
        {

        }
        private static void Sawtooth(object x, object period)
        {

        }
        private static void Sgn(object x)
        {

        }
        private static void Sin(object n, object k, object delay)
        {

        }
        //n is the discrete time Sin(kn-delay)


        private static void Sinc(object x)
        {

        }
        private static void Sinc(object n, object k, object delay)
        {

        }
        //n is the discrete time Sin(kn-delay)


        private static void Step(object x)
        {

        }
        private static void Step(object n, object delay)
        {

        }
        //n is the discrete time u[n - delay]


        private static void Triangular(object x, object period)
        {

        }
        private static void ComputeM(object stopBandGaindB, object transitionWidthRad)
        {

        }
        private static void FindNextPowerOfTwo(object input)
        {

        }
        private static void FindPreviousPowerOfTwo(object input)
        {

        }
        private static void Autocorrelation(object valarray<complex<object>> input, valarray<complex<object>> output)
        {

        } 
        private static void Autocorrelation(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void Autocorrelation2(object valarray<complex<object>> input, valarray<complex<object>> output)
        {

        } 
        private static void Autocorrelation2(object valarray<object> input, valarray<object> output)
        {

        } 
        private static void FreqRespHighPass(object beta, object length, object cutFreqRad, valarray<object> out_H)
        {

        }
        private static void FreqRespHilbertTransform(object beta, object length, valarray<object> out_H)
        {

        }
        private static void FreqRespHilbertTransform(object sampFreqHz, object rippleErrordB, object transitionWidthHz, valarray<object> out_H)
        {

        }
        private static void FreqRespLowPass(object beta, object length, object cutFreqRad, valarray<object> out_H)
        {

        }
        private static void GetModulus(object valarray<complex<object>> input, valarray<object> output)
        {

        } 
        private static void ImpulRespHighPass(object beta, object length, object cutFreqRad, valarray<object> out_h)
        {

        }
        private static void ImpulRespHighPass(object sampFreqHz, object cutFreqHz, object stopBandGaindB, object transitionWidthHz, valarray<object> out_h)
        {

        }
         static void ImpulRespHilbertTransform(object beta, object length, valarray<object> out_h)
        {

        }
        private static void ImpulRespHilbertTransform(object sampFreqHz, object rippleErrordB, object transitionWidthHz, valarray<object> out_h)
        {

        }
        private static void ImpulRespLowPass(object beta, object length, object cutFreqRad, valarray<object> out_h)
        {

        }
        //cutFreqRad is in radians cutFreqRad = 2 * pi * fc / fs;

        private static void ImpulRespLowPass(object sampFreqHz, object cutFreqHz, object stopBandGaindB, object transitionWidthHz, valarray<object> out_h)
        {

        }
        private static void KaiserWindow(object beta, object length, valarray<object> out_window)
        {

        }
        private static void PhaseNormalization(MATRIX in_out)
        {

        }
        private static void PhaseNormalization(MATRIXC in_out)
        {

        }
        private static void PhaseNormalization(valarray<complex<object>> in_out)
        {

        }
        private static void PhaseNormalization(valarray<object> in_out)
        {

        }
        private static void SpectrumFold(valarray<complex<object>> in_out)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumFold(valarray<object> in_out)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumUnfold(valarray<complex<object>> in_out)
        {

        }
        private static void SpectrumUnfold(valarray<object> in_out)
        {

        }
        private static void WelchWindow(object length, valarray<object> out_window)
        {

        }
    }
}
