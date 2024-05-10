namespace Windows_Forms_Prueba
{
    partial class EditarEstudiante
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
            PanelEditStudent = new Panel();
            LabelNameStudent = new Label();
            NUPNewLista = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            ComboBNewStudentTecnica = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            ComboBNewCursos = new ComboBox();
            ButtonCancel = new Button();
            ButtonRegistrar = new Button();
            BoxNewStudentPass = new TextBox();
            BoxNewStudentName = new TextBox();
            ComboStudentSearch = new ComboBox();
            label6 = new Label();
            ButtonSearch = new Button();
            PanelEditStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUPNewLista).BeginInit();
            SuspendLayout();
            // 
            // PanelEditStudent
            // 
            PanelEditStudent.Controls.Add(LabelNameStudent);
            PanelEditStudent.Controls.Add(NUPNewLista);
            PanelEditStudent.Controls.Add(label5);
            PanelEditStudent.Controls.Add(label4);
            PanelEditStudent.Controls.Add(label2);
            PanelEditStudent.Controls.Add(ComboBNewStudentTecnica);
            PanelEditStudent.Controls.Add(label1);
            PanelEditStudent.Controls.Add(label3);
            PanelEditStudent.Controls.Add(ComboBNewCursos);
            PanelEditStudent.Controls.Add(ButtonCancel);
            PanelEditStudent.Controls.Add(ButtonRegistrar);
            PanelEditStudent.Controls.Add(BoxNewStudentPass);
            PanelEditStudent.Controls.Add(BoxNewStudentName);
            PanelEditStudent.Location = new Point(12, 53);
            PanelEditStudent.Name = "PanelEditStudent";
            PanelEditStudent.Size = new Size(785, 405);
            PanelEditStudent.TabIndex = 7;
            PanelEditStudent.Visible = false;
            // 
            // LabelNameStudent
            // 
            LabelNameStudent.AutoSize = true;
            LabelNameStudent.BackColor = Color.White;
            LabelNameStudent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNameStudent.Location = new Point(15, 12);
            LabelNameStudent.Name = "LabelNameStudent";
            LabelNameStudent.Size = new Size(185, 32);
            LabelNameStudent.TabIndex = 22;
            LabelNameStudent.Text = "NombreStudent";
            // 
            // NUPNewLista
            // 
            NUPNewLista.Location = new Point(193, 332);
            NUPNewLista.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            NUPNewLista.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUPNewLista.Name = "NUPNewLista";
            NUPNewLista.Size = new Size(42, 27);
            NUPNewLista.TabIndex = 21;
            NUPNewLista.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(39, 334);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 20;
            label5.Text = "Nuevo No. Lista:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(17, 151);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 19;
            label4.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(45, 88);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 18;
            label2.Text = "Nuevo Nombre:";
            // 
            // ComboBNewStudentTecnica
            // 
            ComboBNewStudentTecnica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewStudentTecnica.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewStudentTecnica.FormattingEnabled = true;
            ComboBNewStudentTecnica.Items.AddRange(new object[] { "Desarrollo y Administración de Aplicaciones Informáticas", "Servicios Gastronómicos", "Instalaciónes Eléctricas", "Equipos Electrónicos", "Refrigeración y Acondicionamiente de Aire", "Gestión Administrativa y Tributaria", "Comercio y Mercadeo" });
            ComboBNewStudentTecnica.Location = new Point(193, 269);
            ComboBNewStudentTecnica.Name = "ComboBNewStudentTecnica";
            ComboBNewStudentTecnica.Size = new Size(240, 28);
            ComboBNewStudentTecnica.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(51, 269);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 16;
            label1.Text = "Nueva Técnica:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(65, 216);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 15;
            label3.Text = "Nuevo Curso:";
            // 
            // ComboBNewCursos
            // 
            ComboBNewCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewCursos.FormattingEnabled = true;
            ComboBNewCursos.Items.AddRange(new object[] { "4to Secundaria", "5to Secundaria", "6to Secundaria" });
            ComboBNewCursos.Location = new Point(193, 213);
            ComboBNewCursos.Name = "ComboBNewCursos";
            ComboBNewCursos.Size = new Size(240, 28);
            ComboBNewCursos.TabIndex = 14;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(681, 376);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonRegistrar
            // 
            ButtonRegistrar.Location = new Point(581, 376);
            ButtonRegistrar.Name = "ButtonRegistrar";
            ButtonRegistrar.Size = new Size(94, 29);
            ButtonRegistrar.TabIndex = 12;
            ButtonRegistrar.Text = "Guardar";
            ButtonRegistrar.UseVisualStyleBackColor = true;
            // 
            // BoxNewStudentPass
            // 
            BoxNewStudentPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewStudentPass.Location = new Point(193, 148);
            BoxNewStudentPass.Name = "BoxNewStudentPass";
            BoxNewStudentPass.PasswordChar = '*';
            BoxNewStudentPass.PlaceholderText = "Contraseña";
            BoxNewStudentPass.Size = new Size(240, 32);
            BoxNewStudentPass.TabIndex = 4;
            // 
            // BoxNewStudentName
            // 
            BoxNewStudentName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewStudentName.Location = new Point(193, 85);
            BoxNewStudentName.Name = "BoxNewStudentName";
            BoxNewStudentName.PlaceholderText = "Nombre";
            BoxNewStudentName.Size = new Size(240, 32);
            BoxNewStudentName.TabIndex = 2;
            // 
            // ComboStudentSearch
            // 
            ComboStudentSearch.FormattingEnabled = true;
            ComboStudentSearch.Items.AddRange(new object[] { "Ian Pichardo", "Hendrick German", "Jean Kary Brea", "Onielkis Vaiolet" });
            ComboStudentSearch.Location = new Point(171, 2);
            ComboStudentSearch.Name = "ComboStudentSearch";
            ComboStudentSearch.Size = new Size(484, 28);
            ComboStudentSearch.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(-3, -1);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 9;
            label6.Text = "Buscar Estudiante:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.Transparent;
            ButtonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(661, 0);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(136, 31);
            ButtonSearch.TabIndex = 8;
            ButtonSearch.Text = "Buscar";
            ButtonSearch.TextAlign = ContentAlignment.TopCenter;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // EditarEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(799, 460);
            Controls.Add(ComboStudentSearch);
            Controls.Add(label6);
            Controls.Add(ButtonSearch);
            Controls.Add(PanelEditStudent);
            Name = "EditarEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Estudiante";
            PanelEditStudent.ResumeLayout(false);
            PanelEditStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUPNewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelEditStudent;
        private NumericUpDown NUPNewLista;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox ComboBNewStudentTecnica;
        private Label label1;
        private Label label3;
        private ComboBox ComboBNewCursos;
        private Button ButtonCancel;
        private Button ButtonRegistrar;
        private TextBox BoxNewStudentPass;
        private TextBox BoxNewStudentName;
        private ComboBox ComboStudentSearch;
        private Label label6;
        private Button ButtonSearch;
        private Label LabelNameStudent;
    }
}