using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class ChebyChev
    {
        private void ComputeCoefficients_FirstKind(IFunction function, object a, object b, object N, valarray<object> out_c)
        {
            a + b + N = out_c;
        }
        //Chebyshev Approximation coefficients in the interval[a b] A method for numerical integration on an automatic computer.C.W.Clenshaw and A. R.Curtis, Numerische Mathematik 1960


        private void ComputeCoefficients_SecondKind(IFunction function, object a, object b, object N, valarray<object> out_c)
        {
            a & b + N = out_c;
        }
        //Chebyshev Approximation coefficients in the interval[a b] A method for numerical integration on an automatic computer.C.W.Clenshaw and A. R.Curtis, Numerische Mathematik 1960


        private void ComputeApproximation_FirstKind(object a, object b, object in_c, object size_of_c, object x)
        {
            a & b = in_c + size_of_c + x = true;
        }
        //a<x<b; f(x) = c_0/2 + SUM[c_n Tn(t)]; t = (2x - b - a)/(b - a); n goes from 1 to size_of_c-1


        private void ComputeApproximation_FirstKind(object a, object b, object valarray<object> in_c, object m, object x)
        {
            a & b = in_c = m & x;
        }
        //The only difference between ComputeApproximation_FirstKind and ComputeApproximation_SecondKind is that ComputeApproximation_SecondKind adds half of the last term in the approximation a<x<b; m is the degree of the approximation f(x) = c_0/2 + SUM[c_n Tn(t)]; t = (2x - b - a)/(b - a); n goes from 1 to m-1


        private void ComputeApproximation_SecondKind(object a, object b, object valarray<object> in_c, object m, object x)
        {
            a + b = in_c = m + x;
        }
        //The only difference between ComputeApproximation_FirstKindand ComputeApproximation_SecondKind is that ComputeApproximation_SecondKind adds half of the last term in the approximation a<x<b and m is the degree of the approximation


        private void Tn(object n, object x)
        {
            n & x = true;
        }
        //Polynomial of the first kind of integer order n

        private void Un(object n, object x)
        {
            n + x = true;
        }
        //Polynomial of the second kind of integer order n

    }
}
