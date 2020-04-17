namespace ConwayGameOfLife
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResetGame = new System.Windows.Forms.Button();
            this.highLifeBtn = new System.Windows.Forms.Button();
            this.standardLifeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(715, 1350);
            this.btnResetGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(282, 71);
            this.btnResetGame.TabIndex = 0;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // highLifeBtn
            // 
            this.highLifeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLifeBtn.Location = new System.Drawing.Point(392, 1350);
            this.highLifeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.highLifeBtn.Name = "highLifeBtn";
            this.highLifeBtn.Size = new System.Drawing.Size(282, 71);
            this.highLifeBtn.TabIndex = 1;
            this.highLifeBtn.Text = "High Life";
            this.highLifeBtn.UseVisualStyleBackColor = true;
            this.highLifeBtn.Click += new System.EventHandler(this.highLifeBtn_Click);
            // 
            // standardLifeBtn
            // 
            this.standardLifeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardLifeBtn.Location = new System.Drawing.Point(69, 1350);
            this.standardLifeBtn.Margin = new System.Windows.Forms.Padding(6);
            this.standardLifeBtn.Name = "standardLifeBtn";
            this.standardLifeBtn.Size = new System.Drawing.Size(282, 71);
            this.standardLifeBtn.TabIndex = 2;
            this.standardLifeBtn.Text = "Standard Life";
            this.standardLifeBtn.UseVisualStyleBackColor = true;
            this.standardLifeBtn.Click += new System.EventHandler(this.standardLifeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2998, 1444);
            this.Controls.Add(this.standardLifeBtn);
            this.Controls.Add(this.highLifeBtn);
            this.Controls.Add(this.btnResetGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Conway\'s Game Of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button highLifeBtn;
        private System.Windows.Forms.Button standardLifeBtn;
    }
}

