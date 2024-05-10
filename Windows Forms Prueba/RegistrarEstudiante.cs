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
    public partial class RegistrarEstudiante : Form
    {
        public RegistrarEstudiante()
        {
            InitializeComponent();
        }

        private void RegistrarStudent_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo con un mensaje
            MessageBox.Show("Estudiante " + BoxStudentName.Text + " registrado", "Registro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
