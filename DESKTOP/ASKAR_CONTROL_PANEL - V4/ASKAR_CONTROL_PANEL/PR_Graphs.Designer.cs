namespace ASKAR_CONTROL_PANEL
{
    partial class PR_Graphs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PR_Graphs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTempStateGraph = new System.Windows.Forms.Button();
            this.btnRpmGraph = new System.Windows.Forms.Button();
            this.btnParkSensorGraph = new System.Windows.Forms.Button();
            this.btnLandSlopeGraph = new System.Windows.Forms.Button();
            this.btnBatteryGraph = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 49);
            this.panel1.TabIndex = 6;
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Controls.Add(this.label1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 27);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(430, 22);
            this.panel17.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grafikler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTempStateGraph);
            this.panel2.Controls.Add(this.btnRpmGraph);
            this.panel2.Controls.Add(this.btnParkSensorGraph);
            this.panel2.Controls.Add(this.btnLandSlopeGraph);
            this.panel2.Controls.Add(this.btnBatteryGraph);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 259);
            this.panel2.TabIndex = 8;
            // 
            // btnTempStateGraph
            // 
            this.btnTempStateGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTempStateGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTempStateGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTempStateGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTempStateGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempStateGraph.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempStateGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnTempStateGraph.Image")));
            this.btnTempStateGraph.Location = new System.Drawing.Point(56, 205);
            this.btnTempStateGraph.Name = "btnTempStateGraph";
            this.btnTempStateGraph.Size = new System.Drawing.Size(318, 40);
            this.btnTempStateGraph.TabIndex = 10;
            this.btnTempStateGraph.TabStop = false;
            this.btnTempStateGraph.Text = "Sıcaklık Grafiği";
            this.btnTempStateGraph.UseVisualStyleBackColor = false;
            this.btnTempStateGraph.Click += new System.EventHandler(this.BtnTempStateGraph_Click);
            // 
            // btnRpmGraph
            // 
            this.btnRpmGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRpmGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnRpmGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRpmGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRpmGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRpmGraph.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRpmGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnRpmGraph.Image")));
            this.btnRpmGraph.Location = new System.Drawing.Point(56, 159);
            this.btnRpmGraph.Name = "btnRpmGraph";
            this.btnRpmGraph.Size = new System.Drawing.Size(318, 40);
            this.btnRpmGraph.TabIndex = 9;
            this.btnRpmGraph.TabStop = false;
            this.btnRpmGraph.Text = "Rpm Grafiği";
            this.btnRpmGraph.UseVisualStyleBackColor = false;
            this.btnRpmGraph.Click += new System.EventHandler(this.BtnRpmGraph_Click);
            // 
            // btnParkSensorGraph
            // 
            this.btnParkSensorGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnParkSensorGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnParkSensorGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnParkSensorGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnParkSensorGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkSensorGraph.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkSensorGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnParkSensorGraph.Image")));
            this.btnParkSensorGraph.Location = new System.Drawing.Point(56, 113);
            this.btnParkSensorGraph.Name = "btnParkSensorGraph";
            this.btnParkSensorGraph.Size = new System.Drawing.Size(318, 40);
            this.btnParkSensorGraph.TabIndex = 8;
            this.btnParkSensorGraph.TabStop = false;
            this.btnParkSensorGraph.Text = "Park Sensör Grafiği";
            this.btnParkSensorGraph.UseVisualStyleBackColor = false;
            this.btnParkSensorGraph.Click += new System.EventHandler(this.BtnParkSensorGraph_Click);
            // 
            // btnLandSlopeGraph
            // 
            this.btnLandSlopeGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLandSlopeGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnLandSlopeGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLandSlopeGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLandSlopeGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLandSlopeGraph.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLandSlopeGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnLandSlopeGraph.Image")));
            this.btnLandSlopeGraph.Location = new System.Drawing.Point(56, 67);
            this.btnLandSlopeGraph.Name = "btnLandSlopeGraph";
            this.btnLandSlopeGraph.Size = new System.Drawing.Size(318, 40);
            this.btnLandSlopeGraph.TabIndex = 7;
            this.btnLandSlopeGraph.TabStop = false;
            this.btnLandSlopeGraph.Text = "Arazi Eğim Grafiği";
            this.btnLandSlopeGraph.UseVisualStyleBackColor = false;
            this.btnLandSlopeGraph.Click += new System.EventHandler(this.BtnLandSlopeGraph_Click);
            // 
            // btnBatteryGraph
            // 
            this.btnBatteryGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBatteryGraph.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBatteryGraph.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnBatteryGraph.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBatteryGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatteryGraph.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatteryGraph.Image = ((System.Drawing.Image)(resources.GetObject("btnBatteryGraph.Image")));
            this.btnBatteryGraph.Location = new System.Drawing.Point(56, 21);
            this.btnBatteryGraph.Name = "btnBatteryGraph";
            this.btnBatteryGraph.Size = new System.Drawing.Size(318, 40);
            this.btnBatteryGraph.TabIndex = 6;
            this.btnBatteryGraph.TabStop = false;
            this.btnBatteryGraph.Text = "Batarya Grafiği";
            this.btnBatteryGraph.UseVisualStyleBackColor = false;
            this.btnBatteryGraph.Click += new System.EventHandler(this.BtnBatteryGraph_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(50, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(330, 15);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(380, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(50, 259);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 58);
            this.panel3.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(50, 259);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // PR_Graphs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "PR_Graphs";
            this.Size = new System.Drawing.Size(430, 308);
            this.panel1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRpmGraph;
        private System.Windows.Forms.Button btnParkSensorGraph;
        private System.Windows.Forms.Button btnLandSlopeGraph;
        private System.Windows.Forms.Button btnBatteryGraph;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnTempStateGraph;
    }
}
