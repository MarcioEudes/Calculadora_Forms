using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Forms
{
    public partial class Form1 : Form
    {
        double primeiroValor = 0, segundoValor = 0, resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            SobreporZeroInicial();
            txt_Resultado.Text += "9";
        }

        private void btn_Ponto_Click(object sender, EventArgs e)
        {
            PermitirApenasUmPonto();
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            string opcão = lblOperador.Text;

            segundoValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);

            switch (opcão)
            {
                case "+": Adicao(); break;
                case "-": Subtracao(); break;
                case "x": Multiplicacao(); break;
                case "÷": Divisao(); break;
                case "%": Porcentagem(); break;
            }

            layout.Text = resultado.ToString();
            txt_Resultado.Text = "0";
            lblOperador.Text = string.Empty;
            primeiroValor = 0;
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Desligar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            try
            {

                if (primeiroValor == 0)
                {
                    primeiroValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                    GarantirOperacaoSequecial();
                    lblOperador.Text = "+";
                    layout.Text = $"{primeiroValor} + ";
                    txt_Resultado.Text = "0";
                }
                else
                {
                    segundoValor = double.Parse(txt_Resultado.Text);
                    Adicao();
                    layout.Text = $"{resultado} + ";
                    primeiroValor = resultado;
                }
            }
            catch (Exception)
            {
                layout.Text = "ERRO";
            }
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                if(primeiroValor == 0)
                {
                    primeiroValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                    GarantirOperacaoSequecial();
                    lblOperador.Text = "-";
                    layout.Text = $"{primeiroValor} - ";
                    txt_Resultado.Text = string.Empty;
                }
                else
                {
                    segundoValor = double.Parse(txt_Resultado.Text);
                    Subtracao();
                    layout.Text = $"{resultado} - ";
                    primeiroValor = resultado;
                } 
            }
            catch (Exception)
            {
                layout.Text = "ERRO";
            } 
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                if (primeiroValor == 0)
                {
                    primeiroValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                    GarantirOperacaoSequecial();
                    lblOperador.Text = "x";
                    layout.Text = $"{primeiroValor} x ";
                    txt_Resultado.Text = string.Empty;
                }
                else
                {
                    segundoValor = double.Parse(txt_Resultado.Text);
                    Multiplicacao();
                    layout.Text = $"{resultado} x ";
                    primeiroValor = resultado;
                }
            }
            catch (Exception)
            {
                layout.Text = "ERRO";
            }
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                if (primeiroValor == 0)
                {
                    primeiroValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                    GarantirOperacaoSequecial();
                    lblOperador.Text = "÷";
                    layout.Text = $"{primeiroValor} ÷ ";
                    txt_Resultado.Text = string.Empty;
                }
                else
                {
                    segundoValor = double.Parse(txt_Resultado.Text);
                    Divisao();
                    layout.Text = $"{resultado} ÷ ";
                    primeiroValor = resultado;
                }
            }
            catch (Exception)
            {
                layout.Text = "ERRO";
            }
        }

        private void btn_Porcentagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (primeiroValor == 0)
                {
                    primeiroValor = double.Parse(txt_Resultado.Text, CultureInfo.InvariantCulture);
                    GarantirOperacaoSequecial();
                    lblOperador.Text = "%";
                    layout.Text = $"{primeiroValor} % ";
                    txt_Resultado.Text = string.Empty;
                }
                else
                {
                    segundoValor = double.Parse(txt_Resultado.Text);
                    Porcentagem();
                    layout.Text = $"{resultado} % ";
                    primeiroValor = resultado;
                }
            }
            catch (Exception)
            {
                layout.Text = "ERRO";
            }
        }

        public void Limpar()
        {
            primeiroValor = 0;
            segundoValor = 0;
            txt_Resultado.Text = "0";
            lblOperador.Text = string.Empty;
            layout.Text = string.Empty;
        }

        public void Adicao()
        {
            txt_Resultado.Text = "0";
            resultado = primeiroValor + segundoValor;
        }

        public void Subtracao()
        {
            txt_Resultado.Text = "0";
            resultado = primeiroValor - segundoValor;
        }

        public void Multiplicacao()
        {
            txt_Resultado.Text = "0";
            resultado = primeiroValor * segundoValor;
        }

        public void Divisao()
        {
            txt_Resultado.Text = "0";
            resultado = primeiroValor / segundoValor;
        }

        public void Porcentagem()
        {
            txt_Resultado.Text = "0";
            resultado = (primeiroValor / 100) * segundoValor;
        }

        public void SobreporZeroInicial()
        {
            if (txt_Resultado.Text.StartsWith("0") && txt_Resultado.Text.EndsWith("0"))
            {
                txt_Resultado.Text = string.Empty;
            }
        }

        public void PermitirApenasUmPonto()
        {
            if (txt_Resultado.Text.Contains("."))
            {
                txt_Resultado.Text.Replace('.', '.');
            }
            else
            {
                txt_Resultado.Text += ".";
            }
        }

        public void GarantirOperacaoSequecial()
        {
            if (txt_Resultado.Text == "0")
            {
                primeiroValor = resultado;
            }
        }

    }
}
