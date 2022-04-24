
namespace Opc.Ua.Server.Controls
{
    partial class Home
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
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelServerStartingTime = new System.Windows.Forms.Label();
            this.currentTimeValue = new System.Windows.Forms.Label();
            this.labelServerCurrentTime = new System.Windows.Forms.Label();
            this.httpsAddressValue = new System.Windows.Forms.Label();
            this.httpsUaAddressLabel = new System.Windows.Forms.Label();
            this.tcpAddressValue = new System.Windows.Forms.Label();
            this.tcpUaAddressLabel = new System.Windows.Forms.Label();
            this.statusValue = new System.Windows.Forms.Label();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(576, 151);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(64, 17);
            this.labelDateTime.TabIndex = 0;
            this.labelDateTime.Text = "00:00:00";
            // 
            // labelServerStartingTime
            // 
            this.labelServerStartingTime.AutoSize = true;
            this.labelServerStartingTime.Location = new System.Drawing.Point(377, 151);
            this.labelServerStartingTime.Name = "labelServerStartingTime";
            this.labelServerStartingTime.Size = new System.Drawing.Size(174, 17);
            this.labelServerStartingTime.TabIndex = 0;
            this.labelServerStartingTime.Text = "SERVER STARTING TIME";
            // 
            // currentTimeValue
            // 
            this.currentTimeValue.AutoSize = true;
            this.currentTimeValue.Location = new System.Drawing.Point(576, 186);
            this.currentTimeValue.Name = "currentTimeValue";
            this.currentTimeValue.Size = new System.Drawing.Size(64, 17);
            this.currentTimeValue.TabIndex = 0;
            this.currentTimeValue.Text = "00:00:00";
            // 
            // labelServerCurrentTime
            // 
            this.labelServerCurrentTime.AutoSize = true;
            this.labelServerCurrentTime.Location = new System.Drawing.Point(377, 186);
            this.labelServerCurrentTime.Name = "labelServerCurrentTime";
            this.labelServerCurrentTime.Size = new System.Drawing.Size(175, 17);
            this.labelServerCurrentTime.TabIndex = 0;
            this.labelServerCurrentTime.Text = "SERVER CURRENT TIME:";
            // 
            // httpsAddressValue
            // 
            this.httpsAddressValue.AutoSize = true;
            this.httpsAddressValue.Location = new System.Drawing.Point(576, 221);
            this.httpsAddressValue.Name = "httpsAddressValue";
            this.httpsAddressValue.Size = new System.Drawing.Size(124, 17);
            this.httpsAddressValue.TabIndex = 0;
            this.httpsAddressValue.Text = "HTTPS ADDRESS";
            // 
            // httpsUaAddressLabel
            // 
            this.httpsUaAddressLabel.AutoSize = true;
            this.httpsUaAddressLabel.Location = new System.Drawing.Point(377, 221);
            this.httpsUaAddressLabel.Name = "httpsUaAddressLabel";
            this.httpsUaAddressLabel.Size = new System.Drawing.Size(151, 17);
            this.httpsUaAddressLabel.TabIndex = 0;
            this.httpsUaAddressLabel.Text = "HTTPS UA ADDRESS:";
            // 
            // tcpAddressValue
            // 
            this.tcpAddressValue.AutoSize = true;
            this.tcpAddressValue.Location = new System.Drawing.Point(576, 257);
            this.tcpAddressValue.Name = "tcpAddressValue";
            this.tcpAddressValue.Size = new System.Drawing.Size(105, 17);
            this.tcpAddressValue.TabIndex = 0;
            this.tcpAddressValue.Text = "TCP ADDRESS";
            // 
            // tcpUaAddressLabel
            // 
            this.tcpUaAddressLabel.AutoSize = true;
            this.tcpUaAddressLabel.Location = new System.Drawing.Point(377, 257);
            this.tcpUaAddressLabel.Name = "tcpUaAddressLabel";
            this.tcpUaAddressLabel.Size = new System.Drawing.Size(132, 17);
            this.tcpUaAddressLabel.TabIndex = 0;
            this.tcpUaAddressLabel.Text = "TCP UA ADDRESS:";
            // 
            // statusValue
            // 
            this.statusValue.AutoSize = true;
            this.statusValue.Location = new System.Drawing.Point(576, 289);
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(72, 17);
            this.statusValue.TabIndex = 0;
            this.statusValue.Text = "RUNNING";
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.Location = new System.Drawing.Point(377, 289);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(127, 17);
            this.serverStatusLabel.TabIndex = 0;
            this.serverStatusLabel.Text = "SERVER STATUS:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.statusValue);
            this.Controls.Add(this.tcpUaAddressLabel);
            this.Controls.Add(this.tcpAddressValue);
            this.Controls.Add(this.httpsUaAddressLabel);
            this.Controls.Add(this.httpsAddressValue);
            this.Controls.Add(this.labelServerCurrentTime);
            this.Controls.Add(this.currentTimeValue);
            this.Controls.Add(this.labelServerStartingTime);
            this.Controls.Add(this.labelDateTime);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(952, 587);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelServerStartingTime;
        private System.Windows.Forms.Label currentTimeValue;
        private System.Windows.Forms.Label labelServerCurrentTime;
        private System.Windows.Forms.Label httpsAddressValue;
        private System.Windows.Forms.Label httpsUaAddressLabel;
        private System.Windows.Forms.Label tcpAddressValue;
        private System.Windows.Forms.Label tcpUaAddressLabel;
        private System.Windows.Forms.Label statusValue;
        private System.Windows.Forms.Label serverStatusLabel;
    }
}
