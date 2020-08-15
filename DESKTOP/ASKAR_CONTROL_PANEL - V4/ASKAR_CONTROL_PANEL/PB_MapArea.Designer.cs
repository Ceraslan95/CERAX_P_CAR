namespace ASKAR_CONTROL_PANEL
{
    partial class PB_MapArea
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
            this.p_mapView = new System.Windows.Forms.Panel();
            this.WBrowser = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.p_mapView.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_mapView
            // 
            this.p_mapView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_mapView.Controls.Add(this.WBrowser);
            this.p_mapView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_mapView.Location = new System.Drawing.Point(0, 0);
            this.p_mapView.Name = "p_mapView";
            this.p_mapView.Size = new System.Drawing.Size(1339, 352);
            this.p_mapView.TabIndex = 2;
            // 
            // WBrowser
            // 
            this.WBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBrowser.Location = new System.Drawing.Point(0, 0);
            this.WBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBrowser.Name = "WBrowser";
            this.WBrowser.ScriptErrorsSuppressed = true;
            this.WBrowser.Size = new System.Drawing.Size(1339, 352);
            this.WBrowser.TabIndex = 0;
            this.WBrowser.TabStop = false;
            this.WBrowser.Url = new System.Uri("http://maps.google.com", System.UriKind.Absolute);
            // 
            // PB_MapArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.p_mapView);
            this.Name = "PB_MapArea";
            this.Size = new System.Drawing.Size(1339, 352);
            this.p_mapView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_mapView;
        private System.Windows.Forms.WebBrowser WBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
