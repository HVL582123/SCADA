namespace ControlSystem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxTi = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartMeasurement = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxKp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSetpoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxControlValue = new System.Windows.Forms.TextBox();
            this.controlValueLabel = new System.Windows.Forms.Label();
            this.textBoxTenv = new System.Windows.Forms.TextBox();
            this.labelTenv = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.airHeaterPage = new System.Windows.Forms.TabPage();
            this.chartControlValue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.PIDPage = new System.Windows.Forms.TabPage();
            this.btnUpdatePID = new System.Windows.Forms.Button();
            this.textBoxTs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurement)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.airHeaterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlValue)).BeginInit();
            this.PIDPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTi
            // 
            this.textBoxTi.Location = new System.Drawing.Point(153, 68);
            this.textBoxTi.Name = "textBoxTi";
            this.textBoxTi.Size = new System.Drawing.Size(100, 26);
            this.textBoxTi.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(922, 166);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(100, 26);
            this.textBoxOutput.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(26, 68);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(81, 20);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "I - Integral";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(906, 143);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(139, 20);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Process Output °C";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartMeasurement
            // 
            this.chartMeasurement.BackColor = System.Drawing.Color.Transparent;
            this.chartMeasurement.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartMeasurement.BorderlineColor = System.Drawing.Color.Black;
            this.chartMeasurement.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartMeasurement.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartMeasurement.Legends.Add(legend1);
            this.chartMeasurement.Location = new System.Drawing.Point(136, 32);
            this.chartMeasurement.Name = "chartMeasurement";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMeasurement.Series.Add(series1);
            this.chartMeasurement.Size = new System.Drawing.Size(762, 378);
            this.chartMeasurement.TabIndex = 3;
            this.chartMeasurement.Text = "chart1";
            // 
            // textBoxKp
            // 
            this.textBoxKp.Location = new System.Drawing.Point(153, 23);
            this.textBoxKp.Name = "textBoxKp";
            this.textBoxKp.Size = new System.Drawing.Size(100, 26);
            this.textBoxKp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "P - Proportional";
            // 
            // textBoxSetpoint
            // 
            this.textBoxSetpoint.Location = new System.Drawing.Point(15, 166);
            this.textBoxSetpoint.Name = "textBoxSetpoint";
            this.textBoxSetpoint.Size = new System.Drawing.Size(100, 26);
            this.textBoxSetpoint.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Setpoint °C";
            // 
            // textBoxControlValue
            // 
            this.textBoxControlValue.Enabled = false;
            this.textBoxControlValue.Location = new System.Drawing.Point(922, 545);
            this.textBoxControlValue.Name = "textBoxControlValue";
            this.textBoxControlValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxControlValue.TabIndex = 0;
            // 
            // controlValueLabel
            // 
            this.controlValueLabel.AutoSize = true;
            this.controlValueLabel.Location = new System.Drawing.Point(920, 522);
            this.controlValueLabel.Name = "controlValueLabel";
            this.controlValueLabel.Size = new System.Drawing.Size(124, 20);
            this.controlValueLabel.TabIndex = 2;
            this.controlValueLabel.Text = "ControlValue [V]";
            // 
            // textBoxTenv
            // 
            this.textBoxTenv.Enabled = false;
            this.textBoxTenv.Location = new System.Drawing.Point(15, 32);
            this.textBoxTenv.Name = "textBoxTenv";
            this.textBoxTenv.Size = new System.Drawing.Size(100, 26);
            this.textBoxTenv.TabIndex = 4;
            // 
            // labelTenv
            // 
            this.labelTenv.AutoSize = true;
            this.labelTenv.Location = new System.Drawing.Point(10, 9);
            this.labelTenv.Name = "labelTenv";
            this.labelTenv.Size = new System.Drawing.Size(118, 20);
            this.labelTenv.TabIndex = 2;
            this.labelTenv.Text = "Environment °C";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.airHeaterPage);
            this.tabControl1.Controls.Add(this.PIDPage);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 772);
            this.tabControl1.TabIndex = 5;
            // 
            // airHeaterPage
            // 
            this.airHeaterPage.BackColor = System.Drawing.Color.Gainsboro;
            this.airHeaterPage.Controls.Add(this.chartControlValue);
            this.airHeaterPage.Controls.Add(this.buttonStart);
            this.airHeaterPage.Controls.Add(this.textBoxSetpoint);
            this.airHeaterPage.Controls.Add(this.label2);
            this.airHeaterPage.Controls.Add(this.textBoxOutput);
            this.airHeaterPage.Controls.Add(this.textBoxControlValue);
            this.airHeaterPage.Controls.Add(this.controlValueLabel);
            this.airHeaterPage.Controls.Add(this.outputLabel);
            this.airHeaterPage.Controls.Add(this.textBoxTenv);
            this.airHeaterPage.Controls.Add(this.labelTenv);
            this.airHeaterPage.Controls.Add(this.buttonStop);
            this.airHeaterPage.Controls.Add(this.chartMeasurement);
            this.airHeaterPage.Location = new System.Drawing.Point(4, 29);
            this.airHeaterPage.Name = "airHeaterPage";
            this.airHeaterPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.airHeaterPage.Size = new System.Drawing.Size(1054, 739);
            this.airHeaterPage.TabIndex = 0;
            this.airHeaterPage.Text = "Air Heater";
            // 
            // chartControlValue
            // 
            this.chartControlValue.BackColor = System.Drawing.Color.Transparent;
            this.chartControlValue.BorderlineColor = System.Drawing.Color.Black;
            this.chartControlValue.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartControlValue.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartControlValue.Legends.Add(legend2);
            this.chartControlValue.Location = new System.Drawing.Point(136, 418);
            this.chartControlValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartControlValue.Name = "chartControlValue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartControlValue.Series.Add(series2);
            this.chartControlValue.Size = new System.Drawing.Size(762, 303);
            this.chartControlValue.TabIndex = 8;
            this.chartControlValue.Text = "chart1";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonStart.Location = new System.Drawing.Point(922, 686);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Crimson;
            this.buttonStop.Location = new System.Drawing.Point(922, 686);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 35);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // PIDPage
            // 
            this.PIDPage.Controls.Add(this.btnUpdatePID);
            this.PIDPage.Controls.Add(this.textBoxTi);
            this.PIDPage.Controls.Add(this.textBoxKp);
            this.PIDPage.Controls.Add(this.textBoxTs);
            this.PIDPage.Controls.Add(this.label3);
            this.PIDPage.Controls.Add(this.inputLabel);
            this.PIDPage.Controls.Add(this.label1);
            this.PIDPage.Location = new System.Drawing.Point(4, 29);
            this.PIDPage.Name = "PIDPage";
            this.PIDPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.PIDPage.Size = new System.Drawing.Size(1054, 739);
            this.PIDPage.TabIndex = 1;
            this.PIDPage.Text = "PID Settings";
            this.PIDPage.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePID
            // 
            this.btnUpdatePID.Location = new System.Drawing.Point(28, 209);
            this.btnUpdatePID.Name = "btnUpdatePID";
            this.btnUpdatePID.Size = new System.Drawing.Size(87, 37);
            this.btnUpdatePID.TabIndex = 5;
            this.btnUpdatePID.Text = "Update";
            this.btnUpdatePID.UseVisualStyleBackColor = true;
            this.btnUpdatePID.Click += new System.EventHandler(this.btnUpdatePID_Click);
            // 
            // textBoxTs
            // 
            this.textBoxTs.Location = new System.Drawing.Point(153, 130);
            this.textBoxTs.Name = "textBoxTs";
            this.textBoxTs.Size = new System.Drawing.Size(102, 26);
            this.textBoxTs.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ts";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 766);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Control System SCADA";
            ((System.ComponentModel.ISupportInitialize)(this.chartMeasurement)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.airHeaterPage.ResumeLayout(false);
            this.airHeaterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlValue)).EndInit();
            this.PIDPage.ResumeLayout(false);
            this.PIDPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTi;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeasurement;
        private System.Windows.Forms.TextBox textBoxKp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSetpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxControlValue;
        private System.Windows.Forms.Label controlValueLabel;
        private System.Windows.Forms.TextBox textBoxTenv;
        private System.Windows.Forms.Label labelTenv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage airHeaterPage;
        private System.Windows.Forms.TabPage PIDPage;
        private System.Windows.Forms.TextBox textBoxTs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdatePID;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControlValue;
    }
}

