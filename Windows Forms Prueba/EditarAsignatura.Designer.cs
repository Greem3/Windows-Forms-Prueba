namespace Windows_Forms_Prueba
{
    partial class EditarAsignatura
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
            ButtonCancel = new Button();
            ButtonSave = new Button();
            panel1 = new Panel();
            ComboBTecnicaAsig = new ComboBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ComboBNewCursos = new ComboBox();
            label2 = new Label();
            BoxEditAsigNombre = new TextBox();
            label1 = new Label();
            ComboStudentSearch = new ComboBox();
            label6 = new Label();
            ButtonSearch = new Button();
            LabelNameStudent = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(692, 400);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 25;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(592, 400);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 24;
            ButtonSave.Text = "Guardar";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ComboBTecnicaAsig);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 138);
            panel1.TabIndex = 23;
            // 
            // ComboBTecnicaAsig
            // 
            ComboBTecnicaAsig.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBTecnicaAsig.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBTecnicaAsig.FormattingEnabled = true;
            ComboBTecnicaAsig.Items.AddRange(new object[] { "Diseño y Desarrollo de Bases de Datos" });
            ComboBTecnicaAsig.Location = new Point(217, 78);
            ComboBTecnicaAsig.Name = "ComboBTecnicaAsig";
            ComboBTecnicaAsig.Size = new Size(240, 28);
            ComboBTecnicaAsig.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(38, 74);
            label4.Name = "label4";
            label4.Size = new Size(173, 32);
            label4.TabIndex = 2;
            label4.Text = "Nueva Técnica:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(227, 27);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(65, 20);
            label3.Name = "label3";
            label3.Size = new Size(146, 32);
            label3.TabIndex = 0;
            label3.Text = "Nuevos RAs:";
            // 
            // ComboBNewCursos
            // 
            ComboBNewCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBNewCursos.FormattingEnabled = true;
            ComboBNewCursos.Items.AddRange(new object[] { "Académica", "Técnica" });
            ComboBNewCursos.Location = new Point(229, 190);
            ComboBNewCursos.Name = "ComboBNewCursos";
            ComboBNewCursos.Size = new Size(240, 28);
            ComboBNewCursos.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(79, 184);
            label2.Name = "label2";
            label2.Size = new Size(144, 32);
            label2.TabIndex = 21;
            label2.Text = "Nuevo Tipo:";
            // 
            // BoxEditAsigNombre
            // 
            BoxEditAsigNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxEditAsigNombre.Location = new Point(229, 116);
            BoxEditAsigNombre.Name = "BoxEditAsigNombre";
            BoxEditAsigNombre.PlaceholderText = "Nombre";
            BoxEditAsigNombre.Size = new Size(240, 32);
            BoxEditAsigNombre.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(38, 114);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 19;
            label1.Text = "Nuevo Nombre:";
            // 
            // ComboStudentSearch
            // 
            ComboStudentSearch.FormattingEnabled = true;
            ComboStudentSearch.Items.AddRange(new object[] { "Ian Pichardo", "Hendrick German", "Jean Kary Brea", "Onielkis Vaiolet" });
            ComboStudentSearch.Location = new Point(174, 3);
            ComboStudentSearch.Name = "ComboStudentSearch";
            ComboStudentSearch.Size = new Size(484, 28);
            ComboStudentSearch.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(0, 3);
            label6.Name = "label6";
            label6.Size = new Size(171, 28);
            label6.TabIndex = 27;
            label6.Text = "Buscar Asignatura:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.Transparent;
            ButtonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(664, 0);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(136, 31);
            ButtonSearch.TabIndex = 26;
            ButtonSearch.Text = "Buscar";
            ButtonSearch.TextAlign = ContentAlignment.TopCenter;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // LabelNameStudent
            // 
            LabelNameStudent.AutoSize = true;
            LabelNameStudent.BackColor = Color.White;
            LabelNameStudent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNameStudent.Location = new Point(38, 57);
            LabelNameStudent.Name = "LabelNameStudent";
            LabelNameStudent.Size = new Size(215, 32);
            LabelNameStudent.TabIndex = 29;
            LabelNameStudent.Text = "NombreAsignatura";
            // 
            // EditarAsignatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(LabelNameStudent);
            Controls.Add(ComboStudentSearch);
            Controls.Add(label6);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(panel1);
            Controls.Add(ComboBNewCursos);
            Controls.Add(label2);
            Controls.Add(BoxEditAsigNombre);
            Controls.Add(label1);
            Name = "EditarAsignatura";
            Text = "Editar Asignatura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCancel;
        private Button ButtonSave;
        private Panel panel1;
        private ComboBox ComboBTecnicaAsig;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private ComboBox ComboBNewCursos;
        private Label label2;
        private TextBox BoxEditAsigNombre;
        private Label label1;
        private ComboBox ComboStudentSearch;
        private Label label6;
        private Button ButtonSearch;
        private Label LabelNameStudent;
    }
}