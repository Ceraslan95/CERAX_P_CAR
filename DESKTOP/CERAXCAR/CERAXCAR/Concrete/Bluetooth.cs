using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CERAXCAR.Concrete
{
    public class Bluetooth
    {
        
        UI _ui;
        private bool bluetoothStatus = false;
        public Timer connectionTimer;

        public byte[] sendData;
        public byte[] receivedData;
        public const byte CheckSumKey = 0x16;

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
        
        




        public Bluetooth(UI ui)
        {
            _ui = ui;
            connectionTimer = new Timer();
            connectionTimer.Interval = 700;
            connectionTimer.Elapsed += new ElapsedEventHandler(ConnectionTimer_Tick);

            sendData = new byte[3];
            sendData[0] = CheckSumKey;

            receivedData = new byte[10];
        }

        private void ConnectionTimer_Tick(object sender, ElapsedEventArgs e)
        {
            _ui.pBluetooth.Visible = !_ui.pBluetooth.Visible;
            CheckConnection();
        }

        private void CheckConnection()
        {
            if (bluetoothStatus)
            {
                connectionTimer.Stop();
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
            //Baglanti yapilacak ve bluetoothStatus true yapilacak
        }

        private void SendData(byte address,byte value)
        {
            if (GetBluetoothStatus())
            {
                try
                {
                    
                    sendData[1] = address;
                    sendData[2] = value;
                    //var stream = bluetoothClient.GetStream();
                    ////stream.WriteByte(value);

                    //stream.Write(Data, 0, Data.Length);
                }
                catch (Exception)
                {
                    _ui.lblInfo.Text = "Mesaj gönderilemedi";
                }
                

            }
        }

        //sürekli dinleme yapan listener olacak 

        public void SendKM(int value)
        {
            SendData(addressSpeed, Convert.ToByte(value));
        }

    }
}
