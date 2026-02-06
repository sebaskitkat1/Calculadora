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
                verificarRegistros();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verificarRegistros()
        {
            if (persona.Count == 0)
                btnEliminar.Enabled = false;
            else
                btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvMostrar.CurrentRow.Index);
            dgvMostrar.DataSource = null; // Limpiar el DataSource para refrescar la vista
            dgvMostrar.DataSource = persona; // Volver a asignar el DataSource para mostrar los cambios
            verificarRegistros(); // Verificar si aún hay registros después de eliminar
        }
    }
}
