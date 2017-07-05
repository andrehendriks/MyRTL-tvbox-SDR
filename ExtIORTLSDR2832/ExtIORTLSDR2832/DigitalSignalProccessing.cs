using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class DigitalSignalProccessing
    {
       private static void Convolution(object  input_x, object  input_y, object result)
        {

        } 
        private static void Convolution2(object input_x, object  input_y, object result)
        {

        } 
        private static void DiscreteCosineTransform(object  input, object output)
        {

        }
        //It returns false, if not enough memory

        private static void DiscreteCosineTransform_II(object  input, object output)
        {

        } 
        private static void FourierTransform(object  input, object output, object inverse)
        {

        } 
        private static void FourierTransform2(object  input, object output, object inverse)
        {

        } 
        private static void FourierTransformRe(object  input, object output)
        {

        } 
        private static void FourierTransformRe2(object  input, object output)
        {

        } 
        private static void HighPass(object  input, object output, object cutFreqRad)
        {

        } 
        private static void InvDiscreteCosineTransform(object  input, object output)
        {

        } 
        private static void InvDiscreteCosineTransform_II(object  input, object output)
        {

        } 
        private static void InverseFourierTransformRe(object  input, object output)
        {

        } 
        private static void InverseFourierTransformRe2(object  input, object output)
        {

        } 
        private static void IsPowerOfTwo(object input)
        {

        }
        private static void LowPass(object  input, object output, object cutFreqRad)
        {

        } 
        private static void ShortConvolution(object  input_x, object input_y, object result)
        {

        } 
        private static void ShortConvolution2(object  input_x, object  input_y, object result)
        {

        } 
        private static void SpectrumFold(object  input, object output)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumFold2(object  input, object output)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumUnfold(object  input, object output)
        {

        } 
        private static void SpectrumUnfold2(object  input, object output)
        {

        } 
        private static void SymmetricConvolution(object  symmetricInput, object input_y, object result)
        {

        } 
        private static void SymmetricConvolution2(object  symmetricInput, object  input_y, object result)
        {

        } 
        private static void SymmetricConvolution3(object  symmetricInput, object  input_y, object result)
        {

        } 
        private static void Ffta1(object  in_out, object inverse)
        {

        } 
        private static void Ffta(object  input_a, object output_a, object inverse)
        {

        } 
        private static void Fftb(object  input_b, object output_b, object inverse)
        {

        } 
        private static void Fft1(object  input, object output, object inverse)
        {

        } 
        private static void Fft2(object  input, object output, object inverse)
        {

        } 
        private static void Fftb1(object in_out, object inverse)
        {

        }
        //output[0] is the lowest frequency(offset) pi/m, 2pi/m, 3pi/m, ...pi,.....,2pi-3pi/m, 2pi-2pi/m, 2pi-pi/m Let m = input.size() Then output[m / 2] is output[PI] And output[m - 1] is output[2PI - PI / m] For real domain series output is conjugate symmetric, i.e., 10, 8+3j, 2+4j, 5-6j, 0, 5+6j, 2-4j, 8-3j

        private static void Fft2Da(object  input_a, object output_a)
        {

        } 
        private static void Fft2Db(object  input_b, object output_b)
        {

        } 
        private static void IFft2D(object isInputSymmetric, object  input, object output)
        {

        } 
        private static void Periodogram(object  input, object output)
        {

        } 
        private static void RealFft(object  in_out, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft2(object  input, object output, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft3(object  input, object output)
        {

        }
        //FFT optimized for real domain series, output is conjugate symmetric, i.e., 10, 8+3j, 2+4j, 5-6j, 0, 5+6j, 2-4j, 8-3j

        private static void RealFft4(object  input, object output, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void RealFft5(object in_out, object inverse)
        {

        }
        //Real and Imaginary parts are stored sequencially

        private static void Spectruma(object  input_a, object output_a)
        {

        } 
        private static void Spectrumb(object  input_b, object output_b)
        {

        } 
        private static void Spectrum1(object  input, object output)
        {

        } 
        private static void Spectrum2(object  input, object output)
        {

        } 
        private static void TwoFft(object  input1, object  input2, object out_fft1, object out_fft2)
        {

        } 
        private static void TwoIfft(object  input_fft1, object  input_fft2, object output1, object output2)
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
        private static void Autocorrelation(object  input, object output)
        {

        } 
        private static void Autocorrelation1(object  input, object output)
        {

        } 
        private static void Autocorrelation2(object  input, object output)
        {

        } 
        private static void Autocorrelation2b(object  input, object output)
        {

        } 
        private static void FreqRespHighPass(object beta, object length, object cutFreqRad, object out_H)
        {

        }
        private static void FreqRespHilbertTransform(object beta, object length, object out_H)
        {

        }
        private static void FreqRespHilbertTransform(object sampFreqHz, object rippleErrordB, object transitionWidthHz, object out_H)
        {

        }
        private static void FreqRespLowPass(object beta, object length, object cutFreqRad, object out_H)
        {

        }
        private static void GetModulus(object  input, object output)
        {

        } 
        private static void ImpulRespHighPass(object beta, object length, object cutFreqRad, object out_h)
        {

        }
        private static void ImpulRespHighPass(object sampFreqHz, object cutFreqHz, object stopBandGaindB, object transitionWidthHz, object out_h)
        {

        }
         static void ImpulRespHilbertTransform(object beta, object length, object out_h)
        {

        }
        private static void ImpulRespHilbertTransform(object sampFreqHz, object rippleErrordB, object transitionWidthHz, object out_h)
        {

        }
        private static void ImpulRespLowPass(object beta, object length, object cutFreqRad, object out_h)
        {

        }
        //cutFreqRad is in radians cutFreqRad = 2 * pi * fc / fs;

        private static void ImpulRespLowPass(object sampFreqHz, object cutFreqHz, object stopBandGaindB, object transitionWidthHz, object out_h)
        {

        }
        private static void KaiserWindow(object beta, object length, object out_window)
        {

        }
        private static void PhaseNormalization(object in_out)
        {

        }
        private static void PhaseNormalization1(object in_out)
        {

        }
        private static void PhaseNormalization2(object in_out)
        {

        }
        private static void PhaseNormalization3(object in_out)
        {

        }
        private static void SpectrumFold4(object in_out)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumFold5(object in_out)
        {

        }
        //input: x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7] output: x[4], x[5], x[6], x[7], x[0], x[1], x[2], x[3]

        private static void SpectrumUnfold4(object in_out)
        {

        }
        private static void SpectrumUnfold5(object in_out)
        {

        }
        private static void WelchWindow(object length, object out_window)
        {

        }
    }
}
