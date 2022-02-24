using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;


namespace SerialPortPC
{
    class SerialPortPc : SerialPort
    {
        private SerialPort _serialPort;

        // Summary:
        //     Initializes a new instance of the System.IO.Ports.SerialPort class using the
        //     specified port name and baud rate
        //
        // Parameters:
        //   portName:
        //     The port to use (for example, COM1).
        //
        //   baudRate:
        //     The baud rate.
        //
        // Exceptions:
        //   T:System.IO.IOException:
        //     The specified port could not be found or opened.
        public SerialPortPc(string portName, int baudRate)
        {
            // Create a new SerialPort object
            try
            {
                _serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            }
            catch (Exception)
            {
                throw;
            }

            //// Open serial port created above
            //if (_serialPort != null)
            //{
            //    try
            //    {
            //        _serialPort.Open();
            //    }
            //    catch (Exception)
            //    {
            //        throw;
            //    }
            //}
        }

        // Summary:
        // This method will close a serial port
        //
        public void CloseSerialPort()
        {
            try
            {
                if (_serialPort != null)
                {
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
