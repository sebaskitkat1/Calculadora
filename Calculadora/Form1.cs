using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frnBurbuja : Form
    {
        public frnBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] ordenado=new int [dgvDesordenado.RowCount-1];
            // cargar el array con los datos del datagridview
            for (int i = 0; i < dgvDesordenado.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvDesordenado.Rows[i].Cells[0].Value);
            }
        }
    }
}
