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
    public partial class RegistrarNotaEstudiante : Form
    {

        private readonly int LocX = 26;
        private readonly int LocY = 62;
        public RegistrarNotaEstudiante()
        {
            InitializeComponent();

            PanelAca.Location = new Point(LocX, LocY);
            PanelRA.Location = new Point(LocX, LocY);
        }

        private void BuscarStudent_Click(object sender, EventArgs e)
        {
            LabelNameStudent.Text = ComboStudentSearch.Text;
            PanelStudent.Visible = true;
        }

        private void CerrarPaneles()
        {
            PanelAca.Visible = false;
            PanelRA.Visible = false;
        }

        private void TipoNotaAca_TextUpdate(object sender, EventArgs e)
        {

            if (ComboBElecAsig.Text == "Sociales")
            {
                CerrarPaneles();
                PanelAca.Visible = true;   
            }
            else if (ComboBElecAsig.Text == "Diseño y Desarrollo de Bases de Datos") {
                CerrarPaneles();
                PanelRA.Visible = true;
            }
            else
            {
                CerrarPaneles();
                Console.WriteLine("error");
            }

            PanelEditCalStudent.Visible = true;
        }

        private void GuardarNotaStudent_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo con un mensaje
            MessageBox.Show("Nota del estudiante " + LabelNameStudent.Text + " guardados", "Guardado Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void CancelNotaStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
