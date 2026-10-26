using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validamos que los campos de textos no estén vacios
            if (string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtGrupo.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show(
                    "Completa todos los campox antes de guardar.",
                    "Datos incompleto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            //Obtenemos los datos del formulario

            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "INSERT INTO Alumno " +
                        "(Matricula,Nombre, Semestre, Grupo, Especialidad) " +
                        "VALUES (? ,? ,? ,?, ?)";
                    using (OleDbCommand comando =
                        new OleDbCommand(consulta, conexion))
                    {
                        //Con OleDB importa el orden de los parámetros
                        comando.Parameters.Add(
                            "?", OleDbType.VarWChar, 20
                            ).Value = txtMatricula.Text.Trim(); //Text.Trim borra los espacios sobrantes

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = txtNombre.Text.Trim();

                        comando.Parameters.Add(
                           "?", OleDbType.Integer
                           ).Value = (int)nudSemestre.Value;

                        comando.Parameters.Add(
                           "?", OleDbType.VarWChar, 20
                           ).Value = txtGrupo.Text.Trim();

                        comando.Parameters.Add(
                          "?", OleDbType.VarWChar, 20
                          ).Value = txtEspecialidad.Text.Trim();

                        comando.ExecuteNonQuery();  //Para que se ejecute la instruccion sql

                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al guardar el alumno: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
        private void CargarAlumnos()
        {
            try
            {
                using (OleDbConnection conexion =
                    ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string consulta =
                        "SELECT idAlumno, Matricula, Nombre," +
                        "Semestre, Grupo, Especialidad " +
                        "FROM Alumno Order By IdAlumno";
                    using (OleDbDataAdapter adaptador =
                        new OleDbDataAdapter(consulta, conexion))
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
                $"Error al guardar el alumno: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
