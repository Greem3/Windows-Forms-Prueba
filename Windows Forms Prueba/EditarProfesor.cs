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
    public partial class EditarProfesor : Form
    {
        public EditarProfesor()
        {
            InitializeComponent();

        }

        private void BuscarProf_Click(object sender, EventArgs e)
        {
            LabelNameProf.Text = ComboProfSearch.Text;
            BoxNewNameProf.Text = ComboProfSearch.Text;
            PanelProfInfo.Visible = true;
        }

        private void GuardarProf_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo con un mensaje
            MessageBox.Show("Los cambios al profesor " + LabelNameProf.Text + " han sido guardados", "Guardado Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
