namespace DataLoggerOPCUA
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtConnect = new System.Windows.Forms.TextBox();
            this.txtTagId = new System.Windows.Forms.TextBox();
            this.labelOPCString = new System.Windows.Forms.Label();
            this.labelTagName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTagValue = new System.Windows.Forms.TextBox();
            this.lblTagValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(211, 153);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(108, 39);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(211, 153);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(108, 39);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtConnect
            // 
            this.txtConnect.Location = new System.Drawing.Point(12, 40);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(333, 26);
            this.txtConnect.TabIndex = 1;
            this.txtConnect.Text = "opc.tcp://osl-0808:62640/IntegrationObjects/ServerSimulator";
            // 
            // txtTagId
            // 
            this.txtTagId.Location = new System.Drawing.Point(12, 105);
            this.txtTagId.Name = "txtTagId";
            this.txtTagId.Size = new System.Drawing.Size(167, 26);
            this.txtTagId.TabIndex = 1;
            this.txtTagId.Text = "ns=2;s=Tag7";
            // 
            // labelOPCString
            // 
            this.labelOPCString.AutoSize = true;
            this.labelOPCString.Location = new System.Drawing.Point(8, 17);
            this.labelOPCString.Name = "labelOPCString";
            this.labelOPCString.Size = new System.Drawing.Size(127, 20);
            this.labelOPCString.TabIndex = 2;
            this.labelOPCString.Text = "OPC Connection";
            // 
            // labelTagName
            // 
            this.labelTagName.AutoSize = true;
            this.labelTagName.Location = new System.Drawing.Point(8, 82);
            this.labelTagName.Name = "labelTagName";
            this.labelTagName.Size = new System.Drawing.Size(36, 20);
            this.labelTagName.TabIndex = 3;
            this.labelTagName.Text = "Tag";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTagValue
            // 
            this.txtTagValue.Enabled = false;
            this.txtTagValue.Location = new System.Drawing.Point(211, 105);
            this.txtTagValue.Name = "txtTagValue";
            this.txtTagValue.Size = new System.Drawing.Size(134, 26);
            this.txtTagValue.TabIndex = 1;
            // 
            // lblTagValue
            // 
            this.lblTagValue.AutoSize = true;
            this.lblTagValue.Location = new System.Drawing.Point(207, 82);
            this.lblTagValue.Name = "lblTagValue";
            this.lblTagValue.Size = new System.Drawing.Size(130, 20);
            this.lblTagValue.TabIndex = 3;
            this.lblTagValue.Text = "Latest Tag Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(357, 210);
            this.Controls.Add(this.lblTagValue);
            this.Controls.Add(this.labelTagName);
            this.Controls.Add(this.labelOPCString);
            this.Controls.Add(this.txtTagValue);
            this.Controls.Add(this.txtTagId);
            this.Controls.Add(this.txtConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Name = "Form1";
            this.Text = "SQL Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtConnect;
        private System.Windows.Forms.TextBox txtTagId;
        private System.Windows.Forms.Label labelOPCString;
        private System.Windows.Forms.Label labelTagName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTagValue;
        private System.Windows.Forms.Label lblTagValue;
    }
}

