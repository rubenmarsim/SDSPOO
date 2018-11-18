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
            this.lblPercentatge = new System.Windows.Forms.Label();
            this.btnSuma_Gutisa = new System.Windows.Forms.Button();
            this.txtBoxPercentatge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPercentatge
            // 
            this.lblPercentatge.AutoSize = true;
            this.lblPercentatge.Location = new System.Drawing.Point(52, 294);
            this.lblPercentatge.Name = "lblPercentatge";
            this.lblPercentatge.Size = new System.Drawing.Size(65, 13);
            this.lblPercentatge.TabIndex = 3;
            this.lblPercentatge.Text = "Percentatge";
            // 
            // btnSuma_Gutisa
            // 
            this.btnSuma_Gutisa.Location = new System.Drawing.Point(329, 294);
            this.btnSuma_Gutisa.Name = "btnSuma_Gutisa";
            this.btnSuma_Gutisa.Size = new System.Drawing.Size(123, 23);
            this.btnSuma_Gutisa.TabIndex = 5;
            this.btnSuma_Gutisa.Text = "Suma GUTISA";
            this.btnSuma_Gutisa.UseVisualStyleBackColor = true;
            this.btnSuma_Gutisa.Click += new System.EventHandler(this.btnSuma_Gutisa_Click);
            // 
            // txtBoxPercentatge
            // 
            this.txtBoxPercentatge.Location = new System.Drawing.Point(170, 294);
            this.txtBoxPercentatge.Name = "txtBoxPercentatge";
            this.txtBoxPercentatge.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPercentatge.TabIndex = 7;
            // 
            // frmSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPercentatge);
            this.Controls.Add(this.btnSuma_Gutisa);
            this.Controls.Add(this.lblPercentatge);
            this.Name = "frmSuma";
            this.Controls.SetChildIndex(this.lblPercentatge, 0);
            this.Controls.SetChildIndex(this.btnSuma_Gutisa, 0);
            this.Controls.SetChildIndex(this.txtBoxPercentatge, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPercentatge;
        private System.Windows.Forms.Button btnSuma_Gutisa;
        private System.Windows.Forms.TextBox txtBoxPercentatge;
    }
}