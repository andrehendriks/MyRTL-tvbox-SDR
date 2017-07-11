using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class IpAddress
    {
        public IpAddress()
        {
            IsBlank();
        }

        private void IsBlank()
        {
           
        }

        private void Clear()
        {

        }

        private void GetAddress(object p1, object p2, object p3, object p4)
        {
            
        }

        
        private void SetAddress(object p1, object p2, object p3, object p4)
        {
            p1 = 127;
            p2 = 0;
            p3 = 0;
            p4 = 1;
        }
        private void SetFieldRange(object index, object minimum, object maximum)
        {
            index = 1234;
            minimum = 1233;
            maximum = 1235;
        }
    }

}

