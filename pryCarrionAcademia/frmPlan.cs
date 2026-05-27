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
    public partial class frmPlan : Form
    {
        int varIndice = 0;
        public string[] arrPlanes = new string[3];
        public frmPlan(string[] arrPlanesRecibido)
        {
            InitializeComponent();
            arrPlanes = arrPlanesRecibido;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlan.Text))
            {
                MessageBox.Show("Por favor, ingrese un plan válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (varIndice >= arrPlanes.Length)
            {
                MessageBox.Show("Se ha alcanzado el límite de planes registrados.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            arrPlanes[varIndice] = txtPlan.Text;
            txtPlan.Clear();
            varIndice++;
        }

        private void frmPlan_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string planesRegistrados = "Planes registrados:\n";
            for (int i = 0; i < arrPlanes.Length; i++)
            {
                if (arrPlanes[i] != null)
                {
                    planesRegistrados += $"{i + 1}. {arrPlanes[i]}\n";
                }
            }
            MessageBox.Show(planesRegistrados, "Listado de Planes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrar.PerformClick();
            }
        }
    }
}
