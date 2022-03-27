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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAnalogSensorDevices = new System.Windows.Forms.TextBox();
            this.txtDigitalSensorDevices = new System.Windows.Forms.TextBox();
            this.txtLowerVoltage = new System.Windows.Forms.TextBox();
            this.txtUpperVoltage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDAQResolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analog Sensor Devices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digital Sensor Devices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(226, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DAQ Input Voltage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DAQ Resolution (bits)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(175, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnalogSensorDevices
            // 
            this.txtAnalogSensorDevices.Location = new System.Drawing.Point(158, 93);
            this.txtAnalogSensorDevices.Name = "txtAnalogSensorDevices";
            this.txtAnalogSensorDevices.Size = new System.Drawing.Size(30, 20);
            this.txtAnalogSensorDevices.TabIndex = 12;
            this.txtAnalogSensorDevices.Text = "6";
            this.txtAnalogSensorDevices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDigitalSensorDevices
            // 
            this.txtDigitalSensorDevices.Location = new System.Drawing.Point(158, 174);
            this.txtDigitalSensorDevices.Name = "txtDigitalSensorDevices";
            this.txtDigitalSensorDevices.Size = new System.Drawing.Size(30, 20);
            this.txtDigitalSensorDevices.TabIndex = 13;
            this.txtDigitalSensorDevices.Text = "3";
            this.txtDigitalSensorDevices.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLowerVoltage
            // 
            this.txtLowerVoltage.Location = new System.Drawing.Point(356, 93);
            this.txtLowerVoltage.Name = "txtLowerVoltage";
            this.txtLowerVoltage.Size = new System.Drawing.Size(30, 20);
            this.txtLowerVoltage.TabIndex = 14;
            this.txtLowerVoltage.Text = "0";
            this.txtLowerVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpperVoltage
            // 
            this.txtUpperVoltage.Location = new System.Drawing.Point(414, 93);
            this.txtUpperVoltage.Name = "txtUpperVoltage";
            this.txtUpperVoltage.Size = new System.Drawing.Size(30, 20);
            this.txtUpperVoltage.TabIndex = 15;
            this.txtUpperVoltage.Text = "10";
            this.txtUpperVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "to";
            // 
            // txtDAQResolution
            // 
            this.txtDAQResolution.Location = new System.Drawing.Point(356, 174);
            this.txtDAQResolution.Name = "txtDAQResolution";
            this.txtDAQResolution.Size = new System.Drawing.Size(30, 20);
            this.txtDAQResolution.TabIndex = 17;
            this.txtDAQResolution.Text = "6";
            this.txtDAQResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 289);
            this.Controls.Add(this.txtDAQResolution);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUpperVoltage);
            this.Controls.Add(this.txtLowerVoltage);
            this.Controls.Add(this.txtDigitalSensorDevices);
            this.Controls.Add(this.txtAnalogSensorDevices);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Information Screen";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAnalogSensorDevices;
        private System.Windows.Forms.TextBox txtDigitalSensorDevices;
        private System.Windows.Forms.TextBox txtLowerVoltage;
        private System.Windows.Forms.TextBox txtUpperVoltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDAQResolution;
    }
}

