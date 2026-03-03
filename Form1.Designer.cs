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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLim
            // 
            this.btnLim.Location = new System.Drawing.Point(387, 271);
            this.btnLim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLim.Name = "btnLim";
            this.btnLim.Size = new System.Drawing.Size(157, 88);
            this.btnLim.TabIndex = 0;
            this.btnLim.Text = "Limpar";
            this.btnLim.UseVisualStyleBackColor = true;
            this.btnLim.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1131, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(23, 271);
            this.btnSol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(157, 88);
            this.btnSol.TabIndex = 0;
            this.btnSol.Text = "Comparar";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(552, 271);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(157, 88);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnAdic
            // 
            this.btnAdic.Location = new System.Drawing.Point(552, 35);
            this.btnAdic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdic.Name = "btnAdic";
            this.btnAdic.Size = new System.Drawing.Size(157, 49);
            this.btnAdic.TabIndex = 0;
            this.btnAdic.Text = "Adição";
            this.btnAdic.UseVisualStyleBackColor = true;
            this.btnAdic.Click += new System.EventHandler(this.btnAdic_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.Location = new System.Drawing.Point(552, 94);
            this.btnSubt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(157, 49);
            this.btnSubt.TabIndex = 0;
            this.btnSubt.Text = "Subtração";
            this.btnSubt.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(552, 212);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(157, 49);
            this.btnDiv.TabIndex = 0;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(552, 153);
            this.btnMult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(157, 49);
            this.btnMult.TabIndex = 0;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = true;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(250, 88);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(204, 26);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(250, 141);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(204, 26);
            this.txtNum2.TabIndex = 1;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Location = new System.Drawing.Point(199, 123);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(18, 20);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(216, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "_____________________________";
            // 
            // lblSol
            // 
            this.lblSol.AutoSize = true;
            this.lblSol.Location = new System.Drawing.Point(341, 226);
            this.lblSol.Name = "lblSol";
            this.lblSol.Size = new System.Drawing.Size(18, 20);
            this.lblSol.TabIndex = 2;
            this.lblSol.Text = "?";
            // 
            // lblCachorro
            // 
            this.lblCachorro.AutoSize = true;
            this.lblCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCachorro.Location = new System.Drawing.Point(245, 9);
            this.lblCachorro.Name = "lblCachorro";
            this.lblCachorro.Size = new System.Drawing.Size(209, 40);
            this.lblCachorro.TabIndex = 3;
            this.lblCachorro.Text = "Calculadora";
            this.lblCachorro.Click += new System.EventHandler(this.lblCachorro_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Par impar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(723, 373);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnLim);
            this.Controls.Add(this.button6);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
    }
}

