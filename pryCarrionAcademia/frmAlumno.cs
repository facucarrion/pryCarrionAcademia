using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionAcademia
{
    public partial class frmAlumno : Form
    {

        string[,] arrAlumnos = new string[2, 8];  
        int indiceFila = 0;

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void lblNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void lblContacto_Click(object sender, EventArgs e)
        {

        }

        private void gbAlumno_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtContacto.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indiceFila >= arrAlumnos.GetLength(0))
            {
                MessageBox.Show("Límite de alumnos alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            arrAlumnos[indiceFila, 0] = txtDni.Text;
            arrAlumnos[indiceFila, 1] = txtNombre.Text;
            arrAlumnos[indiceFila, 2] = txtApellido.Text;
            arrAlumnos[indiceFila, 3] = txtDireccion.Text;
            arrAlumnos[indiceFila, 4] = txtContacto.Text;
            arrAlumnos[indiceFila, 5] = dtNacimiento.Value.ToString("dd/MM/yyyy");
            arrAlumnos[indiceFila, 6] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            arrAlumnos[indiceFila, 7] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            indiceFila++;

            MessageBox.Show("Alumno registrado exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDni.Clear();
            txtContacto.Clear();
            dtNacimiento.Format = DateTimePickerFormat.Custom;
            dtNacimiento.CustomFormat = " ";
        }

        private void dtNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtNacimiento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arrAlumnos.GetLength(0); i++)
            {
                string texto =
    "DATOS DEL ALUMNO\n\n" +
    "DNI: " + arrAlumnos[i, 0] + "\n" +
    "Nombre: " + arrAlumnos[i, 1] + "\n" +
    "Apellido: " + arrAlumnos[i, 2] + "\n" +
    "Dirección: " + arrAlumnos[i, 3] + "\n" +
    "Contacto: " + arrAlumnos[i, 4] + "\n" +
    "Fecha nacimiento: " + arrAlumnos[i, 5] + "\n" +
    "Fecha registro: " + arrAlumnos[i, 6] + "\n" +
    "Última actualización: " + arrAlumnos[i, 7];

                MessageBox.Show(texto, "Alumno registrado");
            }
        }
    }
}
