using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASKAR_CONTROL_PANEL
{
    public partial class ASKAR_UI_FORM : Form
    {


        public ASKAR_UI_FORM()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            //timerDateClock.Start();
            //timerIcons.Start(); 
            dateTime = new DateTime();
            dateTime = DateTime.Now;
            labelDateDay.Text = dateTime.ToLongDateString();
            labelTime.Text = dateTime.ToShortTimeString();

           

            //-------pages 
            activePage = new Control();
            activePage = null;
            lastPage = null;

            welcomeStart = new WelcomeStart(this);
            welcomeStart.Visible = true;
            panelMainTopEdge.Controls.Add(welcomeStart);

            leftMenu = new LMenu(this);
            leftMenu.Visible = false;
            panelLeftMenu.Controls.Add(leftMenu);

            pL_ComSettingsMenu = new PL_ComSettingsMenu(this);
            pL_ComSettingsMenu.Visible = false;
            panelLeftMenu.Controls.Add(pL_ComSettingsMenu);

            pL_BluetoothSettings = new PL_BluetoothSettings(this);
            pL_BluetoothSettings.Visible = false;
            panelLeftMenu.Controls.Add(pL_BluetoothSettings);

            pL_Exit = new PL_Exit(this);
            pL_Exit.Visible = false;
            panelLeftMenu.Controls.Add(pL_Exit);

            pL_Help = new PL_Help(this);
            pL_Help.Visible = false;
            panelLeftMenu.Controls.Add(pL_Help);

            pL_Emergency = new PL_EmergencyNumbers(this);
            pL_Emergency.Visible = false;
            panelLeftMenu.Controls.Add(pL_Emergency);

            pL_CarPCProp = new PL_CarPCProp(this);
            pL_CarPCProp.Visible = false;
            panelLeftMenu.Controls.Add(pL_CarPCProp);

            pL_CarTechProp = new PL_CarTechProp(this);
            pL_CarTechProp.Visible = false;
            panelLeftMenu.Controls.Add(pL_CarTechProp);

            pL_SystemProp = new PL_SystemProp(this);
            pL_SystemProp.Visible = false;
            panelLeftMenu.Controls.Add(pL_SystemProp);

            pL_TechSettings = new PL_TechSettings(this);
            pL_TechSettings.Visible = false;
            panelLeftMenu.Controls.Add(pL_TechSettings);

            pL_KeyboardLock = new PL_KeyboardLock(this);
            pL_KeyboardLock.Visible = false;
            panelLeftMenu.Controls.Add(pL_KeyboardLock);

            pL_MotorSupport = new PL_MotorSupport(this);
            pL_MotorSupport.Visible = false;
            panelLeftMenu.Controls.Add(pL_MotorSupport);

            rightMenu = new RMenu(this);
            rightMenu.Visible = false;
            panelRightMenu.Controls.Add(rightMenu);

            pR_GraphBattery = new PR_GraphBattery(this);
            pR_GraphBattery.Visible = false;
            panelRightMenu.Controls.Add(pR_GraphBattery);

            pR_GraphLandSlope = new PR_GraphLandSlope(this);
            pR_GraphLandSlope.Visible = false;
            panelRightMenu.Controls.Add(pR_GraphLandSlope);

            pR_GraphParkSensor = new PR_GraphParkSensor(this);
            pR_GraphParkSensor.Visible = false;
            panelRightMenu.Controls.Add(pR_GraphParkSensor);

            pR_GraphRpm = new PR_GraphRpm(this);
            pR_GraphRpm.Visible = false;
            panelRightMenu.Controls.Add(pR_GraphRpm);

            pR_GraphTempState = new PR_GraphTempState(this);
            pR_GraphTempState.Visible = false;
            panelRightMenu.Controls.Add(pR_GraphTempState);

            pR_Graphs = new PR_Graphs(this);
            pR_Graphs.Visible = false;
            panelRightMenu.Controls.Add(pR_Graphs);

            pR_Map = new PR_Map(this);
            pR_Map.Visible = false;
            panelRightMenu.Controls.Add(pR_Map);

            pR_Internet = new PR_Internet(this);
            pR_Internet.Visible = false;
            panelRightMenu.Controls.Add(pR_Internet);

            pR_MediaPlayer = new PR_MediaPlayer(this);
            pR_MediaPlayer.Visible = false;
            panelRightMenu.Controls.Add(pR_MediaPlayer);

            //---------------------------------------------

            bMenu = new BMenu(this);
            bMenu.Visible = false;
            panelBottomMenu.Controls.Add(bMenu);

            pB_MapArea = new PB_MapArea(this);
            pB_MapArea.Visible = false;
            panelBottomMenu.Controls.Add(pB_MapArea);

            pB_Internet = new PB_Internet(this);
            pB_Internet.Visible = false;
            panelBottomMenu.Controls.Add(pB_Internet);

            pB_BatteryArea = new PB_BatteryArea(this);
            pB_BatteryArea.Visible = false;
            panelBottomMenu.Controls.Add(pB_BatteryArea);

            pB_TempArea = new PB_TempArea(this);
            pB_TempArea.Visible = false;
            panelBottomMenu.Controls.Add(pB_TempArea);

            //---------------------------------------------
            isBoard = true;
            //DashBoardPagesVisible(Pages.WelcomeStart);
            DashBoardPagesVisible(PageAddress.L, Pages.LMenu);
            DashBoardPagesVisible(PageAddress.R, Pages.RMenu);
            DashBoardPagesVisible(PageAddress.B, Pages.BMenu);


            //------------------bluetooth
            bluetoothService = new BluetoothService(this);


            scanWorker = new BackgroundWorker();
            scanWorker.DoWork += ScanWorker_DoWork;
            scanWorker.RunWorkerCompleted += ScanWorker_RunWorkerCompleted;

            connectionWorker = new BackgroundWorker();
            connectionWorker.DoWork += ConnectionWorker_DoWork;
            connectionWorker.RunWorkerCompleted += ConnectionWorker_RunWorkerCompleted;



            sendData = new byte[10];
            //receivedData = new byte[10];
            BUFFER = new byte[30];
            if (pL_BluetoothSettings.ToggleBT_Auto.Value)
            {
                scanWorker.RunWorkerAsync();
            }

        }

        public void CarDefaultProcessing()
        {
            sendData[1] = 0x00;//Address
            sendData[2] = 0x00;
            //bluetoothService.SendData(sendData);
            MainSendDataCenter(sendData);
        }
        //Bluetooth

        public void MainSendDataCenter(byte[] data)
        {
            //bluetooth Wifi veya Serial nereden gonderilecek ise o yazılacak 
            bluetoothService.SendData(data);
        }

        private readonly BluetoothService bluetoothService;

        public BackgroundWorker scanWorker;
        public BackgroundWorker connectionWorker;
        private BluetoothConnectionResult serviceResult;
        public void BT_Disconnect()
        {
            bluetoothService.Disconnect();
        }
        public void ScanWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bluetoothService.ScanDevices();
        }
        private void ScanWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var devices = bluetoothService.Devices;

            pL_BluetoothSettings.DevicesListBox.DataSource = devices;
            pL_BluetoothSettings.DevicesListBox.DisplayMember = "DeviceName";
            pL_BluetoothSettings.DevicesListBox.ValueMember = "DeviceAddress";
          

            pL_BluetoothSettings.btnScan.Visible = true;
            pL_BluetoothSettings.btnConnect.Visible = devices.Length > 0;
            pL_BluetoothSettings.lblInfo.Text = "Lüften Cihaz Seçiniz.";
            pL_BluetoothSettings.DevicesListBox.ClearSelected();
            int index = pL_BluetoothSettings.DevicesListBox.FindString("CERASCAR");
            if (index >= 0)
            {
                pL_BluetoothSettings.DevicesListBox.SelectedIndex = index;
                if (pL_BluetoothSettings.ToggleBT_Auto.Value)
                {
                    connectionWorker.RunWorkerAsync();
                }
            }
           

        }
        private void ConnectionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            object address = null;

            pL_BluetoothSettings.DevicesListBox.Invoke((Action)(() =>
            {
                if (pL_BluetoothSettings.DevicesListBox.SelectedIndex > -1)
                {
                    address = pL_BluetoothSettings.DevicesListBox.SelectedValue;
                    e.Result = pL_BluetoothSettings.DevicesListBox.Text;
                }
                else
                    pL_BluetoothSettings.lblInfo.Text = "Lüften Cihaz Seçiniz.";
            }));

            serviceResult = bluetoothService.Connect(address);
        }
        Thread BT_Tread;
        private void ConnectionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (serviceResult != null)
            {
                if (serviceResult.IsSuccess)
                {

                    pL_BluetoothSettings.lblInfo.Text = "Bağlandı = " + e.Result;

                    pL_BluetoothSettings.btnDisconnect.Visible = true;
                    icoBluetooth.BackgroundImage = Properties.Resources.bluetooth;
                    InfoArea.Text = "Motor Hazır ,2X 0 (Sıfır Tuşu) ile Çalıştır";
                    keyBoardLock = true;
                    DashBoardPagesVisible(PageAddress.R, Pages.PR_GraphRpm);
                    CarDefaultProcessing();

                    BWorkerBTreceivedHandler.RunWorkerAsync();
                    //BT_Tread = new Thread(new ThreadStart(BT_Listen));
                    //BT_Tread.Start();
                }
                else
                {
                    //lblInfo.Text = "" + serviceResult.Message;
                    pL_BluetoothSettings.lblInfo.Text = "Cihaz yanıt vermiyor";
                    icoBluetooth.BackgroundImage = Properties.Resources.bluetoothDisconnect;
                }
            }
            else
            {
                pL_BluetoothSettings.lblInfo.Text = "The serviceResult can not be null.";
                icoBluetooth.BackgroundImage = Properties.Resources.bluetoothDisconnect;
                //throw new NullReferenceException("The serviceResult can not be null.");
            }

            pL_BluetoothSettings.btnScan.Visible = true;

        }


        private void BT_Listen()
        {
            do
            {
                bluetoothService.ReceivedData();
            } while (serviceResult.IsSuccess);
        }

        private void BWorkerBTreceivedHandler_DoWork(object sender, DoWorkEventArgs e)
        {
            
            do
            {
                bluetoothService.ReceivedData();
            } while (!serviceResult.IsSuccess);

        }


        //Buffers
        public byte[] sendData;
        //public byte[] receivedData;
        public byte[] BUFFER;
        public byte CheckSumKey = 0x16;





        //Accesses

        public WelcomeStart welcomeStart;

        public LMenu leftMenu;
        public PL_ComSettingsMenu pL_ComSettingsMenu;
        public PL_BluetoothSettings pL_BluetoothSettings;
        public PL_Exit pL_Exit;
        public PL_Help pL_Help;
        public PL_EmergencyNumbers pL_Emergency;
        public PL_CarTechProp pL_CarTechProp;
        public PL_CarPCProp pL_CarPCProp;
        public PL_SystemProp pL_SystemProp;
        public PL_TechSettings pL_TechSettings;
        public PL_KeyboardLock pL_KeyboardLock;
        public PL_MotorSupport pL_MotorSupport;

        public RMenu rightMenu;
        public PR_GraphBattery pR_GraphBattery;
        public PR_GraphLandSlope pR_GraphLandSlope;
        public PR_GraphParkSensor pR_GraphParkSensor;
        public PR_GraphRpm pR_GraphRpm;
        public PR_GraphTempState pR_GraphTempState;
        public PR_Graphs pR_Graphs;
        public PR_Map pR_Map;
        public PR_Internet pR_Internet;
        public PR_MediaPlayer pR_MediaPlayer;

        public BMenu bMenu;
        public PB_MapArea pB_MapArea;
        public PB_Internet pB_Internet;
        public PB_BatteryArea pB_BatteryArea;
        public PB_TempArea pB_TempArea;
        

        DateTime dateTime;
        Control activePage;
        bool isBoard = false;

        public bool keyBoardLock = false;
       
        private bool timerSignalsAlive = false;
        private bool isLeftSignal;

        public bool MotorTurbo = false;
        public bool MotorNitro = false;


        //Page Controller
        public enum PageAddress
        {
            L,
            R,
            B
        }
        public enum Pages
        {

            LMenu,
            PL_ComSettingsMenu,
            PL_BluetoothSettings,
            PL_Exit,
            PL_Help,
            PL_EmergencyNumbers,
            PL_CarTechProp,
            PL_CarPCProp,
            PL_SystemProp,
            PL_TechSettings,
            PL_KeyboardLock,
            PL_MotorSupport,
            RMenu,
            PR_GraphBattery,
            PR_GraphLandSlope,
            PR_GraphParkSensor,
            PR_GraphRpm,
            PR_GraphTempState,
            PR_Graphs,
            PR_Map,
            PR_Internet,
            PR_MediaPlayer,
            BMenu,
            PB_MapArea,
            PB_Internet,
            PB_BatteryArea,
            PB_TempArea

        }
        Pages? lastPage = null;
        private void AddPanelControl()
        {
            activePage.Dock = DockStyle.Fill;
            activePage.Visible = true;

        }
        public void DashBoardPagesVisible(PageAddress PA, Pages page)
        {
            if (!isBoard)
            {
                return;
            }
            if (page == lastPage)
            {
                return;
            }
            switch (PA)
            {
                case PageAddress.L:
                    //welcomeStart.Visible = false;
                    leftMenu.Visible = false;
                    pL_ComSettingsMenu.Visible = false;
                    pL_BluetoothSettings.Visible = false;
                    pL_Exit.Visible = false;
                    pL_Help.Visible = false;
                    pL_Emergency.Visible = false;
                    pL_CarPCProp.Visible = false;
                    pL_CarTechProp.Visible = false;
                    pL_SystemProp.Visible = false;
                    pL_TechSettings.Visible = false;
                    pL_KeyboardLock.Visible = false;
                    pL_MotorSupport.Visible = false;
                    break;
                case PageAddress.R:
                    rightMenu.Visible = false;
                    pR_GraphBattery.Visible = false;
                    pR_GraphLandSlope.Visible = false;
                    pR_GraphParkSensor.Visible = false;
                    pR_GraphRpm.Visible = false;
                    pR_GraphTempState.Visible = false;
                    pR_Graphs.Visible = false;
                    pR_Map.Visible = false;
                    pR_Internet.Visible = false;
                    pR_MediaPlayer.Visible = false;
                    break;
                case PageAddress.B:
                    bMenu.Visible = false;
                    pB_MapArea.Visible = false;
                    pB_Internet.Visible = false;
                    pB_BatteryArea.Visible = false;
                    pB_TempArea.Visible = false;
                    break;

            }



            switch (page)
            {
                case Pages.LMenu:
                    activePage = leftMenu;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_ComSettingsMenu:
                    activePage = pL_ComSettingsMenu;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_BluetoothSettings:
                    activePage = pL_BluetoothSettings;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_Exit:
                    activePage = pL_Exit;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_Help:
                    activePage = pL_Help;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_EmergencyNumbers:
                    activePage = pL_Emergency;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_CarPCProp:
                    activePage = pL_CarPCProp;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_CarTechProp:
                    activePage = pL_CarTechProp;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_SystemProp:
                    activePage = pL_SystemProp;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_TechSettings:
                    activePage = pL_TechSettings;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_KeyboardLock:
                    activePage = pL_KeyboardLock;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PL_MotorSupport:
                    activePage = pL_MotorSupport;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.RMenu:
                    activePage = rightMenu;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_GraphBattery:
                    activePage = pR_GraphBattery;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_GraphLandSlope:
                    activePage = pR_GraphLandSlope;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_GraphParkSensor:
                    activePage = pR_GraphParkSensor;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_GraphRpm:
                    activePage = pR_GraphRpm;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_GraphTempState:
                    activePage = pR_GraphTempState;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_Graphs:
                    activePage = pR_Graphs;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_Map:
                    activePage = pR_Map;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_Internet:
                    activePage = pR_Internet;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PR_MediaPlayer:
                    activePage = pR_MediaPlayer;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.BMenu:
                    activePage = bMenu;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PB_MapArea:
                    activePage = pB_MapArea;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PB_Internet:
                    activePage = pB_Internet;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PB_BatteryArea:
                    activePage = pB_BatteryArea;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;
                case Pages.PB_TempArea:
                    activePage = pB_TempArea;
                    lastPage = page;
                    AddPanelControl();
                    //welcomeStart.LoadWC();
                    break;

            }
        }



        public bool brakeActive=false;

        //Periyodic Controls Start

        private void TimerDateClock_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            labelDateDay.Text = dateTime.ToLongDateString();
            labelTime.Text = dateTime.ToShortTimeString();
        }

        
        private void TimerIcons_Tick(object sender, EventArgs e)
        {
            
            //Temperature
            labelCelcius.Text = Convert.ToInt32(BUFFER[1]).ToString();
            //Humunity
            lblHumunity.Text = Convert.ToInt32(BUFFER[2]).ToString();
            //Battery
            if (CPBBattery.Value < 15)
            {
                CPBBattery.ProgressColor = Color.Red;
                icoBattery.Visible = true;
            }
            else
            {
                CPBBattery.ProgressColor = Color.DarkGreen;
                icoBattery.Visible = false;
            }


            //Celcius
            if (Convert.ToInt32(labelCelcius.Text) > 39)
            {
                icoHighHeat.Visible = true;
            }
            else
            {
                icoHighHeat.Visible = false;
            }

            //Greasing
            if (Convert.ToInt32(labelKM.Text) > 10000)
            {
                icoGreasing.Visible = true;
            }
            else
            {
                icoGreasing.Visible = false;
            }

        }
        bool flagMotorActive = false;
        int flagMotorRun = 1;
        bool motorRunning = false;
        private void ASKAR_UI_KeyDown(object sender, KeyEventArgs e)

        {
            if (keyBoardLock == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        if (motorRunning)
                        {
                            if (!brakeActive) { speedUpDown = true; }                           
                            if (!flagMotorActive) { flagMotorActive = true; timerMotor.Start(); }
                        }                       
                        break;
                    case Keys.A:
                        sendData[1] = 0x11;//Address
                        sendData[2] = 0x01;
                        MainSendDataCenter(sendData);
                        break;
                    case Keys.S:

                        break;
                    case Keys.D:
                        sendData[1] = 0x12;//Address
                        sendData[2] = 0x01;
                        MainSendDataCenter(sendData);
                        break;
                
                    case Keys.Space:// Break
                        icoAbs.Visible = true;
                        brakeActive = true;
                        speedUpDown = false;

                        sendData[1] = 0x00;//ID
                        sendData[2] = 0x01;//MID
                        sendData[3] = 0x04;//TID
                        sendData[4] = 0x01;//value

                        MainSendDataCenter(sendData);
                        break;
                    case Keys.U://LongLights                    
                        icoLongLight.Visible = !icoLongLight.Visible;
                        sendData[1] = 0x00;//ID
                        sendData[2] = 0x01;//MID
                        sendData[3] = 0x01;//TID
                        if (icoLongLight.Visible == true)
                        {
                            sendData[4] = 0x01;
                        }
                        else
                        {
                            sendData[4] = 0x00;
                        }
                        MainSendDataCenter(sendData);
                        break;
                    case Keys.I://ShortLights
                        icoShortLight.Visible = !icoShortLight.Visible;
                        sendData[1] = 0x00;//ID
                        sendData[2] = 0x01;//MID
                        sendData[3] = 0x02;//TID
                        if (icoShortLight.Visible == true)
                        {
                            sendData[4] = 0x01;
                        }
                        else
                        {
                            sendData[4] = 0x00;
                        }
                        MainSendDataCenter(sendData);
                        break;
                    case Keys.O://FogLights             // düzenleme yapılacak
                        icoFogs.Visible = !icoFogs.Visible;
                        sendData[1] = 0x01;//ID         
                        sendData[2] = 0x01;//MID
                        sendData[3] = 0x02;//TID
                        if (icoFogs.Visible == true)
                        {
                            sendData[4] = 0x01;
                        }
                        else
                        {
                            sendData[4] = 0x00;
                        }
                        MainSendDataCenter(sendData);
                        break;
                    case Keys.ShiftKey: // Gear UP
                        pR_GraphRpm.ChangeGearNumber(true);
                        break;
                    case Keys.ControlKey: // Gear DOWN
                        pR_GraphRpm.ChangeGearNumber(false);
                        break;                 
                    case Keys.T:// 4S Alert
                        if (timerSignalsAlive)
                        {
                            timerSignalsAlive = false;
                            timerSignalRightLeft.Stop();
                            icoRightSignal.Visible = false;
                            icoLeftSignal.Visible = false;
                            sendData[1] = 0x06;//Address
                            sendData[2] = 0x00;
                            MainSendDataCenter(sendData);
                        }
                        if (ico4s.Visible == false)
                        {
                            ico4s.Visible = true;
                            timer4S.Start();
                        }
                        else
                        {
                            ico4s.Visible = false;
                        }
                        break;
                    case Keys.Q:
                        if (ico4s.Visible == false)
                        {
                            isLeftSignal = true;
                            if (!timerSignalsAlive)
                            {
                                timerSignalsAlive = true;
                                timerSignalRightLeft.Start();
                            }
                        }
                        break;
                    case Keys.E:
                        if (ico4s.Visible == false)
                        {
                            isLeftSignal = false;
                            if (!timerSignalsAlive)
                            {
                                timerSignalsAlive = true;
                                timerSignalRightLeft.Start();
                            }
                        }
                        break;
                    case Keys.Home://Gear Left
                        pR_GraphRpm.ChangeGearBox(false);
                        break;
                    case Keys.End:
                        pR_GraphRpm.ChangeGearBox(true);
                        break;                
                    case Keys.NumPad0://Car start
                        flagMotorRun++;
                        if (flagMotorRun % 5 == 0 && pR_GraphRpm.ValueSPEED == 0)
                        {
                            InfoArea.Text = "Motor Kapatıldı.";
                            pR_GraphRpm.AG_RPM.Value = 0;
                            sendData[1] = 0x00;//Address
                            sendData[2] = 0x00;
                            MainSendDataCenter(sendData);
                            flagMotorRun = 1;
                            motorRunning = false;
                        }
                        else if (flagMotorRun % 3 == 0 && pR_GraphRpm.ValueSPEED == 0)
                        {
                            InfoArea.Text = "Motor Çalışıyor..";
                            pR_GraphRpm.AG_RPM.Value = 5;
                            sendData[1] = 0x00;//Address
                            sendData[2] = 0x01;
                            MainSendDataCenter(sendData);
                            motorRunning = true;
                        }                        
                        break;
                    case Keys.N:
                        if (MotorNitro == true)
                        {
                            if(speedUpDown && pR_GraphRpm.Value_GEAR_BOX>1 && pR_GraphRpm.Value_GEAR_NUMBER > 3)
                            {
                                pR_GraphRpm.pbNitro.Visible = true;
                            }
                            
                        }
                        break;
                }
            }
        }      
        private void ASKAR_UI_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyBoardLock == true)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (timerSignalsAlive && isLeftSignal)
                        {
                            timerSignalRightLeft.Stop();
                            icoLeftSignal.Visible = false;
                            timerSignalsAlive = false;
                            sendData[1] = 0x04;//Address
                            sendData[2] = 0x00;
                            MainSendDataCenter(sendData);
                        }
                        break;
                    case Keys.W:
                        speedUpDown = false;
                        break;
                    case Keys.S:

                        break;
                    case Keys.D:
                        if (timerSignalsAlive && !isLeftSignal)
                        {
                            timerSignalRightLeft.Stop();
                            icoRightSignal.Visible = false;
                            timerSignalsAlive = false;
                            sendData[1] = 0x05;//Address
                            sendData[2] = 0x00;
                            MainSendDataCenter(sendData);
                        }

                        break;
                    case Keys.M:

                        break;
                    case Keys.N:
                        if(MotorNitro == true)
                        {
                            pR_GraphRpm.pbNitro.Visible = false;
                        }                        
                        break;
                    case Keys.K:

                        break;
                    case Keys.R:
                        if (timerSignalsAlive)
                        {
                            timerSignalRightLeft.Stop();
                            icoRightSignal.Visible = false;
                            icoLeftSignal.Visible = false;
                            timerSignalsAlive = false;
                            sendData[1] = 0x06;//Address
                            sendData[2] = 0x00;
                            MainSendDataCenter(sendData);
                        }
                        break;
                    case Keys.Space:// Break
                        brakeActive = false;
                        icoAbs.Visible = false;
                        sendData[1] = 0x00;//ID
                        sendData[2] = 0x01;//MID
                        sendData[3] = 0x04;//TID
                        sendData[4] = 0x00;//value
                        MainSendDataCenter(sendData);
                        break;
                }
            }
        }

        public static bool CapslockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }
        //Timers
        private void Timer4S_Tick(object sender, EventArgs e)
        {
            sendData[1] = 0x06;//Address
            icoLeftSignal.Visible = !icoLeftSignal.Visible;
            icoRightSignal.Visible = !icoRightSignal.Visible;
            if (icoLeftSignal.Visible && icoRightSignal.Visible)
            {
                sendData[2] = 0x01;
            }
            else
            {
                sendData[2] = 0x00;
            }
            if (ico4s.Visible == false)
            {
                icoLeftSignal.Visible = false;
                icoRightSignal.Visible = false;
                sendData[2] = 0x00;
                timer4S.Stop();
            }
            MainSendDataCenter(sendData);

        }
        private void TimerSignalRightLeft_Tick(object sender, EventArgs e)
        {

            if (isLeftSignal)
            {
                sendData[1] = 0x04;//Address
                icoLeftSignal.Visible = !icoLeftSignal.Visible;
                icoRightSignal.Visible = false;
                if (icoLeftSignal.Visible)
                {
                    sendData[2] = 0x01;
                }
                else
                {
                    sendData[2] = 0x00;
                }
            }
            else
            {
                sendData[1] = 0x05;//Address
                icoRightSignal.Visible = !icoRightSignal.Visible;
                icoLeftSignal.Visible = false;
                if (icoRightSignal.Visible)
                {
                    sendData[2] = 0x01;
                }
                else
                {
                    sendData[2] = 0x00;
                }

            }
            MainSendDataCenter(sendData);



        }

        public bool speedUpDown = false;
        private void TimerMotor_Tick(object sender, EventArgs e)
        {
            if (speedUpDown)
            {
                pR_GraphRpm.ValueSPEED++;
            }
            else
            {

                if (brakeActive)
                {
                    pR_GraphRpm.ValueSPEED -= 20; 
                }
                else
                {
                    pR_GraphRpm.ValueSPEED--;
                }
               
            }
            if (pR_GraphRpm.ValueSPEED <= 0)
            {
                pR_GraphRpm.ValueSPEED = 0;
                flagMotorActive = false;
                timerMotor.Stop();
            }
        }
        private void ASKAR_UI_FORM_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CarDefaultProcessing();
        }

        private void labelKM_Click(object sender, EventArgs e)
        {

        }
    }
}
