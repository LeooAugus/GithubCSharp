namespace GithubCSharp
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
            this.btnLim = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAdic = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSol = new System.Windows.Forms.Label();
            this.lblCachorro = new System.Windows.Forms.Label();
            this.btnParImpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(250, 176);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(105, 57);
            this.btnLim.TabIndex = 0;
            this.btnLim.Text = "Limpar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(754, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 20);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(12, 176);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(105, 57);
            this.btnSol.TabIndex = 0;
            this.btnSol.Text = "Comparar";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(368, 176);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(105, 57);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdic
            // 
            this.btnAdic.Location = new System.Drawing.Point(368, 23);
            this.btnAdic.Name = "btnAdic";
            this.btnAdic.Size = new System.Drawing.Size(105, 32);
            this.btnAdic.TabIndex = 0;
            this.btnAdic.Text = "Adição";
            this.btnAdic.UseVisualStyleBackColor = true;
            this.btnAdic.Click += new System.EventHandler(this.btnAdic_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.Location = new System.Drawing.Point(368, 61);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(105, 32);
            this.btnSubt.TabIndex = 0;
            this.btnSubt.Text = "Subtração";
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.btnSubt_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(368, 138);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(105, 32);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(368, 99);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(105, 32);
            this.btnMult.TabIndex = 0;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(167, 57);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(137, 20);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(167, 92);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(137, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(128, 69);
            this.lblOper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(19, 20);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "?";
            this.lblOper.Click += new System.EventHandler(this.lblOper_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(144, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "_____________________________";
            // 
            // lblSol
            // 
            this.lblSol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSol.Location = new System.Drawing.Point(147, 138);
            this.lblSol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(178, 17);
            this.lblSol.TabIndex = 2;
            this.lblSol.Text = "?";
            this.lblSol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCachorro
            // 
            this.lblCachorro.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCachorro.Location = new System.Drawing.Point(169, 9);
            this.lblCachorro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCachorro.Name = "lblCachorro";
            this.lblCachorro.Size = new System.Drawing.Size(135, 27);
            this.lblCachorro.TabIndex = 3;
            this.lblCachorro.Text = "Calculadora";
            this.lblCachorro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCachorro.Click += new System.EventHandler(this.lblCachorro_Click);
            // 
            // btnParImpar
            // 
            this.btnParImpar.Location = new System.Drawing.Point(132, 176);
            this.btnParImpar.Name = "btnParImpar";
            this.btnParImpar.Size = new System.Drawing.Size(102, 57);
            this.btnParImpar.TabIndex = 4;
            this.btnParImpar.Text = "Par Impar";
            this.btnParImpar.UseVisualStyleBackColor = true;
            this.btnParImpar.Click += new System.EventHandler(this.btnParImpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 242);
            this.Controls.Add(this.btnParImpar);
            this.Controls.Add(this.lblCachorro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSol);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSubt);
            this.Controls.Add(this.btnAdic);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.button6);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLim;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAdic;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSol;
        private System.Windows.Forms.Label lblCachorro;
        private System.Windows.Forms.Button btnParImpar;
    }
}

