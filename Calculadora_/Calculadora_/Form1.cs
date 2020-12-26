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
            if (txtEscolha.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEscolha2.Text == "") 
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else 
            {
                double num1, num2, resultado;
                num1 = Convert.ToDouble(txtEscolha.Text);
                num2 = Convert.ToDouble(txtEscolha2.Text);
                resultado = num1 + num2;
                txtResult.Text = resultado.ToString();
                MessageBox.Show($"Resultado do cálculo: {resultado}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtEscolha.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEscolha2.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double num1, num2, resultado;
                num1 = Convert.ToDouble(txtEscolha.Text);
                num2 = Convert.ToDouble(txtEscolha2.Text);
                resultado = num1 - num2;
                txtResult.Text = resultado.ToString();
                MessageBox.Show($"Resultado do cálculo: {resultado}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtEscolha.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEscolha2.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double num1, num2, resultado;
                num1 = Convert.ToDouble(txtEscolha.Text);
                num2 = Convert.ToDouble(txtEscolha2.Text);
                resultado = num1 * num2;
                txtResult.Text = resultado.ToString();
                MessageBox.Show($"Resultado do cálculo: {resultado}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtEscolha.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEscolha2.Text == "")
            {
                MessageBox.Show("Digite todos os valores", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                double num1, num2, resultado;
                num1 = Convert.ToDouble(txtEscolha.Text);
                num2 = Convert.ToDouble(txtEscolha2.Text);
                resultado = num1 / num2;
                txtResult.Text = resultado.ToString();
                MessageBox.Show($"Resultado do cálculo: {resultado}", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
