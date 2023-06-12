namespace trabalhoPO2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.btn_definirvalor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(21, 19);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 23);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tb_Valor
            // 
            this.tb_Valor.Location = new System.Drawing.Point(134, 19);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(97, 23);
            this.tb_Valor.TabIndex = 1;
            this.tb_Valor.Text = "0";
            // 
            // btn_definirvalor
            // 
            this.btn_definirvalor.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_definirvalor.Location = new System.Drawing.Point(258, 12);
            this.btn_definirvalor.Name = "btn_definirvalor";
            this.btn_definirvalor.Size = new System.Drawing.Size(99, 32);
            this.btn_definirvalor.TabIndex = 2;
            this.btn_definirvalor.Text = "Definir valor";
            this.btn_definirvalor.UseVisualStyleBackColor = true;
            this.btn_definirvalor.Click += new System.EventHandler(this.byn_definirvalor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 379);
            this.Controls.Add(this.btn_definirvalor);
            this.Controls.Add(this.tb_Valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private TextBox tb_Valor;
        private Button btn_definirvalor;
    }
}