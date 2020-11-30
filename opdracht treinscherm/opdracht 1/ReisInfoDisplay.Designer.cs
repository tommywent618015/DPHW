namespace opdracht_1
{
    partial class ReisInfoDisplay
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
            this.lbl_station = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_spoor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "station: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_station
            // 
            this.lbl_station.AutoSize = true;
            this.lbl_station.Location = new System.Drawing.Point(247, 35);
            this.lbl_station.Name = "lbl_station";
            this.lbl_station.Size = new System.Drawing.Size(0, 17);
            this.lbl_station.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "spoor:";
            // 
            // lbl_spoor
            // 
            this.lbl_spoor.AutoSize = true;
            this.lbl_spoor.Location = new System.Drawing.Point(250, 80);
            this.lbl_spoor.Name = "lbl_spoor";
            this.lbl_spoor.Size = new System.Drawing.Size(0, 17);
            this.lbl_spoor.TabIndex = 3;
            // 
            // ReisInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 200);
            this.Controls.Add(this.lbl_spoor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_station);
            this.Controls.Add(this.label1);
            this.Name = "ReisInfoDisplay";
            this.Text = "ReisInfoDisplay";
            this.Load += new System.EventHandler(this.ReisInfoDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_station;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_spoor;
    }
}