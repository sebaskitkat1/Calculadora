namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            label2 = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            this.rdbSuma = new RadioButton();
            this.rdbResta = new RadioButton();
            rdbMultiplicar = new RadioButton();
            this.rdbDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 23);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Variable A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Variable B";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(60, 45);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(196, 23);
            txtVariableA.TabIndex = 2;
            txtVariableA.TextChanged += txtVariableA_TextChanged;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(56, 127);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(200, 23);
            txtVariableB.TabIndex = 3;
            txtVariableB.TextChanged += txtVariableB_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(490, 38);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(98, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(492, 95);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 30);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.rdbDivision);
            groupBox1.Controls.Add(rdbMultiplicar);
            groupBox1.Controls.Add(this.rdbResta);
            groupBox1.Controls.Add(this.rdbSuma);
            groupBox1.Location = new Point(273, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 127);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new Point(20, 22);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new Size(55, 19);
            this.rdbSuma.TabIndex = 0;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "Suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new Point(20, 47);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new Size(53, 19);
            this.rdbResta.TabIndex = 1;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "Resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += this.radioButton2_CheckedChanged;
            // 
            // rdbMultiplicar
            // 
            rdbMultiplicar.AutoSize = true;
            rdbMultiplicar.Location = new Point(20, 70);
            rdbMultiplicar.Name = "rdbMultiplicar";
            rdbMultiplicar.Size = new Size(101, 19);
            rdbMultiplicar.TabIndex = 2;
            rdbMultiplicar.TabStop = true;
            rdbMultiplicar.Text = "Multiplicacion";
            rdbMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbDivision
            // 
            this.rdbDivision.AutoSize = true;
            this.rdbDivision.Location = new Point(20, 95);
            this.rdbDivision.Name = "rdbDivision";
            this.rdbDivision.Size = new Size(67, 19);
            this.rdbDivision.TabIndex = 3;
            this.rdbDivision.TabStop = true;
            this.rdbDivision.Text = "Division";
            this.rdbDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 216);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdbSuma;
        private RadioButton rdbResta;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton rdbMultiplicar;
        private RadioButton rdbDivision;
    }
}