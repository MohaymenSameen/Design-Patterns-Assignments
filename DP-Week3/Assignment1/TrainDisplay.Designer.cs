﻿namespace Assignment1
{
    partial class TrainDisplay
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
            this.lblCurrentStation = new System.Windows.Forms.Label();
            this.lblCurrentStationTxt = new System.Windows.Forms.Label();
            this.lblRailwayTrack = new System.Windows.Forms.Label();
            this.lblRailwayTrackTxt = new System.Windows.Forms.Label();
            this.lblArrivalTimeTxt = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentStation
            // 
            this.lblCurrentStation.AutoSize = true;
            this.lblCurrentStation.Location = new System.Drawing.Point(115, 93);
            this.lblCurrentStation.Name = "lblCurrentStation";
            this.lblCurrentStation.Size = new System.Drawing.Size(162, 25);
            this.lblCurrentStation.TabIndex = 0;
            this.lblCurrentStation.Text = "Current Station:";
            // 
            // lblCurrentStationTxt
            // 
            this.lblCurrentStationTxt.AutoSize = true;
            this.lblCurrentStationTxt.Location = new System.Drawing.Point(332, 93);
            this.lblCurrentStationTxt.Name = "lblCurrentStationTxt";
            this.lblCurrentStationTxt.Size = new System.Drawing.Size(76, 25);
            this.lblCurrentStationTxt.TabIndex = 1;
            this.lblCurrentStationTxt.Text = "station";
            // 
            // lblRailwayTrack
            // 
            this.lblRailwayTrack.AutoSize = true;
            this.lblRailwayTrack.Location = new System.Drawing.Point(115, 161);
            this.lblRailwayTrack.Name = "lblRailwayTrack";
            this.lblRailwayTrack.Size = new System.Drawing.Size(153, 25);
            this.lblRailwayTrack.TabIndex = 2;
            this.lblRailwayTrack.Text = "Railway Track:";
            // 
            // lblRailwayTrackTxt
            // 
            this.lblRailwayTrackTxt.AutoSize = true;
            this.lblRailwayTrackTxt.Location = new System.Drawing.Point(332, 161);
            this.lblRailwayTrackTxt.Name = "lblRailwayTrackTxt";
            this.lblRailwayTrackTxt.Size = new System.Drawing.Size(59, 25);
            this.lblRailwayTrackTxt.TabIndex = 3;
            this.lblRailwayTrackTxt.Text = "track";
            // 
            // lblArrivalTimeTxt
            // 
            this.lblArrivalTimeTxt.AutoSize = true;
            this.lblArrivalTimeTxt.Location = new System.Drawing.Point(332, 231);
            this.lblArrivalTimeTxt.Name = "lblArrivalTimeTxt";
            this.lblArrivalTimeTxt.Size = new System.Drawing.Size(73, 25);
            this.lblArrivalTimeTxt.TabIndex = 4;
            this.lblArrivalTimeTxt.Text = "Arrival";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Location = new System.Drawing.Point(115, 231);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(126, 25);
            this.lblArrivalTime.TabIndex = 5;
            this.lblArrivalTime.Text = "Arrival Time";
            // 
            // TrainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 342);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblArrivalTimeTxt);
            this.Controls.Add(this.lblRailwayTrackTxt);
            this.Controls.Add(this.lblRailwayTrack);
            this.Controls.Add(this.lblCurrentStationTxt);
            this.Controls.Add(this.lblCurrentStation);
            this.Name = "TrainDisplay";
            this.Text = "TrainDisplay";
            this.Load += new System.EventHandler(this.TrainDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentStation;
        private System.Windows.Forms.Label lblCurrentStationTxt;
        private System.Windows.Forms.Label lblRailwayTrack;
        private System.Windows.Forms.Label lblRailwayTrackTxt;
        private System.Windows.Forms.Label lblArrivalTimeTxt;
        private System.Windows.Forms.Label lblArrivalTime;
    }
}