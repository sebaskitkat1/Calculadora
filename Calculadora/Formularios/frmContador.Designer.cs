namespace Calculadora.Formularios
{
    partial class frmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tkbVelocidad = new TrackBar();
            trmTemporizador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(150, 27);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(39, 42);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(69, 135);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(186, 135);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 23);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tkbVelocidad
            // 
            tkbVelocidad.Enabled = false;
            tkbVelocidad.Location = new Point(37, 84);
            tkbVelocidad.Maximum = 5;
            tkbVelocidad.Minimum = 1;
            tkbVelocidad.Name = "tkbVelocidad";
            tkbVelocidad.Size = new Size(259, 45);
            tkbVelocidad.TabIndex = 3;
            tkbVelocidad.Value = 1;
            tkbVelocidad.Scroll += tkbVelocidad_Scroll;
            // 
            // trmTemporizador
            // 
            trmTemporizador.Interval = 1;
            trmTemporizador.Tick += trmTemporizador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 179);
            Controls.Add(tkbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tkbVelocidad;
        private System.Windows.Forms.Timer trmTemporizador;
    }
}