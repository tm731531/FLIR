namespace GigabitCamera
{
    partial class ExternalIoForm
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
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxSelectedPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxSensitivity = new System.Windows.Forms.ComboBox();
            this.comboBoxPolarity = new System.Windows.Forms.ComboBox();
            this.comboBoxConfig = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(87, 30);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(52, 13);
            this.labelType.TabIndex = 0;
            this.labelType.Text = "IO_TYPE";
            // 
            // comboBoxSelectedPort
            // 
            this.comboBoxSelectedPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedPort.FormattingEnabled = true;
            this.comboBoxSelectedPort.Location = new System.Drawing.Point(85, 22);
            this.comboBoxSelectedPort.Name = "comboBoxSelectedPort";
            this.comboBoxSelectedPort.Size = new System.Drawing.Size(62, 21);
            this.comboBoxSelectedPort.TabIndex = 19;
            this.comboBoxSelectedPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedPort_SelectedIndexChanged);
            this.comboBoxSelectedPort.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectedPort_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApply);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxState);
            this.groupBox1.Controls.Add(this.comboBoxSensitivity);
            this.groupBox1.Controls.Add(this.comboBoxPolarity);
            this.groupBox1.Controls.Add(this.comboBoxConfig);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelDirection);
            this.groupBox1.Controls.Add(this.labelType);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 241);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(191, 208);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 20;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sensitivity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Polarity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Config";
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(90, 167);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(177, 21);
            this.comboBoxState.TabIndex = 19;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedPort_SelectedIndexChanged);
            // 
            // comboBoxSensitivity
            // 
            this.comboBoxSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensitivity.FormattingEnabled = true;
            this.comboBoxSensitivity.Location = new System.Drawing.Point(90, 138);
            this.comboBoxSensitivity.Name = "comboBoxSensitivity";
            this.comboBoxSensitivity.Size = new System.Drawing.Size(177, 21);
            this.comboBoxSensitivity.TabIndex = 19;
            this.comboBoxSensitivity.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedPort_SelectedIndexChanged);
            // 
            // comboBoxPolarity
            // 
            this.comboBoxPolarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolarity.FormattingEnabled = true;
            this.comboBoxPolarity.Location = new System.Drawing.Point(90, 111);
            this.comboBoxPolarity.Name = "comboBoxPolarity";
            this.comboBoxPolarity.Size = new System.Drawing.Size(177, 21);
            this.comboBoxPolarity.TabIndex = 19;
            this.comboBoxPolarity.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedPort_SelectedIndexChanged);
            // 
            // comboBoxConfig
            // 
            this.comboBoxConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfig.FormattingEnabled = true;
            this.comboBoxConfig.Location = new System.Drawing.Point(90, 84);
            this.comboBoxConfig.Name = "comboBoxConfig";
            this.comboBoxConfig.Size = new System.Drawing.Size(177, 21);
            this.comboBoxConfig.TabIndex = 19;
            this.comboBoxConfig.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectedPort_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Direction";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(87, 59);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(83, 13);
            this.labelDirection.TabIndex = 0;
            this.labelDirection.Text = "IO_DIRECTION";
            // 
            // ExternalIoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSelectedPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExternalIoForm";
            this.Text = "External I/O settings";
            this.Load += new System.EventHandler(this.ExternalIoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxSelectedPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.ComboBox comboBoxSensitivity;
        private System.Windows.Forms.ComboBox comboBoxPolarity;
        private System.Windows.Forms.Button buttonApply;
    }
}