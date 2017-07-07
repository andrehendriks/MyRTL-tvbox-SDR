using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTL2832U_SDRadio
{
    public partial class SignalView : MainWindow
    {
        
        private object GetCh1Color;
        private object GetCh2Color;
        public SignalView()
        {

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

        }
        private void SetToZero()
        {

        }
        private object Ch1Color;
        private object Ch2Color;

    }
}
