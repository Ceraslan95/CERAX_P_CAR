using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;

namespace CERAXCAR.Concrete
{
    public class Bluetooth
    {
        
        UI _ui;
        private const string carName = "CERASCAR";

        private bool bluetoothStatus = false;
        public Timer connectionTimer;

        public byte[] sendData;
        public byte[] receivedData;
        public const byte CheckSumKey = 0x10;

        private const int lenghtReceiveData = 3;
        private const int lenghtSendData = 3;

        //sending
        public const byte addressSpeed = 0x01;
        public const byte addressLedSignalLeft = 0x02;
        public const byte addressLedSignalRight = 0x03;
        public const byte addressLedFog = 0x04;
        public const byte addressLedShort = 0x05;
        public const byte addressLedLong = 0x06;
        public const byte addressLedTop = 0x07;
        public const byte addressLedPoint = 0x08;
        public const byte addressLedStop = 0x09;
        public const byte addressLedAbs = 0x0A;
        public const byte addressLedR = 0x0B;
        public const byte addressGoingDirection = 0x0C;
        public const byte addressDirectionRotate = 0x0D;
        public const byte addressHorn = 0x0E;
        public const byte addressSecurity = 0x0F;

        //received
        public const byte addressWarningBattery = 0x01;
        public const byte addressWarningMotorTemp = 0x02;
        public const byte addressWarningOil = 0x03;
        public const byte addressWarningEngine = 0x04;
        public const byte addressBatteryValue = 0x05;


        private BluetoothClient bluetoothClient;
        public BackgroundWorker scanWorker;
        public BackgroundWorker connectionWorker;
        
       

        BluetoothDeviceInfo carDeviceInfo;
        private const int dataCheckSumIndex = 0;
        private const int dataAddressIndex = 1;
        private const int dataValueIndex = 2;
        

        public Bluetooth(UI ui)
        {
            _ui = ui;
            
            connectionTimer = new Timer();
            connectionTimer.Interval = 700;
            connectionTimer.Elapsed += new ElapsedEventHandler(ConnectionTimer_Tick);

            sendData = new byte[lenghtSendData];
            sendData[dataCheckSumIndex] = CheckSumKey;
            //receivedData = new byte[lenghtReceiveData];






            bluetoothClient = new BluetoothClient();
            scanWorker = new BackgroundWorker();
            scanWorker.DoWork += ScanWorker_DoWork;
            scanWorker.RunWorkerCompleted += ScanWorker_RunWorkerCompletedAsync;
        }
     

        public void ScanWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ScanDevices();
        }
        private void ScanWorker_RunWorkerCompletedAsync(object sender, RunWorkerCompletedEventArgs e)
        {
            if (carDeviceInfo.DeviceAddress == null) 
            { 
                StopScanner();
            }
            else
            {
                Connect(carDeviceInfo.DeviceAddress);
            }
                    
        }

        private void StopScanner()
        {
            
            connectionTimer.Stop();
            SetBluetoothStatus(false);
            _ui.lblInfo.Text = "Bağlantı kurulamadı !";
            
        }

        public void Connect(BluetoothAddress address)
        {
            
            try
            {
                if (address is BluetoothAddress bluetoothAddress)
                {
                    var endPoint = new BluetoothEndPoint(bluetoothAddress, BluetoothService.SerialPort);
                    bluetoothClient.Connect(endPoint);

                    //bluetoothListener = new BluetoothListener(endPoint);
                    //bluetoothListener.Start();
                    //bluetoothClient = bluetoothListener.AcceptBluetoothClient();


                    SetBluetoothStatus(true);
                    _ui.lblInfo.Text = "* Bağlandı *";
                    Listener();
                }
                else
                {

                    _ui.lblInfo.Text = "Uyuşmazlık !";
                }
            }
            catch 
            {
                StopScanner();
            }

        }

        

        public void ScanDevices()
        {
            Disconnect();

            var devices = bluetoothClient.DiscoverDevices();
            foreach (var item in devices)
            {
                if (item.DeviceName == carName)
                {
                    carDeviceInfo = new BluetoothDeviceInfo(item.DeviceAddress);
                }
            }

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







        private void ConnectionTimer_Tick(object sender, ElapsedEventArgs e)
        {           
            _ui.pBluetooth.Visible = !_ui.pBluetooth.Visible;
            Console.WriteLine(_ui.pBluetooth.Visible);
            CheckConnection();
        }

        private void CheckConnection()
        {
            if (bluetoothStatus)
            {
                connectionTimer.Stop();
                _ui.pBluetooth.Visible = true;
            }
        }

        public bool GetBluetoothStatus()
        {
            return bluetoothStatus;
        }

        private void SetBluetoothStatus(bool value)
        {
            bluetoothStatus = value;            
        }

        public void StartConnection()
        {
            if (!connectionTimer.Enabled)
            {
                connectionTimer.Start();
                StartBluetooth();
            }
            
        }

        private void StartBluetooth()
        {
            scanWorker.RunWorkerAsync();
        }

        private void Listener()
        {
            var x = Task.Run(() =>
            {

                do
                {
                    if (bluetoothClient.Connected)
                    {
                        if (bluetoothClient.Available > 0)
                        {
                            var stream = bluetoothClient.GetStream();
                            byte[] receivedData = new byte[lenghtReceiveData];
                            int result = 0;
                            //while (stream.DataAvailable)
                            //{

                            //}
                            int offset = 0;
                            int remaining = receivedData.Length;
                            while (remaining > 0)
                            {
                                int read = stream.Read(receivedData, offset, remaining);
                               
                                remaining -= read;
                                offset += read;
                            }
                            SolutionCenter(receivedData);
                            

                        }
                    }
                    
                } while (true);

            });
        }

        private void SolutionCenter(byte[] receivedData)
        {
            if (receivedData[dataCheckSumIndex] == CheckSumKey)
            {
                var value = receivedData[dataValueIndex];
                switch (receivedData[dataAddressIndex])
                {
                    case addressWarningBattery:
                        {
                            SetWarningBattery(Convert.ToBoolean(value));
                        }
                        break;
                    case addressBatteryValue:
                        {
                            SetBatteryValue(Convert.ToInt32(value));
                        }
                        break;
                    case addressWarningEngine:
                        {
                            SetWarningEngine(Convert.ToBoolean(value));
                        }
                        break;
                    case addressWarningMotorTemp:
                        {
                            SetWarningHighTemp(Convert.ToBoolean(value));
                        }
                        break;
                    case addressWarningOil:
                        {
                            SetWarningOil(Convert.ToBoolean(value));
                        }
                        break;
                }
            }
        }

        private void SendData(byte address,byte value)
        {
            if (GetBluetoothStatus())
            {
                try
                {
                    if (bluetoothClient.Connected)
                    {
                        sendData[dataAddressIndex] = address;
                        sendData[dataValueIndex] = value;

                        var stream = bluetoothClient.GetStream();
                        
                        stream.Write(sendData, 0, sendData.Length);
                        stream.Flush();
                    }
                    else
                    {
                        SetBluetoothStatus(false);
                        _ui.pBluetooth.Visible = false;
                        _ui.lblInfo.Text = "Bağlantı koptu !";
                    }

                }
                catch
                {
                    SetBluetoothStatus(false);
                    _ui.pBluetooth.Visible = false;
                    _ui.lblInfo.Text = "Bağlantı koptu !";
                }
                

            }
            else
            {
                _ui.pBluetooth.Visible = false;
                _ui.lblInfo.Text = "Mesaj gönderilemedi !";
            }
        }

        //sürekli dinleme yapan listener olacak 


        //-------receive

        private void SetWarningEngine(bool value)
        {
            _ui.pEngine.Visible = value;
        }
        private void SetWarningHighTemp(bool value)
        {
            _ui.pHighTemp.Visible = value;
        }
        
        private void SetWarningBattery(bool value)
        {
            _ui.pBattery.Visible = value;
        }
        private void SetBatteryValue(int value)
        {
            _ui.KMUI.GaugeRanges.FindByName("KMBattery").EndValue = value;
        }
        private void SetWarningOil(bool value)
        {
            _ui.pOil.Visible = value;
        }



        //-------send

        public void SendKM(int value)
        {
            SendData(addressSpeed, Convert.ToByte(value));
        }

        public void SendDirection(int value)
        {
            SendData(addressDirectionRotate, Convert.ToByte(value));
        }
        public void SendGoingDirection(int value)
        {
            SendData(addressGoingDirection, Convert.ToByte(value));
        }

        public void SendSignalRight(bool value)
        {
            SendData(addressLedSignalRight, Convert.ToByte(value));
        }

        public void SendSignalLeft(bool value)
        {
            SendData(addressLedSignalLeft, Convert.ToByte(value));
        }

        public void SendLedFog(bool value)
        {
            SendData(addressLedFog, Convert.ToByte(value));
        }
        public void SendLedShort(bool value)
        {
            SendData(addressLedShort, Convert.ToByte(value));
        }
        public void SendLedLong(bool value)
        {
            SendData(addressLedLong, Convert.ToByte(value));
        }
        public void SendLedPoint(bool value)
        {
            SendData(addressLedPoint, Convert.ToByte(value));
        }
        public void SendLedTop(bool value)
        {
            SendData(addressLedTop, Convert.ToByte(value));
        }
        public void SendLedStop(bool value)
        {
            SendData(addressLedStop, Convert.ToByte(value));
        }
        public void SendLedAbs(bool value)
        {
            SendData(addressLedAbs, Convert.ToByte(value));
        }
        public void SendLedR(bool value)
        {
            SendData(addressLedR, Convert.ToByte(value));
        }

        public void SendHorn(bool value)
        {
            SendData(addressHorn, Convert.ToByte(value));
        }

        public void SendSecurity(bool value)
        {
            SendData(addressSecurity, Convert.ToByte(value));
        }

    }
}
