namespace opdracht_1
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
            this.Btn_volgendstation = new System.Windows.Forms.Button();
            this.Btn_extraScherm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_volgendstation
            // 
            this.Btn_volgendstation.Location = new System.Drawing.Point(115, 77);
            this.Btn_volgendstation.Name = "Btn_volgendstation";
            this.Btn_volgendstation.Size = new System.Drawing.Size(250, 75);
            this.Btn_volgendstation.TabIndex = 0;
            this.Btn_volgendstation.Text = "volgend station";
            this.Btn_volgendstation.UseVisualStyleBackColor = true;
            this.Btn_volgendstation.Click += new System.EventHandler(this.Btn_volgendstation_Click);
            // 
            // Btn_extraScherm
            // 
            this.Btn_extraScherm.Location = new System.Drawing.Point(37, 406);
            this.Btn_extraScherm.Name = "Btn_extraScherm";
            this.Btn_extraScherm.Size = new System.Drawing.Size(128, 32);
            this.Btn_extraScherm.TabIndex = 1;
            this.Btn_extraScherm.Text = "nieuw scherm";
            this.Btn_extraScherm.UseVisualStyleBackColor = true;
            this.Btn_extraScherm.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 465);
            this.Controls.Add(this.Btn_extraScherm);
            this.Controls.Add(this.Btn_volgendstation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_volgendstation;
        private System.Windows.Forms.Button Btn_extraScherm;
    }
}

