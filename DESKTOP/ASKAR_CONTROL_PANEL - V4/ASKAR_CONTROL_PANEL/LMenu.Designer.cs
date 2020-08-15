namespace ASKAR_CONTROL_PANEL
{
    partial class LMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTechSettings = new System.Windows.Forms.Button();
            this.btnExitPage = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnTripInfo = new System.Windows.Forms.Button();
            this.btnConnectionSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 49);
            this.panel1.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Controls.Add(this.pictureBox1);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 27);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(430, 22);
            this.panel17.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(404, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTechSettings);
            this.panel2.Controls.Add(this.btnExitPage);
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnTripInfo);
            this.panel2.Controls.Add(this.btnConnectionSettings);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 259);
            this.panel2.TabIndex = 1;
            // 
            // btnTechSettings
            // 
            this.btnTechSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTechSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTechSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTechSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTechSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechSettings.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnTechSettings.Image")));
            this.btnTechSettings.Location = new System.Drawing.Point(57, 67);
            this.btnTechSettings.Name = "btnTechSettings";
            this.btnTechSettings.Size = new System.Drawing.Size(318, 40);
            this.btnTechSettings.TabIndex = 10;
            this.btnTechSettings.TabStop = false;
            this.btnTechSettings.Text = "Teknik Ayarlar";
            this.btnTechSettings.UseVisualStyleBackColor = false;
            this.btnTechSettings.Click += new System.EventHandler(this.BtnTechSettings_Click);
            // 
            // btnExitPage
            // 
            this.btnExitPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnExitPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnExitPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnExitPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnExitPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPage.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPage.Image = ((System.Drawing.Image)(resources.GetObject("btnExitPage.Image")));
            this.btnExitPage.Location = new System.Drawing.Point(57, 205);
            this.btnExitPage.Name = "btnExitPage";
            this.btnExitPage.Size = new System.Drawing.Size(318, 40);
            this.btnExitPage.TabIndex = 9;
            this.btnExitPage.TabStop = false;
            this.btnExitPage.Text = "ÇIKIŞ";
            this.btnExitPage.UseVisualStyleBackColor = false;
            this.btnExitPage.Click += new System.EventHandler(this.BtnExitPage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(56, 159);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(318, 40);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Yardım";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnTripInfo
            // 
            this.btnTripInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTripInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnTripInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTripInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTripInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTripInfo.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnTripInfo.Image")));
            this.btnTripInfo.Location = new System.Drawing.Point(56, 113);
            this.btnTripInfo.Name = "btnTripInfo";
            this.btnTripInfo.Size = new System.Drawing.Size(318, 40);
            this.btnTripInfo.TabIndex = 6;
            this.btnTripInfo.TabStop = false;
            this.btnTripInfo.Text = "Yol Analiz";
            this.btnTripInfo.UseVisualStyleBackColor = false;
            // 
            // btnConnectionSettings
            // 
            this.btnConnectionSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnConnectionSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnConnectionSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnConnectionSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnConnectionSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectionSettings.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectionSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnConnectionSettings.Image")));
            this.btnConnectionSettings.Location = new System.Drawing.Point(56, 21);
            this.btnConnectionSettings.Name = "btnConnectionSettings";
            this.btnConnectionSettings.Size = new System.Drawing.Size(318, 40);
            this.btnConnectionSettings.TabIndex = 5;
            this.btnConnectionSettings.TabStop = false;
            this.btnConnectionSettings.Text = "Bağlantı Ayarları";
            this.btnConnectionSettings.UseVisualStyleBackColor = false;
            this.btnConnectionSettings.Click += new System.EventHandler(this.BtnConnectionSettings_Click);
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
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(380, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(50, 259);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(50, 259);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // LMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "LMenu";
            this.Size = new System.Drawing.Size(430, 308);
            this.panel1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnConnectionSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnTripInfo;
        private System.Windows.Forms.Button btnExitPage;
        private System.Windows.Forms.Button btnTechSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
