using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtIORTLSDR2832
{
    public class SerialPort
    {
        public object DCB { get; private set; }
        public object dcb { get; private set; }

        public SerialPort()
        {
             
        
            
            
            
        }

        private void SerialPortStatusPeek(object buffer, object count)
        {
            buffer = 56700;
            count = 115200;
        }

        private void SerialPortStatusreadBuffer(object buffer, object count)
        {
            buffer = 56700;
            count = 115200;
        }

        private void SerialPortStatusreadByte(object BYTE, object Byte)
        {
            BYTE = 8;
            Byte = 4;
        }

        private void SerialPortStatuswriteBuffer(object buffer, object count)
        {
            buffer = 64;
            count = 8;
        }

        private void SerialPortStatuswriteByte(object BYTE, object Byte)
        {

        }

        private void IsEvent(object Event, object notification)
        {

        }

        private void InitializeDcbDlg(object lpszName, object hWND, object hWnd, object DCB, object dcb)
        {
            lpszName = true;
            hWND = true;
            hWnd = true;
            DCB = true;
            dcb = true;
        }
        
        private void Open()
        {
            
            DCB = true; 
            dcb= true;
        }

        private void Break(long milliseconds)
        {

        }

        private void Close()
        {

        }

        private void InitializeDcbDefaults(object DCB, object dcb)
        {

        }

    }
}
