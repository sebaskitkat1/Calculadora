using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = "";
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void trmHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            string ruta = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Sonidos", "gallito.wav");
            if (lblHora.Text == alarma1)
            {
                SoundPlayer sonido = new SoundPlayer(ruta);
                sonido.PlaySync();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora: ", "Sistema", "00:00:00 x.x");
        }

        private void frmTemporizadores_Load(object sender, EventArgs e)
        {

        }
    }
}
