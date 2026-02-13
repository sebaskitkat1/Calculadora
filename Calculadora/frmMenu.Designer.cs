namespace Calculadora
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem1 = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            ordenamientosToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            registroAlumnosToolStripMenuItem = new ToolStripMenuItem();
            relojToolStripMenuItem = new ToolStripMenuItem();
            editorToolStripMenuItem = new ToolStripMenuItem();
            contadorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { archivoToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // archivoToolStripMenuItem1
            // 
            archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            archivoToolStripMenuItem1.Size = new Size(96, 22);
            archivoToolStripMenuItem1.Text = "Salir";
            archivoToolStripMenuItem1.Click += archivoToolStripMenuItem1_Click;
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, ordenamientosToolStripMenuItem, registroAlumnosToolStripMenuItem, relojToolStripMenuItem, editorToolStripMenuItem, contadorToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(86, 20);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(180, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // ordenamientosToolStripMenuItem
            // 
            ordenamientosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenamientosToolStripMenuItem.Name = "ordenamientosToolStripMenuItem";
            ordenamientosToolStripMenuItem.Size = new Size(180, 22);
            ordenamientosToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(115, 22);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // registroAlumnosToolStripMenuItem
            // 
            registroAlumnosToolStripMenuItem.Name = "registroAlumnosToolStripMenuItem";
            registroAlumnosToolStripMenuItem.Size = new Size(180, 22);
            registroAlumnosToolStripMenuItem.Text = "Registro Alumnos";
            registroAlumnosToolStripMenuItem.Click += registroAlumnosToolStripMenuItem_Click;
            // 
            // relojToolStripMenuItem
            // 
            relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            relojToolStripMenuItem.Size = new Size(180, 22);
            relojToolStripMenuItem.Text = "Reloj";
            relojToolStripMenuItem.Click += relojToolStripMenuItem_Click;
            // 
            // editorToolStripMenuItem
            // 
            editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            editorToolStripMenuItem.Size = new Size(180, 22);
            editorToolStripMenuItem.Text = "Editor";
            editorToolStripMenuItem.Click += editorToolStripMenuItem_Click;
            // 
            // contadorToolStripMenuItem
            // 
            contadorToolStripMenuItem.Name = "contadorToolStripMenuItem";
            contadorToolStripMenuItem.Size = new Size(180, 22);
            contadorToolStripMenuItem.Text = "Contador";
            contadorToolStripMenuItem.Click += contadorToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem ordenamientosToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem registroAlumnosToolStripMenuItem;
        private ToolStripMenuItem relojToolStripMenuItem;
        private ToolStripMenuItem editorToolStripMenuItem;
        private ToolStripMenuItem contadorToolStripMenuItem;
    }
}