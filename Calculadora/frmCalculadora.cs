using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void txtVariableA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVariableB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0, b = 0, resultado = 0;
                a = Convert.ToDouble(this.txtVariableA.Text);
                b = Convert.ToDouble(this.txtVariableB.Text);
                if (rdbSuma.Checked)
                resultado = a + b;
                if (rdbResta.Checked)
                    resultado = a - b;
                if (rdbMultiplicar.Checked)
                    resultado = a * b;
                if (rdbDivision.Checked)
                    resultado = a / b;
                    MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
