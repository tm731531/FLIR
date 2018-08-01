namespace GigabitCamera
{
    partial class LoggerWindow
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
            this.listBoxLogger = new System.Windows.Forms.ListBox();
            this.listBoxExecutedCommands = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxLogger
            // 
            this.listBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLogger.FormattingEnabled = true;
            this.listBoxLogger.Location = new System.Drawing.Point(12, 12);
            this.listBoxLogger.Name = "listBoxLogger";
            this.listBoxLogger.Size = new System.Drawing.Size(601, 160);
            this.listBoxLogger.TabIndex = 0;
            // 
            // listBoxSentCommands
            // 
            this.listBoxExecutedCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxExecutedCommands.FormattingEnabled = true;
            this.listBoxExecutedCommands.Location = new System.Drawing.Point(12, 196);
            this.listBoxExecutedCommands.Name = "listBoxSentCommands";
            this.listBoxExecutedCommands.Size = new System.Drawing.Size(601, 147);
            this.listBoxExecutedCommands.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Executed commands";
            // 
            // LoggerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxExecutedCommands);
            this.Controls.Add(this.listBoxLogger);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoggerWindow";
            this.Text = "Logger";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLogger;
        private System.Windows.Forms.ListBox listBoxExecutedCommands;
        private System.Windows.Forms.Label label1;
    }
}