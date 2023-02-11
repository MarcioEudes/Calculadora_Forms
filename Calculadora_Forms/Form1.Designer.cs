
namespace Calculadora_Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Desligar = new System.Windows.Forms.Button();
            this.btn_Porcentagem = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Ponto = new System.Windows.Forms.Button();
            this.btn_Igual = new System.Windows.Forms.Button();
            this.btn_Adicao = new System.Windows.Forms.Button();
            this.lblOperador = new System.Windows.Forms.Label();
            this.layout = new System.Windows.Forms.Button();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Desligar
            // 
            this.btn_Desligar.Location = new System.Drawing.Point(12, 86);
            this.btn_Desligar.Name = "btn_Desligar";
            this.btn_Desligar.Size = new System.Drawing.Size(75, 59);
            this.btn_Desligar.TabIndex = 0;
            this.btn_Desligar.Text = "OFF";
            this.btn_Desligar.UseVisualStyleBackColor = true;
            this.btn_Desligar.Click += new System.EventHandler(this.btn_Desligar_Click);
            // 
            // btn_Porcentagem
            // 
            this.btn_Porcentagem.Location = new System.Drawing.Point(93, 86);
            this.btn_Porcentagem.Name = "btn_Porcentagem";
            this.btn_Porcentagem.Size = new System.Drawing.Size(75, 59);
            this.btn_Porcentagem.TabIndex = 1;
            this.btn_Porcentagem.Text = "%";
            this.btn_Porcentagem.UseVisualStyleBackColor = true;
            this.btn_Porcentagem.Click += new System.EventHandler(this.btn_Porcentagem_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(174, 86);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 59);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "C";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.Location = new System.Drawing.Point(255, 86);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(75, 59);
            this.btn_Divisao.TabIndex = 3;
            this.btn_Divisao.Text = " ÷";
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 151);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 59);
            this.btn_7.TabIndex = 4;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(93, 151);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 59);
            this.btn_8.TabIndex = 5;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(174, 151);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 59);
            this.btn_9.TabIndex = 6;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Location = new System.Drawing.Point(255, 151);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(75, 59);
            this.btn_Multiplicacao.TabIndex = 7;
            this.btn_Multiplicacao.Text = "X";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 216);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 59);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(93, 216);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 59);
            this.btn_5.TabIndex = 9;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(174, 216);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 59);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.Location = new System.Drawing.Point(255, 216);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(75, 59);
            this.btn_Subtracao.TabIndex = 11;
            this.btn_Subtracao.Text = "-";
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 281);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 59);
            this.btn_1.TabIndex = 12;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(93, 281);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 59);
            this.btn_2.TabIndex = 13;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(174, 281);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 59);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(12, 346);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 59);
            this.btn_0.TabIndex = 15;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_Ponto
            // 
            this.btn_Ponto.Location = new System.Drawing.Point(93, 346);
            this.btn_Ponto.Name = "btn_Ponto";
            this.btn_Ponto.Size = new System.Drawing.Size(75, 59);
            this.btn_Ponto.TabIndex = 16;
            this.btn_Ponto.Text = ".";
            this.btn_Ponto.UseVisualStyleBackColor = true;
            this.btn_Ponto.Click += new System.EventHandler(this.btn_Ponto_Click);
            // 
            // btn_Igual
            // 
            this.btn_Igual.Location = new System.Drawing.Point(174, 346);
            this.btn_Igual.Name = "btn_Igual";
            this.btn_Igual.Size = new System.Drawing.Size(75, 59);
            this.btn_Igual.TabIndex = 17;
            this.btn_Igual.Text = "=";
            this.btn_Igual.UseVisualStyleBackColor = true;
            this.btn_Igual.Click += new System.EventHandler(this.btn_Igual_Click);
            // 
            // btn_Adicao
            // 
            this.btn_Adicao.BackColor = System.Drawing.Color.Transparent;
            this.btn_Adicao.Location = new System.Drawing.Point(255, 281);
            this.btn_Adicao.Name = "btn_Adicao";
            this.btn_Adicao.Size = new System.Drawing.Size(75, 124);
            this.btn_Adicao.TabIndex = 18;
            this.btn_Adicao.Text = "+";
            this.btn_Adicao.UseVisualStyleBackColor = false;
            this.btn_Adicao.Click += new System.EventHandler(this.btn_Adicao_Click);
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.BackColor = System.Drawing.SystemColors.Control;
            this.lblOperador.Location = new System.Drawing.Point(16, 50);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(0, 13);
            this.lblOperador.TabIndex = 21;
            this.lblOperador.Visible = false;
            // 
            // layout
            // 
            this.layout.Enabled = false;
            this.layout.FlatAppearance.BorderSize = 0;
            this.layout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layout.Location = new System.Drawing.Point(3, 3);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(312, 40);
            this.layout.TabIndex = 23;
            this.layout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.layout.UseVisualStyleBackColor = true;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txt_Resultado.Location = new System.Drawing.Point(3, 45);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(302, 13);
            this.txt_Resultado.TabIndex = 19;
            this.txt_Resultado.Text = "0";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Resultado);
            this.panel1.Controls.Add(this.layout);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 68);
            this.panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(345, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.btn_Adicao);
            this.Controls.Add(this.btn_Igual);
            this.Controls.Add(this.btn_Ponto);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Porcentagem);
            this.Controls.Add(this.btn_Desligar);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Desligar;
        private System.Windows.Forms.Button btn_Porcentagem;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_Ponto;
        private System.Windows.Forms.Button btn_Igual;
        private System.Windows.Forms.Button btn_Adicao;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button layout;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Panel panel1;
    }
}

