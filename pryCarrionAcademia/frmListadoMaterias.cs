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
    public partial class frmListadoMaterias : Form
    {
        string[] arrPlanes = new string[3];
        public string[,] arrMateriasListado = new string[2, 4];

        public frmListadoMaterias(string[] arrPlanesRecibido)
        {
            InitializeComponent();

            lstPlan.DataSource = arrPlanesRecibido;
        }

        private void frmListadoMaterias_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvMaterias.Rows.Clear();

            if (!optTodo.Checked && !optCodigo.Checked && !optNombre.Checked && !optPlan.Checked)
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (optTodo.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                }
            } if (optCodigo.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 0] == txtCodigo.Text)
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            } if (optNombre.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 1] == txtNombre.Text)
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            } if (optPlan.Checked)
            {
                for (int i = 0; i < arrMateriasListado.GetLength(0); i++)
                {
                    if (arrMateriasListado[i, 2] == lstPlan.SelectedItem.ToString())
                    {
                        dgvMaterias.Rows.Add(arrMateriasListado[i, 0], arrMateriasListado[i, 1], arrMateriasListado[i, 2], arrMateriasListado[i, 3]);
                    }
                }
            }
        }
    }
}
