namespace Windows_Forms_Prueba
{
    partial class EditarCurso
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
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            ComboBNewCursos = new ComboBox();
            label2 = new Label();
            BoxAsigNombre = new TextBox();
            label1 = new Label();
            ComboStudentSearch = new ComboBox();
            label6 = new Label();
            ButtonSearch = new Button();
            LabelNameStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(256, 238);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 27);
            numericUpDown1.TabIndex = 31;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(28, 235);
            label3.Name = "label3";
            label3.Size = new Size(222, 28);
            label3.TabIndex = 30;
            label3.Text = "Nuevo Número de Aula:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(670, 265);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 29;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(570, 265);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 28;
            ButtonSave.Text = "Guardar";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // ComboBNewCursos
            // 
            ComboBNewCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBNewCursos.FormattingEnabled = true;
            ComboBNewCursos.Items.AddRange(new object[] { "Académica", "Técnica" });
            ComboBNewCursos.Location = new Point(256, 185);
            ComboBNewCursos.Name = "ComboBNewCursos";
            ComboBNewCursos.Size = new Size(240, 28);
            ComboBNewCursos.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(132, 181);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 26;
            label2.Text = "Nuevo Tipo:";
            // 
            // BoxAsigNombre
            // 
            BoxAsigNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxAsigNombre.Location = new Point(256, 125);
            BoxAsigNombre.Name = "BoxAsigNombre";
            BoxAsigNombre.PlaceholderText = "Nombre";
            BoxAsigNombre.Size = new Size(240, 32);
            BoxAsigNombre.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(98, 127);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 24;
            label1.Text = "Nuevo Nombre:";
            // 
            // ComboStudentSearch
            // 
            ComboStudentSearch.FormattingEnabled = true;
            ComboStudentSearch.Items.AddRange(new object[] { "Ian Pichardo", "Hendrick German", "Jean Kary Brea", "Onielkis Vaiolet" });
            ComboStudentSearch.Location = new Point(136, 1);
            ComboStudentSearch.Name = "ComboStudentSearch";
            ComboStudentSearch.Size = new Size(484, 28);
            ComboStudentSearch.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(3, 1);
            label6.Name = "label6";
            label6.Size = new Size(127, 28);
            label6.TabIndex = 33;
            label6.Text = "Buscar Curso:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.Transparent;
            ButtonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(628, 2);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(136, 31);
            ButtonSearch.TabIndex = 32;
            ButtonSearch.Text = "Buscar";
            ButtonSearch.TextAlign = ContentAlignment.TopCenter;
            ButtonSearch.UseVisualStyleBackColor = false;
            // 
            // LabelNameStudent
            // 
            LabelNameStudent.AutoSize = true;
            LabelNameStudent.BackColor = Color.White;
            LabelNameStudent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNameStudent.Location = new Point(41, 58);
            LabelNameStudent.Name = "LabelNameStudent";
            LabelNameStudent.Size = new Size(163, 32);
            LabelNameStudent.TabIndex = 35;
            LabelNameStudent.Text = "NombreCurso";
            // 
            // EditarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(773, 306);
            Controls.Add(LabelNameStudent);
            Controls.Add(ComboStudentSearch);
            Controls.Add(label6);
            Controls.Add(ButtonSearch);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(ComboBNewCursos);
            Controls.Add(label2);
            Controls.Add(BoxAsigNombre);
            Controls.Add(label1);
            Name = "EditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Curso";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label3;
        private Button ButtonCancel;
        private Button ButtonSave;
        private ComboBox ComboBNewCursos;
        private Label label2;
        private TextBox BoxAsigNombre;
        private Label label1;
        private ComboBox ComboStudentSearch;
        private Label label6;
        private Button ButtonSearch;
        private Label LabelNameStudent;
    }
}