using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtEscolha.Text);
            num2 = Convert.ToDouble(txtEscolha2.Text);
            resultado = num1 + num2;
            txtResult.Text = resultado.ToString();
            MessageBox.Show($"O resultado do cálculo é: {resultado}", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtEscolha.Text);
            num2 = Convert.ToDouble(txtEscolha2.Text);
            resultado = num1 - num2;
            txtResult.Text = resultado.ToString();
            MessageBox.Show($"O resultado do cálculo é: {resultado}", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtEscolha.Text);
            num2 = Convert.ToDouble(txtEscolha2.Text);
            resultado = num1 * num2;
            txtResult.Text = resultado.ToString();
            MessageBox.Show($"O resultado do cálculo é: {resultado}", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtEscolha.Text);
            num2 = Convert.ToDouble(txtEscolha2.Text);
            resultado = num1 / num2;
            txtResult.Text = resultado.ToString();
            MessageBox.Show($"O resultado do cálculo é: {resultado}", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtEscolha.Text = "";
            txtEscolha2.Text = "";
            txtResult.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
