namespace P5_2_1204003
{
    partial class DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.LocalTimeLabel = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LocalTimeLabel
            // 
            this.LocalTimeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LocalTimeLabel.Location = new System.Drawing.Point(51, 89);
            this.LocalTimeLabel.Name = "LocalTimeLabel";
            this.LocalTimeLabel.Size = new System.Drawing.Size(100, 23);
            this.LocalTimeLabel.TabIndex = 0;
            this.LocalTimeLabel.Text = "\"\"";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocalTimeLabel);
            this.Name = "DigitalClock";
            this.Size = new System.Drawing.Size(378, 316);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LocalTimeLabel;
        private System.Windows.Forms.Timer Timer1;
    }
}
