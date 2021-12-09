namespace P5_2_1204003_TestClock
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
            this.digitalClock1 = new P5_2_1204003.DigitalClock();
            this.UniversalTimeLabel = new System.Windows.Forms.Label();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // digitalClock1
            // 
            this.digitalClock1.LocalTimeLabel_BackColor = System.Drawing.SystemColors.ControlLight;
            this.digitalClock1.Location = new System.Drawing.Point(224, 41);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(184, 157);
            this.digitalClock1.TabIndex = 0;
            this.digitalClock1.Timer1_Enabled = true;
            this.digitalClock1.RaiseTimer1_Tick += new System.EventHandler(this.digitalClock1_RaiseTimer1_Tick);
            // 
            // UniversalTimeLabel
            // 
            this.UniversalTimeLabel.AutoSize = true;
            this.UniversalTimeLabel.Location = new System.Drawing.Point(221, 229);
            this.UniversalTimeLabel.Name = "UniversalTimeLabel";
            this.UniversalTimeLabel.Size = new System.Drawing.Size(46, 17);
            this.UniversalTimeLabel.TabIndex = 1;
            this.UniversalTimeLabel.Text = "label1";
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(295, 312);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(112, 23);
            this.StartStopButton.TabIndex = 2;
            this.StartStopButton.Text = "Start/Stop";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Universal Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.UniversalTimeLabel);
            this.Controls.Add(this.digitalClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private P5_2_1204003.DigitalClock digitalClock1;
        private System.Windows.Forms.Label UniversalTimeLabel;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

