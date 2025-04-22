using System;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApp1.Script
{
    public class MySerialPort : IDisposable
    {
        private SerialPort serialPort = null;
        private string _portName;
        private int _baudRate;
        private Parity _parity;
        private int _dataBits;
        private StopBits _stopBits;
        private bool disposed = false;

        public bool IsOpen => serialPort != null && serialPort.IsOpen;

        public MySerialPort()
        {
        }

        public MySerialPort(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            Initialize(portName, baudRate, parity, dataBits, stopBits);
        }

        public void Initialize(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            if (string.IsNullOrEmpty(portName) || baudRate <= 0 || dataBits < 5 || dataBits > 8)
            {
                throw new ArgumentException("Invalid serial port parameters.");
            }

            _portName = portName;
            _baudRate = baudRate;
            _parity = parity;
            _dataBits = dataBits;
            _stopBits = stopBits;

            try
            {
                serialPort = new SerialPort(_portName, _baudRate, _parity, _dataBits, _stopBits);
                OpenSerialPort();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to initialize serial port.", ex);
            }
        }

        public void OpenSerialPort()
        {
            if (serialPort == null)
            {
                throw new InvalidOperationException("Serial port is not initialized.");
            }

            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                serialPort.Open();
            }
            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException("Access to the port is denied.");
            }
            catch (IOException)
            {
                throw new IOException("The port is in use or cannot be opened.");
            }
        }

        public void SendData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data), "Data cannot be null or empty.");
            }

            if (serialPort == null || !serialPort.IsOpen)
            {
                throw new InvalidOperationException("Serial port is not open.");
            }

            try
            {
                serialPort.WriteLine(data);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Serial port is not in a valid state.");
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort == null || !serialPort.IsOpen)
            {
                return;
            }

            lock (serialPort)
            {
                try
                {
                    string indata = serialPort.ReadExisting();
                    OnDataReceived(indata);
                }
                catch (TimeoutException)
                {
                    
                }
            }
        }

        protected virtual void OnDataReceived(string data)
        {
            
        }

        public void CloseSerialPort()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (serialPort != null)
                    {
                        serialPort.DataReceived -= DataReceivedHandler;
                        serialPort.Close();
                        serialPort.Dispose();
                        serialPort = null;
                    }
                }

                disposed = true;
            }
        }
        

        ~MySerialPort()
        {
            Dispose(false);
        }
    }
}
