namespace wow
{
    partial class Form2
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
            this.label_Danielle = new System.Windows.Forms.Label();
            this.label_Edward = new System.Windows.Forms.Label();
            this.label_Fatima = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUMMARY REPORT";
            // 
            // label_Danielle
            // 
            this.label_Danielle.AutoSize = true;
            this.label_Danielle.Location = new System.Drawing.Point(208, 125);
            this.label_Danielle.Name = "label_Danielle";
            this.label_Danielle.Size = new System.Drawing.Size(132, 16);
            this.label_Danielle.TabIndex = 1;
            this.label_Danielle.Text = "Danielle Total Sales:";
            // 
            // label_Edward
            // 
            this.label_Edward.AutoSize = true;
            this.label_Edward.Location = new System.Drawing.Point(208, 154);
            this.label_Edward.Name = "label_Edward";
            this.label_Edward.Size = new System.Drawing.Size(128, 16);
            this.label_Edward.TabIndex = 2;
            this.label_Edward.Text = "Edward Total Sales:";
            // 
            // label_Fatima
            // 
            this.label_Fatima.AutoSize = true;
            this.label_Fatima.Location = new System.Drawing.Point(208, 180);
            this.label_Fatima.Name = "label_Fatima";
            this.label_Fatima.Size = new System.Drawing.Size(123, 16);
            this.label_Fatima.TabIndex = 3;
            this.label_Fatima.Text = "Fatima Total Sales:";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(208, 210);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(79, 16);
            this.label_Total.TabIndex = 4;
            this.label_Total.Text = "Total Sales:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label_Fatima);
            this.Controls.Add(this.label_Edward);
            this.Controls.Add(this.label_Danielle);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Danielle;
        private System.Windows.Forms.Label label_Edward;
        private System.Windows.Forms.Label label_Fatima;
        private System.Windows.Forms.Label label_Total;
    }
}