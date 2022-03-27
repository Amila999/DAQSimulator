﻿namespace SensorApplication
{
    partial class DAQSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAQSimulator));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNextSamplingTime = new System.Windows.Forms.TextBox();
            this.btnGetSampling = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopSampling = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLoggingOnFile = new System.Windows.Forms.Button();
            this.txtNextLoggingTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sensorValues = new System.Windows.Forms.Label();
            this.txtSensorNames = new System.Windows.Forms.Label();
            this.txtAnalogSensor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numDAQResolution = new System.Windows.Forms.Label();
            this.txtDAQResolution = new System.Windows.Forms.Label();
            this.numUpperVoltage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numLowerVoltage = new System.Windows.Forms.Label();
            this.txtDAQvoltage = new System.Windows.Forms.Label();
            this.numDigitalSensorDevices = new System.Windows.Forms.Label();
            this.numAnalogSensorDevices = new System.Windows.Forms.Label();
            this.txtDigitalSensor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Sampling Time (Sec)";
            // 
            // txtNextSamplingTime
            // 
            this.txtNextSamplingTime.Location = new System.Drawing.Point(141, 27);
            this.txtNextSamplingTime.Name = "txtNextSamplingTime";
            this.txtNextSamplingTime.Size = new System.Drawing.Size(53, 20);
            this.txtNextSamplingTime.TabIndex = 2;
            this.txtNextSamplingTime.Tag = "";
            this.txtNextSamplingTime.Text = "0.9";
            this.txtNextSamplingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetSampling
            // 
            this.btnGetSampling.Location = new System.Drawing.Point(36, 64);
            this.btnGetSampling.Name = "btnGetSampling";
            this.btnGetSampling.Size = new System.Drawing.Size(63, 38);
            this.btnGetSampling.TabIndex = 3;
            this.btnGetSampling.Text = "Start Sampling";
            this.btnGetSampling.UseVisualStyleBackColor = true;
            this.btnGetSampling.Click += new System.EventHandler(this.btnGetSampling_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStopSampling);
            this.groupBox1.Controls.Add(this.btnGetSampling);
            this.groupBox1.Controls.Add(this.txtNextSamplingTime);
            this.groupBox1.Location = new System.Drawing.Point(54, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // btnStopSampling
            // 
            this.btnStopSampling.Location = new System.Drawing.Point(156, 64);
            this.btnStopSampling.Name = "btnStopSampling";
            this.btnStopSampling.Size = new System.Drawing.Size(63, 38);
            this.btnStopSampling.TabIndex = 3;
            this.btnStopSampling.Text = "Stop Sampling";
            this.btnStopSampling.UseVisualStyleBackColor = true;
            this.btnStopSampling.Click += new System.EventHandler(this.btnStopSampling_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoggingOnFile);
            this.groupBox2.Controls.Add(this.txtNextLoggingTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(54, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // btnLoggingOnFile
            // 
            this.btnLoggingOnFile.Location = new System.Drawing.Point(72, 71);
            this.btnLoggingOnFile.Name = "btnLoggingOnFile";
            this.btnLoggingOnFile.Size = new System.Drawing.Size(92, 23);
            this.btnLoggingOnFile.TabIndex = 2;
            this.btnLoggingOnFile.Text = "Logging on File";
            this.btnLoggingOnFile.UseVisualStyleBackColor = true;
            this.btnLoggingOnFile.Click += new System.EventHandler(this.LoggingOnFile_Click);
            // 
            // txtNextLoggingTime
            // 
            this.txtNextLoggingTime.Location = new System.Drawing.Point(141, 26);
            this.txtNextLoggingTime.Name = "txtNextLoggingTime";
            this.txtNextLoggingTime.Size = new System.Drawing.Size(53, 20);
            this.txtNextLoggingTime.TabIndex = 1;
            this.txtNextLoggingTime.Tag = "";
            this.txtNextLoggingTime.Text = "39";
            this.txtNextLoggingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Next Logging Time (Sec)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sensorValues);
            this.groupBox3.Controls.Add(this.txtSensorNames);
            this.groupBox3.Location = new System.Drawing.Point(335, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 485);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Values";
            // 
            // sensorValues
            // 
            this.sensorValues.AutoSize = true;
            this.sensorValues.Location = new System.Drawing.Point(145, 50);
            this.sensorValues.Name = "sensorValues";
            this.sensorValues.Size = new System.Drawing.Size(72, 13);
            this.sensorValues.TabIndex = 17;
            this.sensorValues.Text = "sensor values";
            // 
            // txtSensorNames
            // 
            this.txtSensorNames.AutoSize = true;
            this.txtSensorNames.Location = new System.Drawing.Point(24, 50);
            this.txtSensorNames.Name = "txtSensorNames";
            this.txtSensorNames.Size = new System.Drawing.Size(42, 13);
            this.txtSensorNames.TabIndex = 17;
            this.txtSensorNames.Text = "amount";
            // 
            // txtAnalogSensor
            // 
            this.txtAnalogSensor.AutoSize = true;
            this.txtAnalogSensor.Location = new System.Drawing.Point(15, 30);
            this.txtAnalogSensor.Name = "txtAnalogSensor";
            this.txtAnalogSensor.Size = new System.Drawing.Size(118, 13);
            this.txtAnalogSensor.TabIndex = 7;
            this.txtAnalogSensor.Text = "Analog Sensor Devices";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numDAQResolution);
            this.groupBox4.Controls.Add(this.txtDAQResolution);
            this.groupBox4.Controls.Add(this.numUpperVoltage);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numLowerVoltage);
            this.groupBox4.Controls.Add(this.txtDAQvoltage);
            this.groupBox4.Controls.Add(this.numDigitalSensorDevices);
            this.groupBox4.Controls.Add(this.numAnalogSensorDevices);
            this.groupBox4.Controls.Add(this.txtDigitalSensor);
            this.groupBox4.Controls.Add(this.txtAnalogSensor);
            this.groupBox4.Location = new System.Drawing.Point(54, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 139);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informations";
            // 
            // numDAQResolution
            // 
            this.numDAQResolution.AutoSize = true;
            this.numDAQResolution.Location = new System.Drawing.Point(129, 94);
            this.numDAQResolution.Name = "numDAQResolution";
            this.numDAQResolution.Size = new System.Drawing.Size(33, 13);
            this.numDAQResolution.TabIndex = 16;
            this.numDAQResolution.Text = "value";
            this.numDAQResolution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDAQResolution
            // 
            this.txtDAQResolution.AutoSize = true;
            this.txtDAQResolution.Location = new System.Drawing.Point(15, 94);
            this.txtDAQResolution.Name = "txtDAQResolution";
            this.txtDAQResolution.Size = new System.Drawing.Size(108, 13);
            this.txtDAQResolution.TabIndex = 15;
            this.txtDAQResolution.Text = "DAQ Resolution (bits)";
            // 
            // numUpperVoltage
            // 
            this.numUpperVoltage.AutoSize = true;
            this.numUpperVoltage.Location = new System.Drawing.Point(164, 72);
            this.numUpperVoltage.Name = "numUpperVoltage";
            this.numUpperVoltage.Size = new System.Drawing.Size(21, 13);
            this.numUpperVoltage.TabIndex = 14;
            this.numUpperVoltage.Text = "val";
            this.numUpperVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "V";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "to";
            // 
            // numLowerVoltage
            // 
            this.numLowerVoltage.AutoSize = true;
            this.numLowerVoltage.Location = new System.Drawing.Point(126, 72);
            this.numLowerVoltage.Name = "numLowerVoltage";
            this.numLowerVoltage.Size = new System.Drawing.Size(21, 13);
            this.numLowerVoltage.TabIndex = 12;
            this.numLowerVoltage.Text = "val";
            this.numLowerVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDAQvoltage
            // 
            this.txtDAQvoltage.AutoSize = true;
            this.txtDAQvoltage.Location = new System.Drawing.Point(15, 72);
            this.txtDAQvoltage.Name = "txtDAQvoltage";
            this.txtDAQvoltage.Size = new System.Drawing.Size(96, 13);
            this.txtDAQvoltage.TabIndex = 11;
            this.txtDAQvoltage.Text = "DAQ Input Voltage";
            // 
            // numDigitalSensorDevices
            // 
            this.numDigitalSensorDevices.AutoSize = true;
            this.numDigitalSensorDevices.Location = new System.Drawing.Point(155, 50);
            this.numDigitalSensorDevices.Name = "numDigitalSensorDevices";
            this.numDigitalSensorDevices.Size = new System.Drawing.Size(42, 13);
            this.numDigitalSensorDevices.TabIndex = 10;
            this.numDigitalSensorDevices.Text = "amount";
            // 
            // numAnalogSensorDevices
            // 
            this.numAnalogSensorDevices.AutoSize = true;
            this.numAnalogSensorDevices.Location = new System.Drawing.Point(155, 30);
            this.numAnalogSensorDevices.Name = "numAnalogSensorDevices";
            this.numAnalogSensorDevices.Size = new System.Drawing.Size(42, 13);
            this.numAnalogSensorDevices.TabIndex = 9;
            this.numAnalogSensorDevices.Text = "amount";
            // 
            // txtDigitalSensor
            // 
            this.txtDigitalSensor.AutoSize = true;
            this.txtDigitalSensor.Location = new System.Drawing.Point(15, 50);
            this.txtDigitalSensor.Name = "txtDigitalSensor";
            this.txtDigitalSensor.Size = new System.Drawing.Size(114, 13);
            this.txtDigitalSensor.TabIndex = 8;
            this.txtDigitalSensor.Text = "Digital Sensor Devices";
            // 
            // DAQSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(647, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DAQSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAQSimulator";
            this.Load += new System.EventHandler(this.DAQSimulator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSampling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoggingOnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtAnalogSensor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label txtDigitalSensor;
        private System.Windows.Forms.Label txtDAQvoltage;
        public System.Windows.Forms.Label numDigitalSensorDevices;
        public System.Windows.Forms.Label numAnalogSensorDevices;
        public System.Windows.Forms.Label numLowerVoltage;
        public System.Windows.Forms.Label numUpperVoltage;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label numDAQResolution;
        private System.Windows.Forms.Label txtDAQResolution;
        public System.Windows.Forms.Label txtSensorNames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label sensorValues;
        public System.Windows.Forms.TextBox txtNextSamplingTime;
        private System.Windows.Forms.Button btnStopSampling;
        public System.Windows.Forms.TextBox txtNextLoggingTime;
    }
}