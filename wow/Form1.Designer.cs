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
            this.label1.Location = new System.Drawing.Point(332, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D - Daniela   E - Edward   F - Fatima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Initial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Amount";
            // 
            // textBox_Initial
            // 
            this.textBox_Initial.Location = new System.Drawing.Point(325, 90);
            this.textBox_Initial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Initial.Name = "textBox_Initial";
            this.textBox_Initial.Size = new System.Drawing.Size(232, 22);
            this.textBox_Initial.TabIndex = 3;
            // 
            // textBox_AmountOfSale
            // 
            this.textBox_AmountOfSale.Location = new System.Drawing.Point(325, 122);
            this.textBox_AmountOfSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_AmountOfSale.Name = "textBox_AmountOfSale";
            this.textBox_AmountOfSale.Size = new System.Drawing.Size(232, 22);
            this.textBox_AmountOfSale.TabIndex = 4;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(249, 177);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(103, 27);
            this.Btn_Submit.TabIndex = 5;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(360, 177);
            this.Btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(103, 27);
            this.Btn_Clear.TabIndex = 6;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(471, 177);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(103, 27);
            this.Btn_Print.TabIndex = 7;
            this.Btn_Print.Text = "Print";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.Location = new System.Drawing.Point(332, 263);
            this.label_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(0, 16);
            this.label_Result.TabIndex = 8;
            // 
            // label_ResultS
            // 
            this.label_ResultS.AutoSize = true;
            this.label_ResultS.Location = new System.Drawing.Point(336, 268);
            this.label_ResultS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ResultS.Name = "label_ResultS";
            this.label_ResultS.Size = new System.Drawing.Size(0, 16);
            this.label_ResultS.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

