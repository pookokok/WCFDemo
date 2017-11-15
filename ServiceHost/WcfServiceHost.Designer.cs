namespace WcfServiceHost
{
    partial class WcfServiceHost
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
            this.serviceNotifier = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgServiceInfo = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceNotifier
            // 
            this.serviceNotifier.Text = "Service";
            this.serviceNotifier.Visible = true;
            this.serviceNotifier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.serviceNotifier_MouseDoubleClick_1);
            // 
            // dgServiceInfo
            // 
            this.dgServiceInfo.AllowUserToAddRows = false;
            this.dgServiceInfo.AllowUserToDeleteRows = false;
            this.dgServiceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServiceInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.ServiceStatus});
            this.dgServiceInfo.Location = new System.Drawing.Point(0, -3);
            this.dgServiceInfo.Name = "dgServiceInfo";
            this.dgServiceInfo.ReadOnly = true;
            this.dgServiceInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgServiceInfo.Size = new System.Drawing.Size(581, 205);
            this.dgServiceInfo.TabIndex = 5;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 150;
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.HeaderText = "Status";
            this.ServiceStatus.Name = "ServiceStatus";
            this.ServiceStatus.ReadOnly = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(223, 249);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 32);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Services";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // WcfServiceHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 340);
            this.Controls.Add(this.dgServiceInfo);
            this.Controls.Add(this.btnStop);
            this.Name = "WcfServiceHost";
            this.Text = "ServiceHost";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WcfServiceHost_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon serviceNotifier;
        private System.Windows.Forms.DataGridView dgServiceInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceStatus;
        private System.Windows.Forms.Button btnStop;
    }
}

