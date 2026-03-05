using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GithubCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtNum1.Text);
                double b = double.Parse(txtNum2.Text);
                double result;

                if (lblOper.Text == "+")
                {
                    result = a + b;
                    lblSol.Text = result.ToString();
                }
                else if (lblOper.Text == "-")
                {
                    result = a - b;
                    lblSol.Text = result.ToString();
                }
                else if (lblOper.Text == "*")
                {
                    result = a * b;
                    lblSol.Text = result.ToString();
                }
                else if (lblOper.Text == "/")
                {
                    result = a / b;
                    lblSol.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("Operação inválida.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor inválido.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero.");
            }

        }

        private void button3_Click(object sender, EventArgs e) // Botão Limpar
        {
            lblOper.Text = "?";
            lblSol.Text = "?";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdic_Click(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void lblCachorro_Click(object sender, EventArgs e)
        {

        }

        private void lblOper_Click(object sender, EventArgs e)
        {

        }

        private void btnSubt_Click(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblOper.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result;

                if (lblOper.Text == "+")
                {
                    result = num1 + num2;
                    lblSol.Text = result.ToString();
                    if (result % 2 == 0)
                    {
                        MessageBox.Show($"{result} é par.");
                    }
                    else
                    {
                        MessageBox.Show($"{result} é ímpar.");
                    }
                }
                else if (lblOper.Text == "-")
                {
                    result = num1 - num2;
                    lblSol.Text = result.ToString();
                    if (result % 2 == 0)
                    {
                        MessageBox.Show($"{result} é par.");
                    }
                    else
                    {
                        MessageBox.Show($"{result} é ímpar.");
                    }
                }
                else if (lblOper.Text == "*")
                {
                    result = num1 * num2;
                    lblSol.Text = result.ToString();
                    if (result % 2 == 0)
                    {
                        MessageBox.Show($"{result} é par.");
                    }
                    else
                    {
                        MessageBox.Show($"{result} é ímpar.");
                    }
                }
                else if (lblOper.Text == "/")
                {
                    result = num1 / num2;
                    lblSol.Text = result.ToString();
                    if (result % 2 == 0)
                    {
                        MessageBox.Show($"{result} é par.");
                    }
                    else
                    {
                        MessageBox.Show($"{result} é ímpar.");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor inválido.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível dividir por zero.");
            }
        }
    }
}
