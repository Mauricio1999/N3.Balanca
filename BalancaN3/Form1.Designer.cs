namespace BalancaN3
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
            this.btnLerPeso = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLerPeso
            // 
            this.btnLerPeso.Location = new System.Drawing.Point(143, 109);
            this.btnLerPeso.Name = "btnLerPeso";
            this.btnLerPeso.Size = new System.Drawing.Size(123, 39);
            this.btnLerPeso.TabIndex = 0;
            this.btnLerPeso.Text = "Ler Peso";
            this.btnLerPeso.UseVisualStyleBackColor = true;
            this.btnLerPeso.Click += new System.EventHandler(this.btnLerPeso_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPeso.Location = new System.Drawing.Point(143, 53);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(67, 31);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "0,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 192);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnLerPeso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLerPeso;
        private System.Windows.Forms.Label lblPeso;
    }
}

