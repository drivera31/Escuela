using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarAlumnos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // VALIDAMOS QUE LOS CAMPOS NO ESTÉN VACÍOS
            if (string.IsNullOrWhiteSpace(txtmatricula.Text) ||
                string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtgrupo.Text) ||
                string.IsNullOrWhiteSpace(txtespecialidad.Text))
            {
                MessageBox.Show(
                    "Completa todos los campos antes de guardar.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                using (OleDbConnection conexion = ConexiónBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "INSERT INTO Alumnos " +
                        "(Matricula, Nombre, Semestre, Grupo, Especialidad) " +
                        "VALUES (?, ?, ?, ?, ?)";

                    using (OleDbCommand comando =
                        new OleDbCommand(consulta, conexion))
                    {
                        // CON OLEDB IMPORTA EL ORDEN DE LOS PARÁMETROS
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtmatricula.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtnombre.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.Integer).Value = (int)nudsemestre.Value;
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtgrupo.Text.Trim();
                        comando.Parameters.Add("?", OleDbType.VarWChar, 20).Value = txtespecialidad.Text.Trim();

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Alumno guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // 1. Recargamos la tabla en tiempo real
                

                // 2. Limpiamos las cajas de texto
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            cargarAlumnos();
            LimpiarCampos();
        }

        private void cargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion = ConexiónBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT idAlumno, Matricula, Nombre, " +
                        "Semestre, Grupo, Especialidad " +
                        "FROM Alumnos ORDER BY idAlumno";

                    using (OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        dgvAlumnos.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar los datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            cargarAlumnos();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtmatricula.Clear();
            txtnombre.Clear();
            txtgrupo.Clear();
            txtespecialidad.Clear();
            nudsemestre.Value = 1;
            txtmatricula.Focus();
        }

        private void nudsemestre_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}