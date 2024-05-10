namespace Windows_Forms_Prueba
{
    partial class RegistrarProf
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
            PanelProfInfo = new Panel();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            panel3 = new Panel();
            ListBAsigTecnicas = new CheckedListBox();
            label6 = new Label();
            panel2 = new Panel();
            ListBAsigAcademicas = new CheckedListBox();
            label4 = new Label();
            panel1 = new Panel();
            ListBTecnicas = new CheckedListBox();
            label5 = new Label();
            BoxPassProf = new TextBox();
            BoxNameProf = new TextBox();
            PanelProfInfo.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProfInfo
            // 
            PanelProfInfo.Controls.Add(ButtonCancel);
            PanelProfInfo.Controls.Add(ButtonSave);
            PanelProfInfo.Controls.Add(panel3);
            PanelProfInfo.Controls.Add(panel2);
            PanelProfInfo.Controls.Add(panel1);
            PanelProfInfo.Controls.Add(BoxPassProf);
            PanelProfInfo.Controls.Add(BoxNameProf);
            PanelProfInfo.Location = new Point(1, 3);
            PanelProfInfo.Name = "PanelProfInfo";
            PanelProfInfo.Size = new Size(902, 685);
            PanelProfInfo.TabIndex = 6;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(778, 577);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += CancelProf_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(678, 577);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 12;
            ButtonSave.Text = "Registrar";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += RegistrarProf_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ListBAsigTecnicas);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(475, 330);
            panel3.Name = "panel3";
            panel3.Size = new Size(397, 216);
            panel3.TabIndex = 11;
            // 
            // ListBAsigTecnicas
            // 
            ListBAsigTecnicas.BackColor = Color.FromArgb(40, 40, 40);
            ListBAsigTecnicas.BorderStyle = BorderStyle.None;
            ListBAsigTecnicas.ForeColor = SystemColors.Window;
            ListBAsigTecnicas.FormattingEnabled = true;
            ListBAsigTecnicas.Items.AddRange(new object[] { "Diseño y Desarrollo de Bases de Datos", "Administración y Diseño de Sistemas Informáticos", "Ofimática" });
            ListBAsigTecnicas.Location = new Point(-1, 40);
            ListBAsigTecnicas.Name = "ListBAsigTecnicas";
            ListBAsigTecnicas.Size = new Size(394, 176);
            ListBAsigTecnicas.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(0, 4);
            label6.Name = "label6";
            label6.Size = new Size(274, 28);
            label6.TabIndex = 6;
            label6.Text = "Asignaturas técnicas que dara:";
            // 
            // panel2
            // 
            panel2.Controls.Add(ListBAsigAcademicas);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(34, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 216);
            panel2.TabIndex = 10;
            // 
            // ListBAsigAcademicas
            // 
            ListBAsigAcademicas.BackColor = Color.FromArgb(40, 40, 40);
            ListBAsigAcademicas.BorderStyle = BorderStyle.None;
            ListBAsigAcademicas.ForeColor = SystemColors.Window;
            ListBAsigAcademicas.FormattingEnabled = true;
            ListBAsigAcademicas.Items.AddRange(new object[] { "Lengua Española", "Ciencias Naturales", "Sociales", "Matemáticas", "Ingles", "Educación Física", "Religión", "Artística" });
            ListBAsigAcademicas.Location = new Point(-1, 40);
            ListBAsigAcademicas.Name = "ListBAsigAcademicas";
            ListBAsigAcademicas.Size = new Size(394, 176);
            ListBAsigAcademicas.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(0, 4);
            label4.Name = "label4";
            label4.Size = new Size(305, 28);
            label4.TabIndex = 6;
            label4.Text = "Asignaturas academicas que dara:";
            // 
            // panel1
            // 
            panel1.Controls.Add(ListBTecnicas);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(34, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 206);
            panel1.TabIndex = 9;
            // 
            // ListBTecnicas
            // 
            ListBTecnicas.BackColor = Color.FromArgb(40, 40, 40);
            ListBTecnicas.BorderStyle = BorderStyle.None;
            ListBTecnicas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ListBTecnicas.ForeColor = SystemColors.ControlLightLight;
            ListBTecnicas.FormattingEnabled = true;
            ListBTecnicas.Items.AddRange(new object[] { "Desarrollo y Administración de Aplicaciones Informáticas", "Servicios Gastronómicos", "Instalaciónes Eléctricas", "Equipos Electrónicos", "Refrigeración y Acondicionamiente de Aire", "Gestión Administrativa Y Tributaria", "Comercio y Mercadeo" });
            ListBTecnicas.Location = new Point(0, 31);
            ListBTecnicas.Name = "ListBTecnicas";
            ListBTecnicas.Size = new Size(463, 175);
            ListBTecnicas.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(-1, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 28);
            label5.TabIndex = 7;
            label5.Text = "Técnicas del profesor:";
            // 
            // BoxPassProf
            // 
            BoxPassProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxPassProf.Location = new Point(338, 36);
            BoxPassProf.Name = "BoxPassProf";
            BoxPassProf.PasswordChar = '*';
            BoxPassProf.PlaceholderText = "Contraseña";
            BoxPassProf.Size = new Size(240, 32);
            BoxPassProf.TabIndex = 4;
            // 
            // BoxNameProf
            // 
            BoxNameProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNameProf.Location = new Point(33, 36);
            BoxNameProf.Name = "BoxNameProf";
            BoxNameProf.PlaceholderText = "Nombre";
            BoxNameProf.Size = new Size(240, 32);
            BoxNameProf.TabIndex = 2;
            // 
            // RegistrarProf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(903, 622);
            Controls.Add(PanelProfInfo);
            Name = "RegistrarProf";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Profesor";
            PanelProfInfo.ResumeLayout(false);
            PanelProfInfo.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProfInfo;
        private Button ButtonCancel;
        private Button ButtonSave;
        private Panel panel3;
        private CheckedListBox ListBAsigTecnicas;
        private Label label6;
        private Panel panel2;
        private CheckedListBox ListBAsigAcademicas;
        private Label label4;
        private Panel panel1;
        private CheckedListBox ListBTecnicas;
        private Label label5;
        private TextBox BoxPassProf;
        private TextBox BoxNameProf;
    }
}