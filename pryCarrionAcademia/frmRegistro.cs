using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCarrionAcademia
{
    public partial class frmRegistro : Form
    {
        string[,] arrMaterias = new string[2, 4];
        string[] arrPlanes = new string[3];
        int indiceFila = 0;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (
               string.IsNullOrWhiteSpace(txtCodigo.Text) ||
               string.IsNullOrWhiteSpace(txtNombre.Text) ||
               lstPlan.SelectedIndex == -1
            )
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indiceFila >= arrMaterias.GetLength(0))
            {
                MessageBox.Show("Límite de materias alcanzado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            arrMaterias[indiceFila, 0] = txtCodigo.Text;
            arrMaterias[indiceFila, 1] = txtNombre.Text;
            arrMaterias[indiceFila, 2] = lstPlan.SelectedItem.ToString();
            
            if (chkActivo.Checked)
            {
                arrMaterias[indiceFila, 3] = "Activo";
            }
            else
            {
                arrMaterias[indiceFila, 3] = "Inactivo";
            }

            txtCodigo.Clear();
            txtNombre.Clear();
            lstPlan.SelectedItem = -1;
            chkActivo.Checked = false;

            indiceFila++;

            MessageBox.Show("Materia registrada exitosamente.", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblActivo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPlan frmPlan = new frmPlan(arrPlanes);
            frmPlan.arrPlanes = arrPlanes;
            frmPlan.ShowDialog();

            lstPlan.DataSource = null;
            lstPlan.DataSource = arrPlanes;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListadoMaterias frmListadoMaterias = new frmListadoMaterias(arrPlanes);
            frmListadoMaterias.arrMateriasListado = arrMaterias;

            frmListadoMaterias.ShowDialog();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
