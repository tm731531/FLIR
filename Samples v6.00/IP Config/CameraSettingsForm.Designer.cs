﻿namespace IP_Config
{
    partial class CameraSettingsForm
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
            this.ipConfigControl1 = new Flir.Atlas.Live.WinForms.IpConfigControl();
            this.SuspendLayout();
            // 
            // ipConfigControl1
            // 
            this.ipConfigControl1.Location = new System.Drawing.Point(24, 12);
            this.ipConfigControl1.Name = "ipConfigControl1";
            this.ipConfigControl1.Size = new System.Drawing.Size(315, 261);
            this.ipConfigControl1.TabIndex = 0;
            // 
            // CameraSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 247);
            this.Controls.Add(this.ipConfigControl1);
            this.Name = "CameraSettingsForm";
            this.Text = "CameraSettingsForm";
            this.Load += new System.EventHandler(this.CameraSettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Flir.Atlas.Live.WinForms.IpConfigControl ipConfigControl1;
    }
}