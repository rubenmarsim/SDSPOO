namespace Calculs_GUTISA
{
    partial class frmSuma
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPercentatge = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnSuma_Gutisa = new System.Windows.Forms.Button();
            this.txtBoxNum1 = new System.Windows.Forms.TextBox();
            this.txtBoxNum2 = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.txtBoxPercentatge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(115, 55);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(45, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num #1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(114, 100);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(45, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num #2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(115, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblPercentatge
            // 
            this.lblPercentatge.AutoSize = true;
            this.lblPercentatge.Location = new System.Drawing.Point(94, 284);
            this.lblPercentatge.Name = "lblPercentatge";
            this.lblPercentatge.Size = new System.Drawing.Size(65, 13);
            this.lblPercentatge.TabIndex = 3;
            this.lblPercentatge.Text = "Percentatge";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(408, 98);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnSuma_Gutisa
            // 
            this.btnSuma_Gutisa.Location = new System.Drawing.Point(432, 274);
            this.btnSuma_Gutisa.Name = "btnSuma_Gutisa";
            this.btnSuma_Gutisa.Size = new System.Drawing.Size(123, 23);
            this.btnSuma_Gutisa.TabIndex = 5;
            this.btnSuma_Gutisa.Text = "Suma GUTISA";
            this.btnSuma_Gutisa.UseVisualStyleBackColor = true;
            // 
            // txtBoxNum1
            // 
            this.txtBoxNum1.Location = new System.Drawing.Point(237, 55);
            this.txtBoxNum1.Name = "txtBoxNum1";
            this.txtBoxNum1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum1.TabIndex = 6;
            // 
            // txtBoxNum2
            // 
            this.txtBoxNum2.Location = new System.Drawing.Point(237, 100);
            this.txtBoxNum2.Name = "txtBoxNum2";
            this.txtBoxNum2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNum2.TabIndex = 7;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(237, 179);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTotal.TabIndex = 8;
            // 
            // txtBoxPercentatge
            // 
            this.txtBoxPercentatge.Location = new System.Drawing.Point(237, 277);
            this.txtBoxPercentatge.Name = "txtBoxPercentatge";
            this.txtBoxPercentatge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPercentatge.TabIndex = 9;
            // 
            // frmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPercentatge);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtBoxNum2);
            this.Controls.Add(this.txtBoxNum1);
            this.Controls.Add(this.btnSuma_Gutisa);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.lblPercentatge);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "frmSuma";
            this.Text = "frmSuma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPercentatge;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnSuma_Gutisa;
        private System.Windows.Forms.TextBox txtBoxNum1;
        private System.Windows.Forms.TextBox txtBoxNum2;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.TextBox txtBoxPercentatge;
    }
}