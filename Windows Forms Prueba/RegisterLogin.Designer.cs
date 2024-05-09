namespace Windows_Forms_Prueba
{
    partial class RegisterLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterLogin));
            BoxRegCentro = new TextBox();
            BoxRegEmail = new TextBox();
            BoxRegPass = new TextBox();
            BoxRegUbicacion = new TextBox();
            BoxRegRECPass = new TextBox();
            ButtonRegCentro = new Button();
            LabelRegCuenta = new Label();
            ButtonRegInicio = new Button();
            pictureBox1 = new PictureBox();
            BoxRegUserAdmin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BoxRegCentro
            // 
            BoxRegCentro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegCentro.Location = new Point(680, 409);
            BoxRegCentro.Name = "BoxRegCentro";
            BoxRegCentro.PlaceholderText = "Nombre Centro Educativo";
            BoxRegCentro.Size = new Size(307, 34);
            BoxRegCentro.TabIndex = 0;
            // 
            // BoxRegEmail
            // 
            BoxRegEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegEmail.Location = new Point(680, 484);
            BoxRegEmail.Name = "BoxRegEmail";
            BoxRegEmail.PlaceholderText = "Correo Electronico";
            BoxRegEmail.Size = new Size(307, 34);
            BoxRegEmail.TabIndex = 3;
            // 
            // BoxRegPass
            // 
            BoxRegPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegPass.Location = new Point(680, 557);
            BoxRegPass.Name = "BoxRegPass";
            BoxRegPass.PasswordChar = '*';
            BoxRegPass.PlaceholderText = "Contraseña";
            BoxRegPass.Size = new Size(307, 34);
            BoxRegPass.TabIndex = 4;
            // 
            // BoxRegUbicacion
            // 
            BoxRegUbicacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegUbicacion.Location = new Point(1042, 484);
            BoxRegUbicacion.Name = "BoxRegUbicacion";
            BoxRegUbicacion.PlaceholderText = "Ubicación";
            BoxRegUbicacion.Size = new Size(307, 34);
            BoxRegUbicacion.TabIndex = 5;
            // 
            // BoxRegRECPass
            // 
            BoxRegRECPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegRECPass.Location = new Point(1042, 557);
            BoxRegRECPass.Name = "BoxRegRECPass";
            BoxRegRECPass.PasswordChar = '*';
            BoxRegRECPass.PlaceholderText = "Confirmar Contraseña";
            BoxRegRECPass.Size = new Size(307, 34);
            BoxRegRECPass.TabIndex = 6;
            // 
            // ButtonRegCentro
            // 
            ButtonRegCentro.ForeColor = Color.Black;
            ButtonRegCentro.Location = new Point(866, 636);
            ButtonRegCentro.Name = "ButtonRegCentro";
            ButtonRegCentro.Size = new Size(303, 29);
            ButtonRegCentro.TabIndex = 7;
            ButtonRegCentro.Text = "Crear Centro";
            ButtonRegCentro.UseVisualStyleBackColor = true;
            // 
            // LabelRegCuenta
            // 
            LabelRegCuenta.AutoSize = true;
            LabelRegCuenta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRegCuenta.Location = new Point(866, 683);
            LabelRegCuenta.Name = "LabelRegCuenta";
            LabelRegCuenta.Size = new Size(311, 23);
            LabelRegCuenta.TabIndex = 8;
            LabelRegCuenta.Text = "¿Ya tu centro educativo está agregado?";
            // 
            // ButtonRegInicio
            // 
            ButtonRegInicio.ForeColor = Color.Black;
            ButtonRegInicio.Location = new Point(870, 720);
            ButtonRegInicio.Name = "ButtonRegInicio";
            ButtonRegInicio.Size = new Size(299, 29);
            ButtonRegInicio.TabIndex = 9;
            ButtonRegInicio.Text = "Iniciar Sesión";
            ButtonRegInicio.UseVisualStyleBackColor = true;
            ButtonRegInicio.Click += CambiarASesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Kopier_Analysts_Logo_WF;
            pictureBox1.Location = new Point(929, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 162);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BoxRegUserAdmin
            // 
            BoxRegUserAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BoxRegUserAdmin.Location = new Point(1042, 409);
            BoxRegUserAdmin.Name = "BoxRegUserAdmin";
            BoxRegUserAdmin.PlaceholderText = "Nombre Usuario Admin";
            BoxRegUserAdmin.Size = new Size(307, 34);
            BoxRegUserAdmin.TabIndex = 11;
            // 
            // RegisterLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1902, 1033);
            Controls.Add(BoxRegUserAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(ButtonRegInicio);
            Controls.Add(LabelRegCuenta);
            Controls.Add(ButtonRegCentro);
            Controls.Add(BoxRegRECPass);
            Controls.Add(BoxRegUbicacion);
            Controls.Add(BoxRegPass);
            Controls.Add(BoxRegEmail);
            Controls.Add(BoxRegCentro);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterLogin";
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxRegCentro;
        private TextBox BoxRegEmail;
        private TextBox BoxRegPass;
        private TextBox BoxRegUbicacion;
        private TextBox BoxRegRECPass;
        private Button ButtonRegCentro;
        private Label LabelRegCuenta;
        private Button ButtonRegInicio;
        private PictureBox pictureBox1;
        private TextBox BoxRegUserAdmin;
    }
}