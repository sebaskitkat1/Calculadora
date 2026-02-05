using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calculadora.Clases;

namespace Calculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> persona = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Persona { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Fecha = dtpFecha.Value });
            MessageBox.Show("Datos Registrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                dgvMostrar.DataSource = null;
                dgvMostrar.DataSource = persona;
            }
        }
    }
}
