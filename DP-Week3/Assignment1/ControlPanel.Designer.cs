namespace Assignment1
{
    partial class ControlPanel
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
            this.btnNextStation = new System.Windows.Forms.Button();
            this.btnNewDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNextStation
            // 
            this.btnNextStation.Location = new System.Drawing.Point(230, 149);
            this.btnNextStation.Name = "btnNextStation";
            this.btnNextStation.Size = new System.Drawing.Size(451, 119);
            this.btnNextStation.TabIndex = 0;
            this.btnNextStation.Text = "Next Station";
            this.btnNextStation.UseVisualStyleBackColor = true;
            this.btnNextStation.Click += new System.EventHandler(this.btnNextStation_Click);
            // 
            // btnNewDisplay
            // 
            this.btnNewDisplay.Location = new System.Drawing.Point(67, 451);
            this.btnNewDisplay.Name = "btnNewDisplay";
            this.btnNewDisplay.Size = new System.Drawing.Size(283, 63);
            this.btnNewDisplay.TabIndex = 1;
            this.btnNewDisplay.Text = "New Display";
            this.btnNewDisplay.UseVisualStyleBackColor = true;
            this.btnNewDisplay.Click += new System.EventHandler(this.btnNewDisplay_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.btnNewDisplay);
            this.Controls.Add(this.btnNextStation);
            this.Name = "ControlPanel";
            this.Text = "Control Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNextStation;
        private System.Windows.Forms.Button btnNewDisplay;
    }
}

