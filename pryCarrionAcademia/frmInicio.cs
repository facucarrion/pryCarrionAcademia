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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            this.Hide();
            frmRegistro.ShowDialog();  
            this.Close();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();  
            this.Hide();
            frmAlumno.ShowDialog();
            this.Close();
        }
    }
}
