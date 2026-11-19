namespace wow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Initial = new System.Windows.Forms.TextBox();
            this.textBox_AmountOfSale = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_ResultS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "D - Daniela\r\nE - Edward\r\nF - Fatima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Amount";
            // 
            // textBox_Initial
            // 
            this.textBox_Initial.Location = new System.Drawing.Point(244, 73);
            this.textBox_Initial.Name = "textBox_Initial";
            this.textBox_Initial.Size = new System.Drawing.Size(175, 20);
            this.textBox_Initial.TabIndex = 3;
            // 
            // textBox_AmountOfSale
            // 
            this.textBox_AmountOfSale.Location = new System.Drawing.Point(244, 99);
            this.textBox_AmountOfSale.Name = "textBox_AmountOfSale";
            this.textBox_AmountOfSale.Size = new System.Drawing.Size(175, 20);
            this.textBox_AmountOfSale.TabIndex = 4;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(187, 144);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(77, 22);
            this.Btn_Submit.TabIndex = 5;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(270, 144);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(77, 22);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(353, 144);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(77, 22);
            this.Btn_Print.TabIndex = 7;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(249, 214);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 13);
            this.label_Result.TabIndex = 8;
            // 
            // label_ResultS
            // 
            this.label_ResultS.AutoSize = true;
            this.label_ResultS.Location = new System.Drawing.Point(252, 218);
            this.label_ResultS.Name = "label_ResultS";
            this.label_ResultS.Size = new System.Drawing.Size(35, 13);
            this.label_ResultS.TabIndex = 9;
            this.label_ResultS.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ResultS);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.textBox_AmountOfSale);
            this.Controls.Add(this.textBox_Initial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Initial;
        private System.Windows.Forms.TextBox textBox_AmountOfSale;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_ResultS;
    }
}

