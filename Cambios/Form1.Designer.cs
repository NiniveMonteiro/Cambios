
namespace Cambios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Cb_MoedaOrigem = new System.Windows.Forms.ComboBox();
            this.Cb_MoedaDestino = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lb_Resultado = new System.Windows.Forms.Label();
            this.Lbl_Status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moeda de Origem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Moeda de Destino:";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Valor.Location = new System.Drawing.Point(192, 39);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(227, 25);
            this.Txt_Valor.TabIndex = 3;
            // 
            // Cb_MoedaOrigem
            // 
            this.Cb_MoedaOrigem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_MoedaOrigem.FormattingEnabled = true;
            this.Cb_MoedaOrigem.Location = new System.Drawing.Point(192, 99);
            this.Cb_MoedaOrigem.Name = "Cb_MoedaOrigem";
            this.Cb_MoedaOrigem.Size = new System.Drawing.Size(227, 26);
            this.Cb_MoedaOrigem.TabIndex = 4;
            // 
            // Cb_MoedaDestino
            // 
            this.Cb_MoedaDestino.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cb_MoedaDestino.FormattingEnabled = true;
            this.Cb_MoedaDestino.Location = new System.Drawing.Point(192, 153);
            this.Cb_MoedaDestino.Name = "Cb_MoedaDestino";
            this.Cb_MoedaDestino.Size = new System.Drawing.Size(227, 26);
            this.Cb_MoedaDestino.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(483, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lb_Resultado
            // 
            this.Lb_Resultado.AutoSize = true;
            this.Lb_Resultado.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_Resultado.Location = new System.Drawing.Point(123, 228);
            this.Lb_Resultado.Name = "Lb_Resultado";
            this.Lb_Resultado.Size = new System.Drawing.Size(362, 18);
            this.Lb_Resultado.TabIndex = 7;
            this.Lb_Resultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // Lbl_Status
            // 
            this.Lbl_Status.AutoSize = true;
            this.Lbl_Status.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Status.Location = new System.Drawing.Point(30, 310);
            this.Lbl_Status.Name = "Lbl_Status";
            this.Lbl_Status.Size = new System.Drawing.Size(59, 18);
            this.Lbl_Status.TabIndex = 8;
            this.Lbl_Status.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(413, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(173, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 352);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Lbl_Status);
            this.Controls.Add(this.Lb_Resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cb_MoedaDestino);
            this.Controls.Add(this.Cb_MoedaOrigem);
            this.Controls.Add(this.Txt_Valor);
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
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.ComboBox Cb_MoedaOrigem;
        private System.Windows.Forms.ComboBox Cb_MoedaDestino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lb_Resultado;
        private System.Windows.Forms.Label Lbl_Status;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

