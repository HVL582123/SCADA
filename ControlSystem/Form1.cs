using System;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Opc.UaFx.Client;

namespace ControlSystem
{
    public partial class Form1 : Form
    {
        double temp;
        double u;
        
        double Kp = 1.2;
        double Ti = 88;
        double Td = 0;

        double Ts = 0.1;
        double Tenv = 21.5;

        AirHeaterModel AHModel = new AirHeaterModel();
        PIDController pidController = new PIDController();
        
        OpcClient client;
        string tag;

        public Form1()
        {
            InitializeComponent();
            temp = Tenv;
            textBoxSetpoint.Text = Tenv.ToString();
            textBoxKp.Text = Kp.ToString();
            textBoxTi.Text = Ti.ToString();
            textBoxTs.Text = Ts.ToString();
            //textBoxDer.Text = Td.ToString();
            textBoxTenv.Text = Tenv.ToString();

            // Chart measurement
            chartMeasurement.Series.Clear();
            chartMeasurement.Series.Add("ProcessValue");
            chartMeasurement.Series.Add("Setpoint");

            chartMeasurement.Series["ProcessValue"].ChartType = SeriesChartType.Line;
            chartMeasurement.Series["Setpoint"].ChartType = SeriesChartType.Line;

            chartMeasurement.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartMeasurement.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartMeasurement.ChartAreas[0].BackColor = Color.DarkSlateGray;

            textBoxOutput.Text = temp.ToString("0.##");
            textBoxControlValue.Text = u.ToString("0.##");

            chartMeasurement.Series["ProcessValue"].Points.AddY(temp);
            chartMeasurement.Series["Setpoint"].Points.AddY(Convert.ToDouble(textBoxSetpoint.Text));

            ChartArea area1 = chartMeasurement.ChartAreas[0];
            area1.AxisY.Minimum = 20;
            area1.AxisY.Maximum = 40;

            //Chart control value
            chartControlValue.Series.Clear();
            chartControlValue.Series.Add("ControlValue");
            chartControlValue.Series["ControlValue"].ChartType= SeriesChartType.Line;

            chartControlValue.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartControlValue.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartControlValue.ChartAreas[0].BackColor = Color.DarkSlateGray;
            chartControlValue.Series["ControlValue"].Color = Color.LightGoldenrodYellow;

            chartControlValue.Series["ControlValue"].Points.AddY(u);

            ChartArea area2 = chartControlValue.ChartAreas[0];
            area2.AxisY.Minimum= 0;
            area2.AxisY.Maximum= 5;

            timer1.Interval = Convert.ToInt32(Ts*1000);
            timer2.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temp = AHModel.AHModelCalc(Tenv,temp, u, Ts);

            pidController.setPoint = Convert.ToDouble(textBoxSetpoint.Text);
            Ts = Convert.ToDouble(textBoxTs.Text);
            Kp = Convert.ToDouble(textBoxKp.Text);
            Ti = Convert.ToDouble(textBoxTi.Text);

            u = pidController.PIController(temp, Kp, Ti, Ts);

            textBoxOutput.Text = temp.ToString("0.##");
            textBoxControlValue.Text = u.ToString("0.##");

            chartMeasurement.Series["ProcessValue"].Points.AddY(temp);
            chartMeasurement.Series["Setpoint"].Points.AddY(Convert.ToDouble(textBoxSetpoint.Text));

            chartControlValue.Series["ControlValue"].Points.AddY(u);

            timer1.Interval = Convert.ToInt32(Ts * 1000);
        }

        private void btnUpdatePID_Click(object sender, EventArgs e)
        {
            Kp = Convert.ToDouble(textBoxKp.Text);
            Ti = Convert.ToDouble(textBoxTi.Text);
           // Td = Convert.ToDouble(textBoxDer.Text);
            Ts = Convert.ToDouble(textBoxTs.Text);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            client.WriteNode(tag, temp);
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            string OPCAdress = ConfigurationSettings.AppSettings["OPCServerAdress"];
            client = new OpcClient(OPCAdress);
            tag = ConfigurationSettings.AppSettings["Tag1"];
            try
            {
                client.Connect();

                timer2.Start();
                timer1.Start();

                buttonStart.Hide();
                buttonStop.Show();

            }
            catch (Opc.UaFx.OpcException ex)
            {
                MessageBox.Show("Failed to connect to OPC UA server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            if (client != null)
            {
                client.Disconnect();
            }
            buttonStop.Hide();
            buttonStart.Show();
        }
    }
}
