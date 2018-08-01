namespace GigabitCamera
{
    partial class PlaybackDialog
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
            this.playbackControl1 = new Flir.Atlas.Live.WinForms.PlaybackControl();
            this.thermalToolbarControl1 = new Flir.Atlas.Image.WinForms.ThermalToolbarControl();
            this.thermalImageControl1 = new Flir.Atlas.Image.WinForms.ThermalImageControl();
            this.SuspendLayout();
            // 
            // playbackControl1
            // 
            this.playbackControl1.Location = new System.Drawing.Point(435, 3);
            this.playbackControl1.Name = "playbackControl1";
            this.playbackControl1.Size = new System.Drawing.Size(100, 32);
            this.playbackControl1.TabIndex = 6;
            // 
            // thermalToolbarControl1
            // 
            this.thermalToolbarControl1.Location = new System.Drawing.Point(12, 3);
            this.thermalToolbarControl1.Name = "thermalToolbarControl1";
            this.thermalToolbarControl1.Size = new System.Drawing.Size(417, 27);
            this.thermalToolbarControl1.TabIndex = 5;
            // 
            // thermalImageControl1
            // 
            this.thermalImageControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thermalImageControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.thermalImageControl1.Location = new System.Drawing.Point(12, 36);
            this.thermalImageControl1.Name = "thermalImageControl1";
            this.thermalImageControl1.Size = new System.Drawing.Size(707, 371);
            this.thermalImageControl1.TabIndex = 4;
            this.thermalImageControl1.Tool = Flir.Atlas.Image.WinForms.ThermalImageControl.MeasurementTool.None;
            // 
            // PlaybackDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 419);
            this.Controls.Add(this.playbackControl1);
            this.Controls.Add(this.thermalToolbarControl1);
            this.Controls.Add(this.thermalImageControl1);
            this.Name = "PlaybackDialog";
            this.Text = "Playback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlaybackDialog_FormClosing);
            this.Load += new System.EventHandler(this.PlaybackDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Flir.Atlas.Live.WinForms.PlaybackControl playbackControl1;
        private Flir.Atlas.Image.WinForms.ThermalToolbarControl thermalToolbarControl1;
        private Flir.Atlas.Image.WinForms.ThermalImageControl thermalImageControl1;
    }
}