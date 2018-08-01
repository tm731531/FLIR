namespace GigabitCamera
{
    partial class RecordingForm
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
            this.recordingControl1 = new Flir.Atlas.Live.WinForms.RecordingControl();
            this.SuspendLayout();
            // 
            // recordingControl1
            // 
            this.recordingControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recordingControl1.Location = new System.Drawing.Point(12, 2);
            this.recordingControl1.Name = "recordingControl1";
            this.recordingControl1.Size = new System.Drawing.Size(257, 352);
            this.recordingControl1.TabIndex = 0;
            // 
            // RecordingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 365);
            this.Controls.Add(this.recordingControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecordingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Recording";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecordingForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Flir.Atlas.Live.WinForms.RecordingControl recordingControl1;
    }
}