namespace GigabitCamera
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonExtIo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTriggerStatus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxFrameRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSensorGainMode = new System.Windows.Forms.ComboBox();
            this.comboBoxWorkingEnvironments = new System.Windows.Forms.ComboBox();
            this.buttonNUC = new System.Windows.Forms.Button();
            this.buttonCommunicationControl = new System.Windows.Forms.Button();
            this.buttonImageStreamControl = new System.Windows.Forms.Button();
            this.buttonDeviceSettings = new System.Windows.Forms.Button();
            this.buttonStopPlay = new System.Windows.Forms.Button();
            this.focusControl1 = new GigabitCamera.FocusControl();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelFps = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFrameCounter = new System.Windows.Forms.Label();
            this.labelLostImages = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(989, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Discovery";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(669, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(29, 4);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 20);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.Location = new System.Drawing.Point(165, 6);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(95, 13);
            this.labelConnectionStatus.TabIndex = 3;
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonExtIo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonTriggerStatus);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBoxFrameRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonStopPlay);
            this.groupBox1.Controls.Add(this.focusControl1);
            this.groupBox1.Location = new System.Drawing.Point(687, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 497);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // buttonExtIo
            // 
            this.buttonExtIo.Enabled = false;
            this.buttonExtIo.Location = new System.Drawing.Point(87, 439);
            this.buttonExtIo.Name = "buttonExtIo";
            this.buttonExtIo.Size = new System.Drawing.Size(75, 23);
            this.buttonExtIo.TabIndex = 21;
            this.buttonExtIo.Text = "External I/O";
            this.buttonExtIo.UseVisualStyleBackColor = true;
            this.buttonExtIo.Click += new System.EventHandler(this.buttonExtIo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trigger";
            // 
            // buttonTriggerStatus
            // 
            this.buttonTriggerStatus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonTriggerStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTriggerStatus.ForeColor = System.Drawing.Color.Green;
            this.buttonTriggerStatus.Location = new System.Drawing.Point(54, 441);
            this.buttonTriggerStatus.Name = "buttonTriggerStatus";
            this.buttonTriggerStatus.Size = new System.Drawing.Size(27, 18);
            this.buttonTriggerStatus.TabIndex = 20;
            this.buttonTriggerStatus.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Snapshot...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxFrameRate
            // 
            this.comboBoxFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrameRate.Enabled = false;
            this.comboBoxFrameRate.FormattingEnabled = true;
            this.comboBoxFrameRate.Location = new System.Drawing.Point(182, 22);
            this.comboBoxFrameRate.Name = "comboBoxFrameRate";
            this.comboBoxFrameRate.Size = new System.Drawing.Size(62, 21);
            this.comboBoxFrameRate.TabIndex = 18;
            this.comboBoxFrameRate.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFrameRate_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Frame rate:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Recording";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxSensorGainMode);
            this.groupBox2.Controls.Add(this.comboBoxWorkingEnvironments);
            this.groupBox2.Controls.Add(this.buttonNUC);
            this.groupBox2.Controls.Add(this.buttonCommunicationControl);
            this.groupBox2.Controls.Add(this.buttonImageStreamControl);
            this.groupBox2.Controls.Add(this.buttonDeviceSettings);
            this.groupBox2.Location = new System.Drawing.Point(7, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 258);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GenICam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sensor gain mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Working environments";
            // 
            // comboBoxSensorGainMode
            // 
            this.comboBoxSensorGainMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorGainMode.Enabled = false;
            this.comboBoxSensorGainMode.FormattingEnabled = true;
            this.comboBoxSensorGainMode.Location = new System.Drawing.Point(6, 205);
            this.comboBoxSensorGainMode.Name = "comboBoxSensorGainMode";
            this.comboBoxSensorGainMode.Size = new System.Drawing.Size(261, 21);
            this.comboBoxSensorGainMode.TabIndex = 5;
            this.comboBoxSensorGainMode.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSensorGainMode_SelectionChangeCommitted);
            // 
            // comboBoxWorkingEnvironments
            // 
            this.comboBoxWorkingEnvironments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkingEnvironments.Enabled = false;
            this.comboBoxWorkingEnvironments.FormattingEnabled = true;
            this.comboBoxWorkingEnvironments.Location = new System.Drawing.Point(7, 159);
            this.comboBoxWorkingEnvironments.Name = "comboBoxWorkingEnvironments";
            this.comboBoxWorkingEnvironments.Size = new System.Drawing.Size(261, 21);
            this.comboBoxWorkingEnvironments.TabIndex = 5;
            this.comboBoxWorkingEnvironments.SelectionChangeCommitted += new System.EventHandler(this.comboBoxWorkingEnvironments_SelectionChangeCommitted);
            // 
            // buttonNUC
            // 
            this.buttonNUC.Location = new System.Drawing.Point(6, 107);
            this.buttonNUC.Name = "buttonNUC";
            this.buttonNUC.Size = new System.Drawing.Size(75, 23);
            this.buttonNUC.TabIndex = 4;
            this.buttonNUC.Text = "NUC";
            this.buttonNUC.UseVisualStyleBackColor = true;
            this.buttonNUC.Click += new System.EventHandler(this.buttonNUC_Click);
            // 
            // buttonCommunicationControl
            // 
            this.buttonCommunicationControl.Location = new System.Drawing.Point(6, 19);
            this.buttonCommunicationControl.Name = "buttonCommunicationControl";
            this.buttonCommunicationControl.Size = new System.Drawing.Size(262, 23);
            this.buttonCommunicationControl.TabIndex = 2;
            this.buttonCommunicationControl.Text = "Communication Control";
            this.buttonCommunicationControl.UseVisualStyleBackColor = true;
            this.buttonCommunicationControl.Click += new System.EventHandler(this.buttonCommunicationControl_Click);
            // 
            // buttonImageStreamControl
            // 
            this.buttonImageStreamControl.Location = new System.Drawing.Point(6, 77);
            this.buttonImageStreamControl.Name = "buttonImageStreamControl";
            this.buttonImageStreamControl.Size = new System.Drawing.Size(262, 23);
            this.buttonImageStreamControl.TabIndex = 3;
            this.buttonImageStreamControl.Text = "Image Stream Control";
            this.buttonImageStreamControl.UseVisualStyleBackColor = true;
            this.buttonImageStreamControl.Click += new System.EventHandler(this.buttonImageStreamControl_Click);
            // 
            // buttonDeviceSettings
            // 
            this.buttonDeviceSettings.Location = new System.Drawing.Point(6, 48);
            this.buttonDeviceSettings.Name = "buttonDeviceSettings";
            this.buttonDeviceSettings.Size = new System.Drawing.Size(262, 23);
            this.buttonDeviceSettings.TabIndex = 2;
            this.buttonDeviceSettings.Text = "Device Control";
            this.buttonDeviceSettings.UseVisualStyleBackColor = true;
            this.buttonDeviceSettings.Click += new System.EventHandler(this.buttonDeviceSettings_Click);
            // 
            // buttonStopPlay
            // 
            this.buttonStopPlay.Enabled = false;
            this.buttonStopPlay.Location = new System.Drawing.Point(7, 20);
            this.buttonStopPlay.Name = "buttonStopPlay";
            this.buttonStopPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonStopPlay.TabIndex = 1;
            this.buttonStopPlay.Text = "Pause";
            this.buttonStopPlay.UseVisualStyleBackColor = true;
            this.buttonStopPlay.Click += new System.EventHandler(this.buttonStopPlay_Click);
            // 
            // focusControl1
            // 
            this.focusControl1.Location = new System.Drawing.Point(0, 55);
            this.focusControl1.Name = "focusControl1";
            this.focusControl1.Size = new System.Drawing.Size(284, 119);
            this.focusControl1.TabIndex = 0;
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(280, 2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 20);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "LOG Window";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelFps
            // 
            this.labelFps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFps.Location = new System.Drawing.Point(45, 511);
            this.labelFps.Name = "labelFps";
            this.labelFps.Size = new System.Drawing.Size(37, 16);
            this.labelFps.TabIndex = 5;
            this.labelFps.Text = "00.0";
            this.labelFps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Palettes";
            // 
            // buttonOpenImage
            // 
            this.buttonOpenImage.Location = new System.Drawing.Point(554, 4);
            this.buttonOpenImage.Name = "buttonOpenImage";
            this.buttonOpenImage.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenImage.TabIndex = 21;
            this.buttonOpenImage.Text = "Open...";
            this.buttonOpenImage.UseVisualStyleBackColor = true;
            this.buttonOpenImage.Click += new System.EventHandler(this.buttonOpenImage_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "FPS";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 511);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Frames";
            // 
            // labelFrameCounter
            // 
            this.labelFrameCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFrameCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFrameCounter.Location = new System.Drawing.Point(133, 511);
            this.labelFrameCounter.Name = "labelFrameCounter";
            this.labelFrameCounter.Size = new System.Drawing.Size(78, 16);
            this.labelFrameCounter.TabIndex = 5;
            this.labelFrameCounter.Text = "00000000000";
            this.labelFrameCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLostImages
            // 
            this.labelLostImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLostImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLostImages.Location = new System.Drawing.Point(246, 511);
            this.labelLostImages.Name = "labelLostImages";
            this.labelLostImages.Size = new System.Drawing.Size(46, 16);
            this.labelLostImages.TabIndex = 5;
            this.labelLostImages.Text = "00000";
            this.labelLostImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(217, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lost";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 528);
            this.Controls.Add(this.buttonOpenImage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelLostImages);
            this.Controls.Add(this.labelFrameCounter);
            this.Controls.Add(this.labelFps);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainWindow";
            this.Text = "Thermal Camera sample.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private FocusControl focusControl1;
        private System.Windows.Forms.Button buttonStopPlay;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelFps;
        private System.Windows.Forms.Button buttonCommunicationControl;
        private System.Windows.Forms.Button buttonDeviceSettings;
        private System.Windows.Forms.Button buttonImageStreamControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNUC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWorkingEnvironments;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSensorGainMode;
        private System.Windows.Forms.ComboBox comboBoxFrameRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTriggerStatus;
        private System.Windows.Forms.Button buttonOpenImage;
        private System.Windows.Forms.Button buttonExtIo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelFrameCounter;
        private System.Windows.Forms.Label labelLostImages;
        private System.Windows.Forms.Label label11;
    }
}

