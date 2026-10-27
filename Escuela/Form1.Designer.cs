namespace Escuela
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
            matricula = new Label();
            nombre = new Label();
            semestre = new Label();
            nudsemestre = new NumericUpDown();
            grupo = new Label();
            especialidad = new Label();
            btnguardar = new Button();
            btnmostrar = new Button();
            btnlimpiar = new Button();
            txtespecialidad = new TextBox();
            txtgrupo = new TextBox();
            txtnombre = new TextBox();
            txtmatricula = new TextBox();
            dgvAlumnos = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nudsemestre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // matricula
            // 
            matricula.AutoSize = true;
            matricula.Location = new Point(31, 39);
            matricula.Name = "matricula";
            matricula.Size = new Size(57, 15);
            matricula.TabIndex = 0;
            matricula.Text = "Matricula";
            matricula.Click += label1_Click;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(31, 145);
            nombre.Name = "nombre";
            nombre.Size = new Size(51, 15);
            nombre.TabIndex = 1;
            nombre.Text = "Nombre";
            // 
            // semestre
            // 
            semestre.AutoSize = true;
            semestre.Location = new Point(356, 38);
            semestre.Name = "semestre";
            semestre.Size = new Size(55, 15);
            semestre.TabIndex = 2;
            semestre.Text = "Semestre";
            // 
            // nudsemestre
            // 
            nudsemestre.Location = new Point(435, 39);
            nudsemestre.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudsemestre.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudsemestre.Name = "nudsemestre";
            nudsemestre.Size = new Size(120, 23);
            nudsemestre.TabIndex = 3;
            nudsemestre.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudsemestre.ValueChanged += nudsemestre_ValueChanged;
            // 
            // grupo
            // 
            grupo.AutoSize = true;
            grupo.Location = new Point(356, 118);
            grupo.Name = "grupo";
            grupo.Size = new Size(40, 15);
            grupo.TabIndex = 4;
            grupo.Text = "Grupo";
            // 
            // especialidad
            // 
            especialidad.AutoSize = true;
            especialidad.Location = new Point(356, 199);
            especialidad.Name = "especialidad";
            especialidad.Size = new Size(72, 15);
            especialidad.TabIndex = 5;
            especialidad.Text = "Especialidad";
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(660, 41);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 6;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Location = new Point(660, 118);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(75, 23);
            btnmostrar.TabIndex = 7;
            btnmostrar.Text = "Mostrar";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(660, 191);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtespecialidad
            // 
            txtespecialidad.Location = new Point(435, 196);
            txtespecialidad.Name = "txtespecialidad";
            txtespecialidad.Size = new Size(100, 23);
            txtespecialidad.TabIndex = 9;
            // 
            // txtgrupo
            // 
            txtgrupo.Location = new Point(435, 119);
            txtgrupo.Name = "txtgrupo";
            txtgrupo.Size = new Size(100, 23);
            txtgrupo.TabIndex = 10;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(94, 145);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 11;
            // 
            // txtmatricula
            // 
            txtmatricula.Location = new Point(94, 38);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(100, 23);
            txtmatricula.TabIndex = 12;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AllowUserToAddRows = false;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(12, 271);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(776, 356);
            dgvAlumnos.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 639);
            Controls.Add(dgvAlumnos);
            Controls.Add(txtmatricula);
            Controls.Add(txtnombre);
            Controls.Add(txtgrupo);
            Controls.Add(txtespecialidad);
            Controls.Add(btnlimpiar);
            Controls.Add(btnmostrar);
            Controls.Add(btnguardar);
            Controls.Add(especialidad);
            Controls.Add(grupo);
            Controls.Add(nudsemestre);
            Controls.Add(semestre);
            Controls.Add(nombre);
            Controls.Add(matricula);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudsemestre).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label matricula;
        private Label nombre;
        private Label semestre;
        private NumericUpDown nudsemestre;
        private Label grupo;
        private Label especialidad;
        private Button btnguardar;
        private Button btnmostrar;
        private Button btnlimpiar;
        private TextBox txtespecialidad;
        private TextBox txtgrupo;
        private TextBox txtnombre;
        private TextBox txtmatricula;
        private DataGridView dgvAlumnos;
        private OpenFileDialog openFileDialog1;
    }
}
