namespace Alumnos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtGrupo = new TextBox();
            label3 = new Label();
            nudSemestre = new NumericUpDown();
            label4 = new Label();
            btnGuardar = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            txtEspecialidad = new TextBox();
            dgvAlumnos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudSemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 48);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(98, 45);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(100, 23);
            txtMatricula.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtGrupo
            // 
            txtGrupo.Location = new Point(325, 96);
            txtGrupo.Name = "txtGrupo";
            txtGrupo.Size = new Size(100, 23);
            txtGrupo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 43);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Semestre:";
            // 
            // nudSemestre
            // 
            nudSemestre.Location = new Point(325, 41);
            nudSemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudSemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSemestre.Name = "nudSemestre";
            nudSemestre.Size = new Size(120, 23);
            nudSemestre.TabIndex = 6;
            nudSemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 99);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Grupo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(518, 40);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(518, 96);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(518, 142);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 151);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Epecialidad:";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(325, 143);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(100, 23);
            txtEspecialidad.TabIndex = 11;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(23, 221);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(749, 181);
            dgvAlumnos.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAlumnos);
            Controls.Add(label5);
            Controls.Add(txtEspecialidad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(nudSemestre);
            Controls.Add(txtGrupo);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtMatricula);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Alumnos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudSemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtGrupo;
        private Label label3;
        private NumericUpDown nudSemestre;
        private Label label4;
        private Button btnGuardar;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Label label5;
        private TextBox txtEspecialidad;
        private DataGridView dgvAlumnos;
    }
}
