namespace ASKAR_CONTROL_PANEL
{
    partial class RMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInternet = new System.Windows.Forms.Button();
            this.btnMediaPlayer = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnGraphs = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 1;
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInternet);
            this.panel2.Controls.Add(this.btnMediaPlayer);
            this.panel2.Controls.Add(this.btnMap);
            this.panel2.Controls.Add(this.btnGraphs);
            this.panel2.Controls.Add(this.flowLayoutPanel3);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 259);
            this.panel2.TabIndex = 2;
            // 
            // btnInternet
            // 
            this.btnInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnInternet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnInternet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnInternet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnInternet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternet.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternet.Image = ((System.Drawing.Image)(resources.GetObject("btnInternet.Image")));
            this.btnInternet.Location = new System.Drawing.Point(56, 159);
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(318, 40);
            this.btnInternet.TabIndex = 9;
            this.btnInternet.TabStop = false;
            this.btnInternet.Text = "Internet";
            this.btnInternet.UseVisualStyleBackColor = false;
            this.btnInternet.Click += new System.EventHandler(this.BtnInternet_Click);
            // 
            // btnMediaPlayer
            // 
            this.btnMediaPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMediaPlayer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMediaPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMediaPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMediaPlayer.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaPlayer.Image = ((System.Drawing.Image)(resources.GetObject("btnMediaPlayer.Image")));
            this.btnMediaPlayer.Location = new System.Drawing.Point(56, 113);
            this.btnMediaPlayer.Name = "btnMediaPlayer";
            this.btnMediaPlayer.Size = new System.Drawing.Size(318, 40);
            this.btnMediaPlayer.TabIndex = 8;
            this.btnMediaPlayer.TabStop = false;
            this.btnMediaPlayer.Text = "Medya Çalar";
            this.btnMediaPlayer.UseVisualStyleBackColor = false;
            this.btnMediaPlayer.Click += new System.EventHandler(this.BtnMediaPlayer_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMap.Image = ((System.Drawing.Image)(resources.GetObject("btnMap.Image")));
            this.btnMap.Location = new System.Drawing.Point(56, 67);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(318, 40);
            this.btnMap.TabIndex = 7;
            this.btnMap.TabStop = false;
            this.btnMap.Text = "Harita";
            this.btnMap.UseVisualStyleBackColor = false;
            this.btnMap.Click += new System.EventHandler(this.BtnMap_Click);
            // 
            // btnGraphs
            // 
            this.btnGraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGraphs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.btnGraphs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnGraphs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGraphs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraphs.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphs.Image = ((System.Drawing.Image)(resources.GetObject("btnGraphs.Image")));
            this.btnGraphs.Location = new System.Drawing.Point(56, 21);
            this.btnGraphs.Name = "btnGraphs";
            this.btnGraphs.Size = new System.Drawing.Size(318, 40);
            this.btnGraphs.TabIndex = 6;
            this.btnGraphs.TabStop = false;
            this.btnGraphs.Text = "Grafikler";
            this.btnGraphs.UseVisualStyleBackColor = false;
            this.btnGraphs.Click += new System.EventHandler(this.BtnGraphs_Click);
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
            // RMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "RMenu";
            this.Size = new System.Drawing.Size(430, 308);
            this.panel1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGraphs;
        private System.Windows.Forms.Button btnInternet;
        private System.Windows.Forms.Button btnMediaPlayer;
        private System.Windows.Forms.Button btnMap;
    }
}
