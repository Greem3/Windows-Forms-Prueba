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
    public partial class InterfazCentroADMIN : Form
    {
        public InterfazCentroADMIN(string NombreFormActual, string UsuarioActual)
        {
            InitializeComponent();

            if ((NombreFormActual != "") & (NombreFormActual != null))
            {
                this.Text = NombreFormActual + " - " + UsuarioActual;
            }
            else
            {
                this.Text = "Centro Educativo";
            }

            LabelUserWelcome.Text = "¡Hola " + UsuarioActual + "!";

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


        private void MostrarContenido(Panel contenido)
        {
            // Ocultar todos los controles
            PanelWelcome.Visible = false;
            PanelListProfs.Visible = false;
            // Mostrar el contenido deseado
            contenido.Visible = true;
        }

        private void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarContenido(PanelWelcome);
        }

        private void ListProfsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarContenido(PanelListProfs);
        }

    }
}
