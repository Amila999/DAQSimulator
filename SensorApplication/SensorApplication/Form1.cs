using System;
using System.Windows.Forms;

namespace SensorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string analogS;
        string digitalS;

        public void runLoop(int analogSCount, int digitalSCount)
        {
            for (int i = 0; i < analogSCount; i++)
            {
                analogS = analogS + "Analog Sensor " + (i + 1) + "\n\n";
            } 
            
            for (int i = 0; i < digitalSCount; i++)
            {
                digitalS = digitalS + "Digital Sensor " + (i + 1) + "\n\n";
            }
            dAQSimulator.txtSensorNames.Text = analogS + "\n\n" + digitalS;
        }

        public Form1(DAQSimulator fr)
        {
            InitializeComponent();
            dAQSimulator = fr;
        }

        DAQSimulator dAQSimulator = new DAQSimulator();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dAQSimulator.Show();
            dAQSimulator.numAnalogSensorDevices.Text = txtAnalogSensorDevices.Text;
            dAQSimulator.numDigitalSensorDevices.Text = txtDigitalSensorDevices.Text;
            dAQSimulator.numLowerVoltage.Text = txtLowerVoltage.Text;
            dAQSimulator.numUpperVoltage.Text = txtUpperVoltage.Text;
            dAQSimulator.numDAQResolution.Text = txtDAQResolution.Text;

            //Generate sensor names string

            int analogSensorCount = int.Parse(txtAnalogSensorDevices.Text);
            int digitalSensorCount = int.Parse(txtDigitalSensorDevices.Text);

            runLoop(analogSensorCount, digitalSensorCount);

            this.Hide();

        }

        private void txtAnalogSensorDevices_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
