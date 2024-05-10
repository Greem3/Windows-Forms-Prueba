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
    public partial class RegistrarProf : Form
    {
        public RegistrarProf()
        {
            InitializeComponent();
        }

        private void RegistrarProf_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo con un mensaje
            MessageBox.Show("Profesor " + BoxNameProf.Text + " registrado", "Registro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
