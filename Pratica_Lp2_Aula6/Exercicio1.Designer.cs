namespace Pratica_Lp2_Aula6
{
    partial class Exercicio1
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
            this.btnQtdPares = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchTxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnQtdBrancos = new System.Windows.Forms.Button();
            this.btnQtdR = new System.Windows.Forms.Button();
            this.btnQtdPar = new System.Windows.Forms.Button();
            this.btnQtdPares.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQtdPares
            // 
            this.btnQtdPares.Controls.Add(this.btnQtdPar);
            this.btnQtdPares.Controls.Add(this.btnQtdR);
            this.btnQtdPares.Controls.Add(this.btnQtdBrancos);
            this.btnQtdPares.Controls.Add(this.btnLimpar);
            this.btnQtdPares.Controls.Add(this.rchTxtFrase);
            this.btnQtdPares.Controls.Add(this.label1);
            this.btnQtdPares.ForeColor = System.Drawing.Color.White;
            this.btnQtdPares.Location = new System.Drawing.Point(13, 13);
            this.btnQtdPares.Name = "btnQtdPares";
            this.btnQtdPares.Size = new System.Drawing.Size(775, 425);
            this.btnQtdPares.TabIndex = 1;
            this.btnQtdPares.TabStop = false;
            this.btnQtdPares.Text = "Exercicio 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escreva sua frase:";
            // 
            // rchTxtFrase
            // 
            this.rchTxtFrase.Location = new System.Drawing.Point(10, 74);
            this.rchTxtFrase.Name = "rchTxtFrase";
            this.rchTxtFrase.Size = new System.Drawing.Size(319, 145);
            this.rchTxtFrase.TabIndex = 1;
            this.rchTxtFrase.Text = "";
            this.rchTxtFrase.Validated += new System.EventHandler(this.rchTxtFrase_Validated);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(649, 379);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 40);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnQtdBrancos
            // 
            this.btnQtdBrancos.BackColor = System.Drawing.Color.Black;
            this.btnQtdBrancos.Location = new System.Drawing.Point(258, 379);
            this.btnQtdBrancos.Name = "btnQtdBrancos";
            this.btnQtdBrancos.Size = new System.Drawing.Size(130, 40);
            this.btnQtdBrancos.TabIndex = 8;
            this.btnQtdBrancos.Text = "Qtd Brancos";
            this.btnQtdBrancos.UseVisualStyleBackColor = false;
            this.btnQtdBrancos.Click += new System.EventHandler(this.btnQtdBrancos_Click);
            // 
            // btnQtdR
            // 
            this.btnQtdR.BackColor = System.Drawing.Color.Black;
            this.btnQtdR.Location = new System.Drawing.Point(132, 379);
            this.btnQtdR.Name = "btnQtdR";
            this.btnQtdR.Size = new System.Drawing.Size(120, 40);
            this.btnQtdR.TabIndex = 9;
            this.btnQtdR.Text = "Qtd Rs";
            this.btnQtdR.UseVisualStyleBackColor = false;
            this.btnQtdR.Click += new System.EventHandler(this.btnQtdR_Click);
            // 
            // btnQtdPar
            // 
            this.btnQtdPar.BackColor = System.Drawing.Color.Black;
            this.btnQtdPar.Location = new System.Drawing.Point(6, 379);
            this.btnQtdPar.Name = "btnQtdPar";
            this.btnQtdPar.Size = new System.Drawing.Size(120, 40);
            this.btnQtdPar.TabIndex = 10;
            this.btnQtdPar.Text = "Qtd Pares";
            this.btnQtdPar.UseVisualStyleBackColor = false;
            this.btnQtdPar.Click += new System.EventHandler(this.btnQtdPar_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQtdPares);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exercicio1";
            this.Text = "Exercicio1";
            this.btnQtdPares.ResumeLayout(false);
            this.btnQtdPares.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnQtdPares;
        private System.Windows.Forms.RichTextBox rchTxtFrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQtdPar;
        private System.Windows.Forms.Button btnQtdR;
        private System.Windows.Forms.Button btnQtdBrancos;
        private System.Windows.Forms.Button btnLimpar;
    }
}