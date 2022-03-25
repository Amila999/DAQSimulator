namespace SensorApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnalogSensorDevices = new System.Windows.Forms.Label();
            this.txtDigitalSensorDevices = new System.Windows.Forms.Label();
            this.txtDAQInputVoltage = new System.Windows.Forms.Label();
            this.txtDAQResolution = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analog Sensor Devices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digital Sensor Devices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DAQ Input Voltage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DAQ Resolution (bits)";
            // 
            // txtAnalogSensorDevices
            // 
            this.txtAnalogSensorDevices.AutoSize = true;
            this.txtAnalogSensorDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnalogSensorDevices.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtAnalogSensorDevices.Location = new System.Drawing.Point(202, 140);
            this.txtAnalogSensorDevices.Name = "txtAnalogSensorDevices";
            this.txtAnalogSensorDevices.Size = new System.Drawing.Size(24, 25);
            this.txtAnalogSensorDevices.TabIndex = 5;
            this.txtAnalogSensorDevices.Text = "5";
            // 
            // txtDigitalSensorDevices
            // 
            this.txtDigitalSensorDevices.AutoSize = true;
            this.txtDigitalSensorDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDigitalSensorDevices.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDigitalSensorDevices.Location = new System.Drawing.Point(202, 215);
            this.txtDigitalSensorDevices.Name = "txtDigitalSensorDevices";
            this.txtDigitalSensorDevices.Size = new System.Drawing.Size(24, 25);
            this.txtDigitalSensorDevices.TabIndex = 6;
            this.txtDigitalSensorDevices.Text = "2";
            this.txtDigitalSensorDevices.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtDAQInputVoltage
            // 
            this.txtDAQInputVoltage.AutoSize = true;
            this.txtDAQInputVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAQInputVoltage.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDAQInputVoltage.Location = new System.Drawing.Point(518, 140);
            this.txtDAQInputVoltage.Name = "txtDAQInputVoltage";
            this.txtDAQInputVoltage.Size = new System.Drawing.Size(96, 25);
            this.txtDAQInputVoltage.TabIndex = 7;
            this.txtDAQInputVoltage.Text = "0V to 5V";
            // 
            // txtDAQResolution
            // 
            this.txtDAQResolution.AutoSize = true;
            this.txtDAQResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDAQResolution.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtDAQResolution.Location = new System.Drawing.Point(518, 215);
            this.txtDAQResolution.Name = "txtDAQResolution";
            this.txtDAQResolution.Size = new System.Drawing.Size(24, 25);
            this.txtDAQResolution.TabIndex = 8;
            this.txtDAQResolution.Text = "6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(271, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(682, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDAQResolution);
            this.Controls.Add(this.txtDAQInputVoltage);
            this.Controls.Add(this.txtDigitalSensorDevices);
            this.Controls.Add(this.txtAnalogSensorDevices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtAnalogSensorDevices;
        private System.Windows.Forms.Label txtDigitalSensorDevices;
        private System.Windows.Forms.Label txtDAQInputVoltage;
        private System.Windows.Forms.Label txtDAQResolution;
        private System.Windows.Forms.Button button1;
    }
}

