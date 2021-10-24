using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using InTheHand;
using InTheHand.Net.Ports;
using System.IO;
using Microsoft.VisualBasic.Logging;
using System.Net.Sockets;


namespace ASKAR_CONTROL_PANEL
{
    class BluetoothService
    {
        private BluetoothClient bluetoothClient;
        private BluetoothListener bluetoothListener;
        

        ASKAR_UI_FORM Main_UI;
        private byte[] receivedData = new byte[5];
        //private object stream;
        public BluetoothService(ASKAR_UI_FORM main_UI)
        {
            Main_UI = main_UI;
          //  bluetoothListener = new BluetoothListener(UUID);
            //bluetoothListener.Start();
            //bluetoothClient = bluetoothListener.AcceptBluetoothClient();
           // Thread_BT  = new Thread(createBT);
            //Thread_BT.Start();
           bluetoothClient = new BluetoothClient();
            
        }

        private void createBT()
        {
            
            
           
        }
       

        public BluetoothDeviceInfo[] Devices { get; set; }
        //public object Stream { get => stream; set => stream = value; }

        public void ScanDevices()
        {
            Disconnect();

            Devices = bluetoothClient.DiscoverDevices();
        }
        Guid UUID = new Guid("6DAEA2BB-0642-4D03-92FE-B9A48885466F");
        public BluetoothConnectionResult Connect(object address)
        {
            var result = new BluetoothConnectionResult();

            try
            {
                if (address is BluetoothAddress bluetoothAddress)
                {
                    var endPoint = new BluetoothEndPoint(bluetoothAddress, InTheHand.Net.Bluetooth.BluetoothService.SerialPort);
                    bluetoothClient.Connect(endPoint);
                    bluetoothListener = new BluetoothListener(endPoint);
                    //bluetoothListener.Start();
                    //bluetoothClient = bluetoothListener.AcceptBluetoothClient();


                    result.IsSuccess = true;
                }
                else
                {
                    throw new Exception("The address should be a BluetoothAddress.");
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public void Disconnect()
        {
            if (bluetoothClient != null)
            {
                if (bluetoothClient.Connected)
                {
                    bluetoothClient.Close();
                    bluetoothClient.Dispose();

                    bluetoothClient = new BluetoothClient();
                }
            }
        }
      
        public void SendData(byte[] Data)
        {
            try
            {
                Main_UI.sendData[0] = Main_UI.CheckSumKey; // default Checksum key
                var stream = bluetoothClient.GetStream();
                //stream.WriteByte(value);
               
                stream.Write(Data, 0, Data.Length);
               
              
            }
            catch (Exception)
            {
                Main_UI.icoBluetooth.BackgroundImage = Properties.Resources.bluetoothDisconnect;
                Main_UI.InfoArea.Text = "Bağlatı Hatası";
            }
        }

        public void ReceivedData()
        {
            try
            {
                var stream = bluetoothClient.GetStream();
                if(stream.CanRead)
                {
                    
                    stream.Read(receivedData, 0, receivedData.Length);
                    ExamineData(receivedData);
                }
                
            }
            catch (Exception ex)
            {

               
            }
        }
        public void ExamineData(byte[] Data)
        {
            if (Data[0] == 0x16)
            {
                switch (Data[1])
                {

                    case 0x01://Address
                        break;
                    case 0x02://Address
                        break;
                    case 0x03://Address
                        Main_UI.BUFFER[1] = Data[2];
                        Main_UI.BUFFER[2] = Data[3];
                        break;
                    case 0x04://Address
                        break;
                    case 0x05://Address
                        break;
                }
            }
        }
        public void Listen()
        {
            bluetoothListener.Start();
        }
       
    }

    class BluetoothConnectionResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }

}

