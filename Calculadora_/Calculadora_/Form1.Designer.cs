namespace Calculadora_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtEscolha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEscolha2 = new System.Windows.Forms.TextBox();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA";
            // 
            // txtEscolha
            // 
            this.txtEscolha.Location = new System.Drawing.Point(181, 93);
            this.txtEscolha.Name = "txtEscolha";
            this.txtEscolha.Size = new System.Drawing.Size(261, 20);
            this.txtEscolha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o 1º número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ESCOLHA A OPERAÇÃO";
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(126, 203);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(97, 60);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(263, 203);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(97, 60);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(126, 269);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(97, 60);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(263, 269);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(97, 60);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 348);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(316, 20);
            this.txtResult.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insira o 2º número";
            // 
            // txtEscolha2
            // 
            this.txtEscolha2.Location = new System.Drawing.Point(181, 130);
            this.txtEscolha2.Name = "txtEscolha2";
            this.txtEscolha2.Size = new System.Drawing.Size(261, 20);
            this.txtEscolha2.TabIndex = 10;
            // 
            // btnLimp
            // 
            this.btnLimp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimp.Location = new System.Drawing.Point(126, 385);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(97, 45);
            this.btnLimp.TabIndex = 12;
            this.btnLimp.Text = "Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(263, 385);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 442);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEscolha2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEscolha);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEscolha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEscolha2;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnSair;
    }
}

