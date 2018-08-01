namespace GigabitCamera
{
    partial class FocusControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxFocus = new System.Windows.Forms.GroupBox();
            this.buttonFocusDistance = new System.Windows.Forms.Button();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFocusFar = new System.Windows.Forms.Button();
            this.buttonFocusAuto = new System.Windows.Forms.Button();
            this.buttonFocusNear = new System.Windows.Forms.Button();
            this.groupBoxFocus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFocus
            // 
            this.groupBoxFocus.Controls.Add(this.buttonFocusDistance);
            this.groupBoxFocus.Controls.Add(this.textBoxDistance);
            this.groupBoxFocus.Controls.Add(this.label2);
            this.groupBoxFocus.Controls.Add(this.label1);
            this.groupBoxFocus.Controls.Add(this.buttonFocusFar);
            this.groupBoxFocus.Controls.Add(this.buttonFocusAuto);
            this.groupBoxFocus.Controls.Add(this.buttonFocusNear);
            this.groupBoxFocus.Enabled = false;
            this.groupBoxFocus.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFocus.Name = "groupBoxFocus";
            this.groupBoxFocus.Size = new System.Drawing.Size(272, 109);
            this.groupBoxFocus.TabIndex = 26;
            this.groupBoxFocus.TabStop = false;
            this.groupBoxFocus.Text = "Focus";
            // 
            // buttonFocusDistance
            // 
            this.buttonFocusDistance.Location = new System.Drawing.Point(124, 67);
            this.buttonFocusDistance.Name = "buttonFocusDistance";
            this.buttonFocusDistance.Size = new System.Drawing.Size(32, 23);
            this.buttonFocusDistance.TabIndex = 3;
            this.buttonFocusDistance.Text = "Set";
            this.buttonFocusDistance.UseVisualStyleBackColor = true;
            this.buttonFocusDistance.Click += new System.EventHandler(this.buttonFocusDistance_Click);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(54, 69);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(54, 20);
            this.textBoxDistance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distance";
            // 
            // buttonFocusFar
            // 
            this.buttonFocusFar.Location = new System.Drawing.Point(173, 35);
            this.buttonFocusFar.Name = "buttonFocusFar";
            this.buttonFocusFar.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusFar.TabIndex = 0;
            this.buttonFocusFar.Text = "Far";
            this.buttonFocusFar.UseVisualStyleBackColor = true;
            this.buttonFocusFar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFocusFar_MouseDown);
            this.buttonFocusFar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFocusFar_MouseUp);
            // 
            // buttonFocusAuto
            // 
            this.buttonFocusAuto.Location = new System.Drawing.Point(92, 35);
            this.buttonFocusAuto.Name = "buttonFocusAuto";
            this.buttonFocusAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusAuto.TabIndex = 0;
            this.buttonFocusAuto.Text = "Auto";
            this.buttonFocusAuto.UseVisualStyleBackColor = true;
            this.buttonFocusAuto.Click += new System.EventHandler(this.buttonFocusAuto_Click);
            // 
            // buttonFocusNear
            // 
            this.buttonFocusNear.Location = new System.Drawing.Point(11, 35);
            this.buttonFocusNear.Name = "buttonFocusNear";
            this.buttonFocusNear.Size = new System.Drawing.Size(75, 23);
            this.buttonFocusNear.TabIndex = 0;
            this.buttonFocusNear.Text = "Near";
            this.buttonFocusNear.UseVisualStyleBackColor = true;
            this.buttonFocusNear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFocusNear_MouseDown);
            this.buttonFocusNear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFocusNear_MouseUp);
            // 
            // FocusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFocus);
            this.Name = "FocusControl";
            this.Size = new System.Drawing.Size(284, 119);
            this.groupBoxFocus.ResumeLayout(false);
            this.groupBoxFocus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFocus;
        private System.Windows.Forms.Button buttonFocusDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFocusFar;
        private System.Windows.Forms.Button buttonFocusAuto;
        private System.Windows.Forms.Button buttonFocusNear;
    }
}
