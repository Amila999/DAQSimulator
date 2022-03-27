using System;
using System.Windows.Forms;

namespace SensorApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            int counter, maxSid = 16;
            string sTxt;
            // Create an array of sensor objects
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            // Get the object values as a string
            for (counter = 0; counter < maxSid; counter++)
            {
                sTxt = sObj[counter].GetValue().ToString("F3");
            }
        }
    }
}
