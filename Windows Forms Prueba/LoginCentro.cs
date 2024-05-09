using System.Security.Cryptography.X509Certificates;

namespace Windows_Forms_Prueba
{
    public partial class LoginCentro : Form
    {
        public LoginCentro()
        {
            InitializeComponent();

        }

        // Cuando la caja de texto esta en focus cambia el texto de LabelCentro al que esta especificado.
        private void EntrarACaja_Enter(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                // Mostrar el mensaje cuando el TextBox entra en foco
                LabelCentro.Text = "Centro Educativo:";
            }
        }

        // Cuando la caja de texto NO esta en focus cambia el texto de LabelCentro al que esta especificado.
        private void SalirDeCaja_Leave(object? sender, EventArgs e)
        {

            if (sender != null)
            {
                // Ocultar el mensaje cuando el TextBox pierde el foco
                LabelCentro.Text = "";
            }
        }

        private void EntrarAPass_Enter(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                // Mostrar el mensaje cuando el TextBox entra en foco
                LabelPassword.Text = "Contraseña:";
            }
        }

        private void SalirDePass_Leave(object? sender, EventArgs e)
        {

            if (sender != null)
            {
                // Ocultar el mensaje cuando el TextBox pierde el foco
                LabelPassword.Text = "";
            }
        }

        private void EntrarAUser_Enter(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                // Mostrar el mensaje cuando el TextBox entra en foco
                LabelUser.Text = "Usuario:";
            }
        }

        private void SalirDeUser_Leave(object? sender, EventArgs e)
        {

            if (sender != null)
            {
                // Ocultar el mensaje cuando el TextBox pierde el foco
                LabelUser.Text = "";
            }
        }

        private void IniciandoSesion_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                InterfazCentroADMIN FormularioAbrir = new InterfazCentroADMIN(BoxCentro.Text, BoxUser.Text);
                FormularioAbrir.Show();
                //Cerrar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

        private void CambiarARegistro_Click(object sender, EventArgs e)
        {
            try
            {
                //Abrir el Formulario de interfaz
                RegisterLogin FormularioAbrir = new RegisterLogin();
                FormularioAbrir.Show();
                //Cerrar el formulario actual
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el nuevo formulario: " + ex.Message);
            }
        }

    }
}