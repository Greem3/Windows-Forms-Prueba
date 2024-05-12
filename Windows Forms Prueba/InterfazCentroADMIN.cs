using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.DataFormats;

namespace Windows_Forms_Prueba
{
    public partial class InterfazCentroADMIN : Form
    {

        public int DrawingX = 171;
        public int DrawingY = 29;

        public ToolStripMenuItem Logout = new ToolStripMenuItem("Cerrar Sesion");
        public ToolStripMenuItem MenuInicio = new ToolStripMenuItem("Inicio");

        public InterfazCentroADMIN(string NombreFormActual, string UsuarioActual)
        {
            InitializeComponent();

            LabelUserWelcome.Text = "¡Hola " + UsuarioActual + "!";

            Logout.ForeColor = Color.White;
            Logout.Enabled = true;
            MenuInicio.ForeColor = Color.White;
            MenuInicio.Enabled = true;
            Logout.Click += new EventHandler(CambiarALogin_Click);

            PanelWelcome.Location = new Point(DrawingX, DrawingY);
            PanelStudents.Location = new Point(DrawingX, DrawingY);
            PanelProfList.Location = new Point(DrawingX, DrawingY);
            PanelCursoList.Location = new Point(DrawingX, DrawingY);
            PanelListAsig.Location = new Point(DrawingX, DrawingY);
            PanelStudentAccount.Location = new Point(DrawingX, DrawingY);
            PanelCalRAs.Location = new Point(8, 163);

            if ((NombreFormActual != "") & (NombreFormActual != null))
            {
                this.Text = NombreFormActual + " - " + UsuarioActual;
            }
            else
            {
                this.Text = "Centro Educativo - " + UsuarioActual;
            }
            
            if (UsuarioActual == "ADMINPOMARAY")
            {
                LabelRole.Text = "Admin";
            }
            else if ((UsuarioActual == "Jose Luis") | (UsuarioActual == "Profesor")) {
                LabelRole.Text = "Profesor";
                MenuPag.Items.Clear();

                ToolStripMenuItem EstudianteEl = new ToolStripMenuItem("Estudiantes");
                EstudianteEl.ForeColor = Color.White;
                EstudianteEl.Enabled = true;
                MenuPag.Items.Add(MenuInicio);
                MenuPag.Items.Add(EstudianteEl);
                MenuPag.Items.Add(Logout);

                ToolStripMenuItem StudentListEl = new ToolStripMenuItem("Lista de Estudiantes");
                ToolStripMenuItem AddCalStudent = new ToolStripMenuItem("Registrar Nota A Estudiante");
                StudentListEl.Click += new EventHandler(MostrarListaStudents_Click);
                AddCalStudent.Click += new EventHandler(RegNotaEstudianteWindow_Click);
                EstudianteEl.DropDownItems.Add(StudentListEl);
                EstudianteEl.DropDownItems.Add(AddCalStudent);
            }
            else
            {
                LabelRole.Text = "Estudiante";
                MenuPag.Items.Clear();
                MenuPag.Items.Add(Logout);
                NotVPanels();
                PanelStudentAccount.Visible = true;
            }

        }

        private void NotVPanels()
        {
            PanelWelcome.Visible = false;
            PanelStudents.Visible = false;
            PanelProfList.Visible = false;
            PanelCursoList.Visible = false;
            PanelListAsig.Visible = false;
            PanelStudentAccount.Visible = false;
        }

        private void MostrarBienvenida_Click(object sender, EventArgs e)
        {
            NotVPanels();
            PanelWelcome.Visible = true;
        }

        private void MostrarListaProfesores_Click(object sender, EventArgs e)
        {
            NotVPanels();
            PanelProfList.Visible = true;
        }

        private void MostrarListaStudents_Click(object sender, EventArgs e)
        {
            NotVPanels();
            PanelStudents.Visible = true;
        }

        private void MostrarListaClass_Click(object sender, EventArgs e)
        {
            NotVPanels();
            PanelCursoList.Visible = true;
        }

        private void MostrarListaAsig_Click(object sender, EventArgs e)
        {
            NotVPanels();
            PanelListAsig.Visible = true;
        }

        private void CerrarAsig()
        {
            DGVAcas.Visible = false;
            PanelCalRAs.Visible = false;
            DGVRAs.Visible = false;
        }

        private void VerCalAsig_TextUpdate(object sender, EventArgs e)
        {

            CerrarAsig();

            if (ComboBElecAsig.Text == "Sociales")
            {
                DGVAcas.Visible = true;
            }
            else
            {
                PanelCalRAs.Visible = true;
            }
        }

        private void VerRA_TextUpdate(object sender, EventArgs e)
        {
            DGVRAs.Visible = true;
        }

        private void CambiarALogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                LoginCentro FormularioAbrir = new LoginCentro();
                FormularioAbrir.Show();
                //Cerrar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void EditProfWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                EditarProfesor FormularioAbrir = new EditarProfesor();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void EditStudentWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                EditarEstudiante FormularioAbrir = new EditarEstudiante();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void EditCursoWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                EditarCurso FormularioAbrir = new EditarCurso();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void EditAsignaturaWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                EditarAsignatura FormularioAbrir = new EditarAsignatura();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void RegProfWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                RegistrarProf FormularioAbrir = new RegistrarProf();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void RegEstudianteWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                RegistrarEstudiante FormularioAbrir = new RegistrarEstudiante();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void RegAsigWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                RegistrarAsignatura FormularioAbrir = new RegistrarAsignatura();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void RegCursoWindow_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                RegistrarCurso FormularioAbrir = new RegistrarCurso();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void RegNotaEstudianteWindow_Click(object sender, EventArgs e)
        {
            try
            {
                RegistrarNotaEstudiante FormularioAbrir = new RegistrarNotaEstudiante();
                FormularioAbrir.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

    }
}
