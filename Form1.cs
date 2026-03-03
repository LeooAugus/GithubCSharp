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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtNum1.Text);
                double b = double.Parse(txtNum2.Text);

            }
            catch (FormatException) 
            {
                MessageBox.Show("Valor inválido.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdic_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCachorro_Click(object sender, EventArgs e)
        {

        }
    }
}
