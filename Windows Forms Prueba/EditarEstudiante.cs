using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Prueba
{
    public partial class EditarEstudiante : Form
    {
        public EditarEstudiante()
        {
            InitializeComponent();
        }

        private void BuscarStudent_Click(object sender, EventArgs e)
        {
            LabelNameStudent.Text = ComboStudentSearch.Text;
            BoxNewStudentName.Text = ComboStudentSearch.Text;
            PanelEditStudent.Visible = true;
        }

        private void GuardarStudent_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo con un mensaje
            MessageBox.Show("Los cambios al estudiante " + LabelNameStudent.Text + " han sido guardados", "Guardado Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
