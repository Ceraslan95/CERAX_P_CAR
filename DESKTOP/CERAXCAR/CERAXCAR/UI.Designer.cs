
namespace CERAXCAR
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.AGaugeLabel aGaugeLabel1 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel2 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeLabel aGaugeLabel3 = new System.Windows.Forms.AGaugeLabel();
            System.Windows.Forms.AGaugeRange aGaugeRange1 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange2 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange3 = new System.Windows.Forms.AGaugeRange();
            System.Windows.Forms.AGaugeRange aGaugeRange4 = new System.Windows.Forms.AGaugeRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.KMUI = new System.Windows.Forms.AGauge();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pNitro = new System.Windows.Forms.PictureBox();
            this.pFourAlert = new System.Windows.Forms.PictureBox();
            this.pRightSignal = new System.Windows.Forms.PictureBox();
            this.pLeftSignal = new System.Windows.Forms.PictureBox();
            this.pLongLed = new System.Windows.Forms.PictureBox();
            this.pShortLed = new System.Windows.Forms.PictureBox();
            this.pTurbo = new System.Windows.Forms.PictureBox();
            this.pFog = new System.Windows.Forms.PictureBox();
            this.pHorn = new System.Windows.Forms.PictureBox();
            this.pTopLed = new System.Windows.Forms.PictureBox();
            this.pTarget = new System.Windows.Forms.PictureBox();
            this.pESP = new System.Windows.Forms.PictureBox();
            this.pBluetooth = new System.Windows.Forms.PictureBox();
            this.pABS = new System.Windows.Forms.PictureBox();
            this.pCruise = new System.Windows.Forms.PictureBox();
            this.pEngine = new System.Windows.Forms.PictureBox();
            this.pHighTemp = new System.Windows.Forms.PictureBox();
            this.pHandBreak = new System.Windows.Forms.PictureBox();
            this.pSecurity = new System.Windows.Forms.PictureBox();
            this.pOil = new System.Windows.Forms.PictureBox();
            this.pBattery = new System.Windows.Forms.PictureBox();
            this.Timer4Signal = new System.Windows.Forms.Timer(this.components);
            this.timerInit = new System.Windows.Forms.Timer(this.components);
            this.timerRightSignal = new System.Windows.Forms.Timer(this.components);
            this.timerLeftSignal = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pNitro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFourAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRightSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLeftSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLongLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShortLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTurbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTopLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBluetooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCruise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHighTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBattery)).BeginInit();
            this.SuspendLayout();
            // 
            // KMUI
            // 
            this.KMUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.KMUI.BaseArcColor = System.Drawing.Color.RoyalBlue;
            this.KMUI.BaseArcRadius = 180;
            this.KMUI.BaseArcStart = 145;
            this.KMUI.BaseArcSweep = 250;
            this.KMUI.BaseArcWidth = 3;
            this.KMUI.Center = new System.Drawing.Point(200, 200);
            this.KMUI.Cursor = System.Windows.Forms.Cursors.Cross;
            this.KMUI.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aGaugeLabel1.Color = System.Drawing.Color.Navy;
            aGaugeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aGaugeLabel1.Name = "GaugeLabel1";
            aGaugeLabel1.Position = new System.Drawing.Point(161, 160);
            aGaugeLabel1.Text = "CERAXLAN";
            aGaugeLabel2.Color = System.Drawing.Color.AliceBlue;
            aGaugeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aGaugeLabel2.Name = "lblGearBox";
            aGaugeLabel2.Position = new System.Drawing.Point(190, 260);
            aGaugeLabel2.Text = "0";
            aGaugeLabel3.Color = System.Drawing.Color.Gray;
            aGaugeLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aGaugeLabel3.Name = "GaugeLabel1";
            aGaugeLabel3.Position = new System.Drawing.Point(185, 135);
            aGaugeLabel3.Text = "km/h";
            this.KMUI.GaugeLabels.Add(aGaugeLabel1);
            this.KMUI.GaugeLabels.Add(aGaugeLabel2);
            this.KMUI.GaugeLabels.Add(aGaugeLabel3);
            aGaugeRange1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            aGaugeRange1.EndValue = 240F;
            aGaugeRange1.InnerRadius = 153;
            aGaugeRange1.InRange = true;
            aGaugeRange1.Name = "GaugeRange1";
            aGaugeRange1.OuterRadius = 172;
            aGaugeRange1.StartValue = 0F;
            aGaugeRange2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            aGaugeRange2.EndValue = 240F;
            aGaugeRange2.InnerRadius = 90;
            aGaugeRange2.InRange = true;
            aGaugeRange2.Name = "GaugeRange2";
            aGaugeRange2.OuterRadius = 100;
            aGaugeRange2.StartValue = 0F;
            aGaugeRange3.Color = System.Drawing.Color.DarkGreen;
            aGaugeRange3.EndValue = 240F;
            aGaugeRange3.InnerRadius = 79;
            aGaugeRange3.InRange = false;
            aGaugeRange3.Name = "KMBattery";
            aGaugeRange3.OuterRadius = 86;
            aGaugeRange3.StartValue = 0F;
            aGaugeRange4.Color = System.Drawing.Color.RoyalBlue;
            aGaugeRange4.EndValue = 0F;
            aGaugeRange4.InnerRadius = 102;
            aGaugeRange4.InRange = false;
            aGaugeRange4.Name = "MotorTemp";
            aGaugeRange4.OuterRadius = 104;
            aGaugeRange4.StartValue = 0F;
            this.KMUI.GaugeRanges.Add(aGaugeRange1);
            this.KMUI.GaugeRanges.Add(aGaugeRange2);
            this.KMUI.GaugeRanges.Add(aGaugeRange3);
            this.KMUI.GaugeRanges.Add(aGaugeRange4);
            this.KMUI.Location = new System.Drawing.Point(300, 100);
            this.KMUI.MaxValue = 240F;
            this.KMUI.MinValue = 0F;
            this.KMUI.Name = "KMUI";
            this.KMUI.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Blue;
            this.KMUI.NeedleColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KMUI.NeedleRadius = 165;
            this.KMUI.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.KMUI.NeedleWidth = 3;
            this.KMUI.ScaleLinesInterColor = System.Drawing.Color.LightSkyBlue;
            this.KMUI.ScaleLinesInterInnerRadius = 158;
            this.KMUI.ScaleLinesInterOuterRadius = 168;
            this.KMUI.ScaleLinesInterWidth = 4;
            this.KMUI.ScaleLinesMajorColor = System.Drawing.Color.LightSkyBlue;
            this.KMUI.ScaleLinesMajorInnerRadius = 150;
            this.KMUI.ScaleLinesMajorOuterRadius = 175;
            this.KMUI.ScaleLinesMajorStepValue = 20F;
            this.KMUI.ScaleLinesMajorWidth = 6;
            this.KMUI.ScaleLinesMinorColor = System.Drawing.Color.LightSkyBlue;
            this.KMUI.ScaleLinesMinorInnerRadius = 162;
            this.KMUI.ScaleLinesMinorOuterRadius = 165;
            this.KMUI.ScaleLinesMinorTicks = 3;
            this.KMUI.ScaleLinesMinorWidth = 2;
            this.KMUI.ScaleNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.KMUI.ScaleNumbersFormat = null;
            this.KMUI.ScaleNumbersRadius = 131;
            this.KMUI.ScaleNumbersRotation = 0;
            this.KMUI.ScaleNumbersStartScaleLine = 1;
            this.KMUI.ScaleNumbersStepScaleLines = 1;
            this.KMUI.Size = new System.Drawing.Size(400, 400);
            this.KMUI.TabIndex = 0;
            this.KMUI.Text = "aGauge1";
            this.KMUI.Value = 0F;
            this.KMUI.ValueChanged += new System.EventHandler(this.KMUI_ValueChanged);
            // 
            // lblKM
            // 
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKM.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblKM.Location = new System.Drawing.Point(455, 425);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(92, 23);
            this.lblKM.TabIndex = 1;
            this.lblKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInfo.Location = new System.Drawing.Point(359, 456);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(282, 31);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pNitro
            // 
            this.pNitro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pNitro.BackgroundImage")));
            this.pNitro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pNitro.Location = new System.Drawing.Point(644, 141);
            this.pNitro.Name = "pNitro";
            this.pNitro.Size = new System.Drawing.Size(42, 39);
            this.pNitro.TabIndex = 5;
            this.pNitro.TabStop = false;
            // 
            // pFourAlert
            // 
            this.pFourAlert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pFourAlert.BackgroundImage")));
            this.pFourAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pFourAlert.Location = new System.Drawing.Point(475, 62);
            this.pFourAlert.Name = "pFourAlert";
            this.pFourAlert.Size = new System.Drawing.Size(50, 50);
            this.pFourAlert.TabIndex = 6;
            this.pFourAlert.TabStop = false;
            // 
            // pRightSignal
            // 
            this.pRightSignal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pRightSignal.BackgroundImage")));
            this.pRightSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pRightSignal.Location = new System.Drawing.Point(542, 71);
            this.pRightSignal.Name = "pRightSignal";
            this.pRightSignal.Size = new System.Drawing.Size(44, 49);
            this.pRightSignal.TabIndex = 7;
            this.pRightSignal.TabStop = false;
            // 
            // pLeftSignal
            // 
            this.pLeftSignal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLeftSignal.BackgroundImage")));
            this.pLeftSignal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pLeftSignal.Location = new System.Drawing.Point(411, 72);
            this.pLeftSignal.Name = "pLeftSignal";
            this.pLeftSignal.Size = new System.Drawing.Size(44, 49);
            this.pLeftSignal.TabIndex = 8;
            this.pLeftSignal.TabStop = false;
            // 
            // pLongLed
            // 
            this.pLongLed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLongLed.BackgroundImage")));
            this.pLongLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pLongLed.Location = new System.Drawing.Point(591, 92);
            this.pLongLed.Name = "pLongLed";
            this.pLongLed.Size = new System.Drawing.Size(50, 50);
            this.pLongLed.TabIndex = 9;
            this.pLongLed.TabStop = false;
            // 
            // pShortLed
            // 
            this.pShortLed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pShortLed.BackgroundImage")));
            this.pShortLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pShortLed.Location = new System.Drawing.Point(359, 93);
            this.pShortLed.Name = "pShortLed";
            this.pShortLed.Size = new System.Drawing.Size(50, 50);
            this.pShortLed.TabIndex = 10;
            this.pShortLed.TabStop = false;
            // 
            // pTurbo
            // 
            this.pTurbo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTurbo.BackgroundImage")));
            this.pTurbo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pTurbo.Location = new System.Drawing.Point(315, 136);
            this.pTurbo.Name = "pTurbo";
            this.pTurbo.Size = new System.Drawing.Size(39, 45);
            this.pTurbo.TabIndex = 11;
            this.pTurbo.TabStop = false;
            // 
            // pFog
            // 
            this.pFog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pFog.BackgroundImage")));
            this.pFog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pFog.Location = new System.Drawing.Point(280, 187);
            this.pFog.Name = "pFog";
            this.pFog.Size = new System.Drawing.Size(50, 50);
            this.pFog.TabIndex = 12;
            this.pFog.TabStop = false;
            // 
            // pHorn
            // 
            this.pHorn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pHorn.BackgroundImage")));
            this.pHorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pHorn.Location = new System.Drawing.Point(266, 243);
            this.pHorn.Name = "pHorn";
            this.pHorn.Size = new System.Drawing.Size(38, 36);
            this.pHorn.TabIndex = 13;
            this.pHorn.TabStop = false;
            // 
            // pTopLed
            // 
            this.pTopLed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTopLed.BackgroundImage")));
            this.pTopLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pTopLed.Location = new System.Drawing.Point(670, 185);
            this.pTopLed.Name = "pTopLed";
            this.pTopLed.Size = new System.Drawing.Size(50, 50);
            this.pTopLed.TabIndex = 14;
            this.pTopLed.TabStop = false;
            // 
            // pTarget
            // 
            this.pTarget.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTarget.BackgroundImage")));
            this.pTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pTarget.Location = new System.Drawing.Point(694, 243);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(29, 37);
            this.pTarget.TabIndex = 15;
            this.pTarget.TabStop = false;
            // 
            // pESP
            // 
            this.pESP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pESP.BackgroundImage")));
            this.pESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pESP.Location = new System.Drawing.Point(262, 290);
            this.pESP.Name = "pESP";
            this.pESP.Size = new System.Drawing.Size(50, 50);
            this.pESP.TabIndex = 16;
            this.pESP.TabStop = false;
            // 
            // pBluetooth
            // 
            this.pBluetooth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBluetooth.BackgroundImage")));
            this.pBluetooth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBluetooth.Location = new System.Drawing.Point(689, 294);
            this.pBluetooth.Name = "pBluetooth";
            this.pBluetooth.Size = new System.Drawing.Size(45, 41);
            this.pBluetooth.TabIndex = 17;
            this.pBluetooth.TabStop = false;
            // 
            // pABS
            // 
            this.pABS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pABS.BackgroundImage")));
            this.pABS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pABS.Location = new System.Drawing.Point(275, 346);
            this.pABS.Name = "pABS";
            this.pABS.Size = new System.Drawing.Size(50, 50);
            this.pABS.TabIndex = 18;
            this.pABS.TabStop = false;
            // 
            // pCruise
            // 
            this.pCruise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pCruise.BackgroundImage")));
            this.pCruise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pCruise.Location = new System.Drawing.Point(678, 347);
            this.pCruise.Name = "pCruise";
            this.pCruise.Size = new System.Drawing.Size(50, 41);
            this.pCruise.TabIndex = 19;
            this.pCruise.TabStop = false;
            // 
            // pEngine
            // 
            this.pEngine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pEngine.BackgroundImage")));
            this.pEngine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pEngine.Location = new System.Drawing.Point(419, 372);
            this.pEngine.Name = "pEngine";
            this.pEngine.Size = new System.Drawing.Size(50, 50);
            this.pEngine.TabIndex = 20;
            this.pEngine.TabStop = false;
            // 
            // pHighTemp
            // 
            this.pHighTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pHighTemp.BackgroundImage")));
            this.pHighTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pHighTemp.Location = new System.Drawing.Point(532, 372);
            this.pHighTemp.Name = "pHighTemp";
            this.pHighTemp.Size = new System.Drawing.Size(50, 50);
            this.pHighTemp.TabIndex = 21;
            this.pHighTemp.TabStop = false;
            // 
            // pHandBreak
            // 
            this.pHandBreak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pHandBreak.BackgroundImage")));
            this.pHandBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pHandBreak.Location = new System.Drawing.Point(297, 397);
            this.pHandBreak.Name = "pHandBreak";
            this.pHandBreak.Size = new System.Drawing.Size(47, 51);
            this.pHandBreak.TabIndex = 22;
            this.pHandBreak.TabStop = false;
            // 
            // pSecurity
            // 
            this.pSecurity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pSecurity.BackgroundImage")));
            this.pSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pSecurity.Location = new System.Drawing.Point(660, 402);
            this.pSecurity.Name = "pSecurity";
            this.pSecurity.Size = new System.Drawing.Size(41, 35);
            this.pSecurity.TabIndex = 23;
            this.pSecurity.TabStop = false;
            // 
            // pOil
            // 
            this.pOil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pOil.BackgroundImage")));
            this.pOil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pOil.Location = new System.Drawing.Point(369, 401);
            this.pOil.Name = "pOil";
            this.pOil.Size = new System.Drawing.Size(50, 50);
            this.pOil.TabIndex = 24;
            this.pOil.TabStop = false;
            // 
            // pBattery
            // 
            this.pBattery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBattery.BackgroundImage")));
            this.pBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBattery.Location = new System.Drawing.Point(581, 401);
            this.pBattery.Name = "pBattery";
            this.pBattery.Size = new System.Drawing.Size(50, 50);
            this.pBattery.TabIndex = 25;
            this.pBattery.TabStop = false;
            // 
            // Timer4Signal
            // 
            this.Timer4Signal.Interval = 800;
            this.Timer4Signal.Tick += new System.EventHandler(this.Timer4Signal_Tick);
            // 
            // timerInit
            // 
            this.timerInit.Enabled = true;
            this.timerInit.Interval = 3000;
            this.timerInit.Tick += new System.EventHandler(this.timerInit_Tick);
            // 
            // timerRightSignal
            // 
            this.timerRightSignal.Interval = 800;
            this.timerRightSignal.Tick += new System.EventHandler(this.timerRightSignal_Tick);
            // 
            // timerLeftSignal
            // 
            this.timerLeftSignal.Interval = 800;
            this.timerLeftSignal.Tick += new System.EventHandler(this.timerLeftSignal_Tick);
            // 
            // UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1000, 566);
            this.Controls.Add(this.pBattery);
            this.Controls.Add(this.pOil);
            this.Controls.Add(this.pSecurity);
            this.Controls.Add(this.pHandBreak);
            this.Controls.Add(this.pHighTemp);
            this.Controls.Add(this.pEngine);
            this.Controls.Add(this.pCruise);
            this.Controls.Add(this.pABS);
            this.Controls.Add(this.pBluetooth);
            this.Controls.Add(this.pESP);
            this.Controls.Add(this.pTarget);
            this.Controls.Add(this.pTopLed);
            this.Controls.Add(this.pHorn);
            this.Controls.Add(this.pFog);
            this.Controls.Add(this.pTurbo);
            this.Controls.Add(this.pShortLed);
            this.Controls.Add(this.pLongLed);
            this.Controls.Add(this.pLeftSignal);
            this.Controls.Add(this.pRightSignal);
            this.Controls.Add(this.pFourAlert);
            this.Controls.Add(this.pNitro);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.KMUI);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UI_FormClosed);
            this.Load += new System.EventHandler(this.UI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UI_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UI_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pNitro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFourAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRightSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLeftSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLongLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShortLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTurbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTopLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pESP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBluetooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pABS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCruise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHighTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHandBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBattery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pFourAlert;
        private System.Windows.Forms.PictureBox pRightSignal;
        private System.Windows.Forms.PictureBox pLeftSignal;
        private System.Windows.Forms.PictureBox pLongLed;
        private System.Windows.Forms.PictureBox pShortLed;
        private System.Windows.Forms.PictureBox pFog;
        private System.Windows.Forms.PictureBox pHorn;
        private System.Windows.Forms.PictureBox pTopLed;
        private System.Windows.Forms.PictureBox pTarget;
        private System.Windows.Forms.PictureBox pSecurity;
        public System.Windows.Forms.AGauge KMUI;
        private System.Windows.Forms.Timer Timer4Signal;
        private System.Windows.Forms.Timer timerInit;
        private System.Windows.Forms.Timer timerRightSignal;
        private System.Windows.Forms.Timer timerLeftSignal;
        public System.Windows.Forms.PictureBox pHandBreak;
        public System.Windows.Forms.PictureBox pTurbo;
        public System.Windows.Forms.PictureBox pNitro;
        public System.Windows.Forms.PictureBox pABS;
        public System.Windows.Forms.PictureBox pCruise;
        public System.Windows.Forms.Label lblInfo;
        public System.Windows.Forms.PictureBox pBluetooth;
        public System.Windows.Forms.Label lblKM;
        public System.Windows.Forms.PictureBox pEngine;
        public System.Windows.Forms.PictureBox pHighTemp;
        public System.Windows.Forms.PictureBox pOil;
        public System.Windows.Forms.PictureBox pBattery;
        public System.Windows.Forms.PictureBox pESP;
    }
}

