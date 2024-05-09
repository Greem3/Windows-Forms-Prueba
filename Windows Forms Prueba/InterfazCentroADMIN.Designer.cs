namespace Windows_Forms_Prueba
{
    partial class InterfazCentroADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazCentroADMIN));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            PanelWelcome = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LabelUserWelcome = new Label();
            PanelListProfs = new Panel();
            DGVListaProfesores = new DataGridView();
            ProfNombre1 = new DataGridViewTextBoxColumn();
            ProfNombre2 = new DataGridViewTextBoxColumn();
            ProfApellido1 = new DataGridViewTextBoxColumn();
            ProfApellido2 = new DataGridViewTextBoxColumn();
            ProfClaseEncargada = new DataGridViewTextBoxColumn();
            ProfClases = new DataGridViewTextBoxColumn();
            profeToolStripMenuItem = new ToolStripMenuItem();
            listaDeProfesoresToolStripMenuItem = new ToolStripMenuItem();
            registrarProfesorToolStripMenuItem = new ToolStripMenuItem();
            editarProfesorToolStripMenuItem = new ToolStripMenuItem();
            estudiantesToolStripMenuItem = new ToolStripMenuItem();
            listaDeEstudiaToolStripMenuItem = new ToolStripMenuItem();
            registrarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            editarEstudianteToolStripMenuItem = new ToolStripMenuItem();
            asignaturasToolStripMenuItem = new ToolStripMenuItem();
            registrarAToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            liToolStripMenuItem = new ToolStripMenuItem();
            MenuPag = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelWelcome.SuspendLayout();
            PanelListProfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListaProfesores).BeginInit();
            MenuPag.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = Properties.Resources.Kopier_Analysts_Logo_WF;
            pictureBox1.Location = new Point(2, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 164);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(161, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 1008);
            panel1.TabIndex = 2;
            // 
            // PanelWelcome
            // 
            PanelWelcome.BackColor = Color.Transparent;
            PanelWelcome.Controls.Add(label3);
            PanelWelcome.Controls.Add(label2);
            PanelWelcome.Controls.Add(label1);
            PanelWelcome.Controls.Add(LabelUserWelcome);
            PanelWelcome.Location = new Point(179, 32);
            PanelWelcome.Name = "PanelWelcome";
            PanelWelcome.Size = new Size(1723, 1002);
            PanelWelcome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(58, 379);
            label3.Name = "label3";
            label3.Size = new Size(433, 28);
            label3.TabIndex = 12;
            label3.Text = "- ¡Presentación del diseño de nuestro programa!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(58, 333);
            label2.Name = "label2";
            label2.Size = new Size(155, 32);
            label2.TabIndex = 11;
            label2.Text = "KOPIER v1.0A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(45, 244);
            label1.Name = "label1";
            label1.Size = new Size(177, 41);
            label1.TabIndex = 10;
            label1.Text = "Novedades";
            // 
            // LabelUserWelcome
            // 
            LabelUserWelcome.AutoSize = true;
            LabelUserWelcome.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUserWelcome.ForeColor = SystemColors.ControlLightLight;
            LabelUserWelcome.Location = new Point(45, 54);
            LabelUserWelcome.Name = "LabelUserWelcome";
            LabelUserWelcome.Size = new Size(245, 46);
            LabelUserWelcome.TabIndex = 9;
            LabelUserWelcome.Text = "¡Hola Usuario!";
            // 
            // PanelListProfs
            // 
            PanelListProfs.BackColor = Color.Transparent;
            PanelListProfs.Controls.Add(DGVListaProfesores);
            PanelListProfs.Location = new Point(171, 29);
            PanelListProfs.Name = "PanelListProfs";
            PanelListProfs.Size = new Size(1723, 1002);
            PanelListProfs.TabIndex = 13;
            PanelListProfs.Visible = false;
            // 
            // DGVListaProfesores
            // 
            DGVListaProfesores.BackgroundColor = Color.FromArgb(40, 40, 40);
            DGVListaProfesores.BorderStyle = BorderStyle.None;
            DGVListaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaProfesores.Columns.AddRange(new DataGridViewColumn[] { ProfNombre1, ProfNombre2, ProfApellido1, ProfApellido2, ProfClaseEncargada, ProfClases });
            DGVListaProfesores.Location = new Point(0, 0);
            DGVListaProfesores.Name = "DGVListaProfesores";
            DGVListaProfesores.ReadOnly = true;
            DGVListaProfesores.RowHeadersWidth = 51;
            DGVListaProfesores.RowTemplate.Height = 28;
            DGVListaProfesores.Size = new Size(979, 336);
            DGVListaProfesores.TabIndex = 0;
            // 
            // ProfNombre1
            // 
            ProfNombre1.HeaderText = "Primer Nombre";
            ProfNombre1.MinimumWidth = 6;
            ProfNombre1.Name = "ProfNombre1";
            ProfNombre1.ReadOnly = true;
            ProfNombre1.Width = 140;
            // 
            // ProfNombre2
            // 
            ProfNombre2.HeaderText = "Segundo Nombre";
            ProfNombre2.MinimumWidth = 6;
            ProfNombre2.Name = "ProfNombre2";
            ProfNombre2.ReadOnly = true;
            ProfNombre2.Width = 160;
            // 
            // ProfApellido1
            // 
            ProfApellido1.HeaderText = "Primer Apellido";
            ProfApellido1.MinimumWidth = 6;
            ProfApellido1.Name = "ProfApellido1";
            ProfApellido1.ReadOnly = true;
            ProfApellido1.Width = 140;
            // 
            // ProfApellido2
            // 
            ProfApellido2.HeaderText = "Segundo Apellido";
            ProfApellido2.MinimumWidth = 6;
            ProfApellido2.Name = "ProfApellido2";
            ProfApellido2.ReadOnly = true;
            ProfApellido2.Width = 160;
            // 
            // ProfClaseEncargada
            // 
            ProfClaseEncargada.HeaderText = "Curso Encargado";
            ProfClaseEncargada.MinimumWidth = 6;
            ProfClaseEncargada.Name = "ProfClaseEncargada";
            ProfClaseEncargada.ReadOnly = true;
            ProfClaseEncargada.Width = 150;
            // 
            // ProfClases
            // 
            ProfClases.HeaderText = "Clases que imparte";
            ProfClases.MinimumWidth = 6;
            ProfClases.Name = "ProfClases";
            ProfClases.ReadOnly = true;
            ProfClases.Width = 175;
            // 
            // profeToolStripMenuItem
            // 
            profeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeProfesoresToolStripMenuItem, registrarProfesorToolStripMenuItem, editarProfesorToolStripMenuItem });
            profeToolStripMenuItem.ForeColor = Color.White;
            profeToolStripMenuItem.ImageTransparentColor = Color.Transparent;
            profeToolStripMenuItem.Name = "profeToolStripMenuItem";
            profeToolStripMenuItem.Size = new Size(92, 24);
            profeToolStripMenuItem.Text = "Profesores";
            // 
            // listaDeProfesoresToolStripMenuItem
            // 
            listaDeProfesoresToolStripMenuItem.Name = "listaDeProfesoresToolStripMenuItem";
            listaDeProfesoresToolStripMenuItem.Size = new Size(224, 26);
            listaDeProfesoresToolStripMenuItem.Text = "Lista de Profesores";
            listaDeProfesoresToolStripMenuItem.Click += EditProfWindow_Click;
            // 
            // registrarProfesorToolStripMenuItem
            // 
            registrarProfesorToolStripMenuItem.Name = "registrarProfesorToolStripMenuItem";
            registrarProfesorToolStripMenuItem.Size = new Size(224, 26);
            registrarProfesorToolStripMenuItem.Text = "Registrar Profesor";
            registrarProfesorToolStripMenuItem.Click += EditProfWindow_Click;
            // 
            // editarProfesorToolStripMenuItem
            // 
            editarProfesorToolStripMenuItem.Name = "editarProfesorToolStripMenuItem";
            editarProfesorToolStripMenuItem.Size = new Size(224, 26);
            editarProfesorToolStripMenuItem.Text = "Editar Profesor";
            // 
            // estudiantesToolStripMenuItem
            // 
            estudiantesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeEstudiaToolStripMenuItem, registrarEstudianteToolStripMenuItem, editarEstudianteToolStripMenuItem });
            estudiantesToolStripMenuItem.ForeColor = Color.White;
            estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            estudiantesToolStripMenuItem.Size = new Size(98, 24);
            estudiantesToolStripMenuItem.Text = "Estudiantes";
            // 
            // listaDeEstudiaToolStripMenuItem
            // 
            listaDeEstudiaToolStripMenuItem.Name = "listaDeEstudiaToolStripMenuItem";
            listaDeEstudiaToolStripMenuItem.Size = new Size(224, 26);
            listaDeEstudiaToolStripMenuItem.Text = "Lista de Estudiantes";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            registrarEstudianteToolStripMenuItem.Size = new Size(224, 26);
            registrarEstudianteToolStripMenuItem.Text = "Registrar Estudiante";
            // 
            // editarEstudianteToolStripMenuItem
            // 
            editarEstudianteToolStripMenuItem.Name = "editarEstudianteToolStripMenuItem";
            editarEstudianteToolStripMenuItem.Size = new Size(224, 26);
            editarEstudianteToolStripMenuItem.Text = "Editar Estudiante";
            // 
            // asignaturasToolStripMenuItem
            // 
            asignaturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { liToolStripMenuItem, registrarAToolStripMenuItem, eToolStripMenuItem });
            asignaturasToolStripMenuItem.ForeColor = Color.White;
            asignaturasToolStripMenuItem.Name = "asignaturasToolStripMenuItem";
            asignaturasToolStripMenuItem.Size = new Size(100, 24);
            asignaturasToolStripMenuItem.Text = "Asignaturas";
            // 
            // registrarAToolStripMenuItem
            // 
            registrarAToolStripMenuItem.Name = "registrarAToolStripMenuItem";
            registrarAToolStripMenuItem.Size = new Size(226, 26);
            registrarAToolStripMenuItem.Text = "Registrar Asignatura";
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(226, 26);
            eToolStripMenuItem.Text = "Editar Asignatura";
            // 
            // liToolStripMenuItem
            // 
            liToolStripMenuItem.Name = "liToolStripMenuItem";
            liToolStripMenuItem.Size = new Size(226, 26);
            liToolStripMenuItem.Text = "Lista de Asignaturas";
            // 
            // MenuPag
            // 
            MenuPag.BackColor = Color.White;
            MenuPag.BackgroundImage = Properties.Resources.fondomenu;
            MenuPag.ImageScalingSize = new Size(20, 20);
            MenuPag.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, profeToolStripMenuItem, estudiantesToolStripMenuItem, asignaturasToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            MenuPag.Location = new Point(0, 0);
            MenuPag.Name = "MenuPag";
            MenuPag.RightToLeft = RightToLeft.Yes;
            MenuPag.Size = new Size(1902, 28);
            MenuPag.TabIndex = 1;
            MenuPag.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += InicioToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.ForeColor = Color.White;
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(110, 24);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += CambiarALogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(171, 10);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(2, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(159, 832);
            panel3.TabIndex = 4;
            // 
            // InterfazCentroADMIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(MenuPag);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(PanelWelcome);
            Controls.Add(PanelListProfs);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuPag;
            MinimumSize = new Size(780, 400);
            Name = "InterfazCentroADMIN";
            Text = "InterfazCentro";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelWelcome.ResumeLayout(false);
            PanelWelcome.PerformLayout();
            PanelListProfs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVListaProfesores).EndInit();
            MenuPag.ResumeLayout(false);
            MenuPag.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private ToolStripMenuItem profeToolStripMenuItem;
        private ToolStripMenuItem estudiantesToolStripMenuItem;
        private ToolStripMenuItem asignaturasToolStripMenuItem;
        private MenuStrip MenuPag;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem registrarProfesorToolStripMenuItem;
        private ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private ToolStripMenuItem registrarAToolStripMenuItem;
        private Panel PanelWelcome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label LabelUserWelcome;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private Panel PanelListProfs;
        private DataGridView DGVListaProfesores;
        private DataGridViewTextBoxColumn ProfNombre1;
        private DataGridViewTextBoxColumn ProfNombre2;
        private DataGridViewTextBoxColumn ProfApellido1;
        private DataGridViewTextBoxColumn ProfApellido2;
        private DataGridViewTextBoxColumn ProfClaseEncargada;
        private DataGridViewTextBoxColumn ProfClases;
        private ToolStripMenuItem editarProfesorToolStripMenuItem;
        private ToolStripMenuItem editarEstudianteToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem listaDeProfesoresToolStripMenuItem;
        private ToolStripMenuItem listaDeEstudiaToolStripMenuItem;
        private ToolStripMenuItem liToolStripMenuItem;
    }
}