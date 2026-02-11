using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formularios
{
    public partial class frmEditor : Form
    {
        Boolean saved = false;
        string path = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.opfEditor.ShowDialog();
            if (File.Exists(opfEditor.FileName))
            {
                rtbEditor.Text = File.ReadAllText(opfEditor.FileName);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!saved)
            {
                guardar();
                saved=true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardar()
        {
            if (this.sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path= sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }
    }
}
