using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtIORTLSDR2832;

namespace RTL2832U_SDRadio
{
    public partial class SignalView : MainWindow
    {
        
        private void GetCh1Color(object color)
        {

        }
        private void GetCh2Color(object color)
        {

        }
        public SignalView()
        {
            Adc LowA = new Adc(); 
            InitializeComponent();
        }
        private void isEvent(object e, int notification)
        {

        }
        private void SetCh1Color(object color)
        {
            color = ConsoleColor.Blue;
        }
        private void SetCh2Color(object color)
        {
            color = ConsoleColor.Red;
        }

        private void OnData(object lParam)
        {
            lParam = IsActive;
        }
        private void SetToZero()
        {

        }
        private void Ch1Color(object color)
        {
            color = ConsoleColor.Blue;
        }
        private void Ch2Color(object color)
        {
            color = ConsoleColor.Red;
        }

    }
}
