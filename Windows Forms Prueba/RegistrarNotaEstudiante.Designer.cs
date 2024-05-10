namespace Windows_Forms_Prueba
{
    partial class RegistrarNotaEstudiante
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
            ComboStudentSearch = new ComboBox();
            label6 = new Label();
            ButtonSearch = new Button();
            PanelEditCalStudent = new Panel();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            PanelRA = new Panel();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            PanelAca = new Panel();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            ButtonCancel = new Button();
            ButtonRegistrar = new Button();
            LabelNameStudent = new Label();
            PanelStudent = new Panel();
            ComboBElecAsig = new ComboBox();
            label5 = new Label();
            PanelEditCalStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            PanelRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            PanelAca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            PanelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // ComboStudentSearch
            // 
            ComboStudentSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            ComboStudentSearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboStudentSearch.DropDownStyle = ComboBoxStyle.Simple;
            ComboStudentSearch.FormattingEnabled = true;
            ComboStudentSearch.Items.AddRange(new object[] { "Ian Pichardo, 4to Informática", "Hendrick German, 4to Informática", "Jean Kary Brea, 4to Informática", "Onielkis Vaiolet, 4to Informática" });
            ComboStudentSearch.Location = new Point(174, -1);
            ComboStudentSearch.Name = "ComboStudentSearch";
            ComboStudentSearch.Size = new Size(484, 28);
            ComboStudentSearch.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(0, -4);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 13;
            label6.Text = "Buscar Estudiante:";
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.Transparent;
            ButtonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(664, -3);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(136, 31);
            ButtonSearch.TabIndex = 12;
            ButtonSearch.Text = "Buscar";
            ButtonSearch.TextAlign = ContentAlignment.TopCenter;
            ButtonSearch.UseVisualStyleBackColor = false;
            ButtonSearch.Click += BuscarStudent_Click;
            // 
            // PanelEditCalStudent
            // 
            PanelEditCalStudent.Controls.Add(numericUpDown2);
            PanelEditCalStudent.Controls.Add(label3);
            PanelEditCalStudent.Controls.Add(PanelRA);
            PanelEditCalStudent.Controls.Add(PanelAca);
            PanelEditCalStudent.Controls.Add(ButtonCancel);
            PanelEditCalStudent.Controls.Add(ButtonRegistrar);
            PanelEditCalStudent.Location = new Point(0, 164);
            PanelEditCalStudent.Name = "PanelEditCalStudent";
            PanelEditCalStudent.Size = new Size(811, 299);
            PanelEditCalStudent.TabIndex = 11;
            PanelEditCalStudent.Visible = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(103, 105);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(61, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(37, 105);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Nota:";
            // 
            // PanelRA
            // 
            PanelRA.Controls.Add(numericUpDown3);
            PanelRA.Controls.Add(label4);
            PanelRA.Location = new Point(423, 22);
            PanelRA.Name = "PanelRA";
            PanelRA.Size = new Size(313, 63);
            PanelRA.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(65, 19);
            numericUpDown3.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(41, 27);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(18, 18);
            label4.Name = "label4";
            label4.Size = new Size(41, 28);
            label4.TabIndex = 4;
            label4.Text = "RA:";
            // 
            // PanelAca
            // 
            PanelAca.Controls.Add(numericUpDown1);
            PanelAca.Controls.Add(label2);
            PanelAca.Location = new Point(26, 22);
            PanelAca.Name = "PanelAca";
            PanelAca.Size = new Size(347, 63);
            PanelAca.TabIndex = 14;
            PanelAca.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(101, 18);
            numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(41, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 0;
            label2.Text = "Período:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(704, 267);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += CancelNotaStudent_Click;
            // 
            // ButtonRegistrar
            // 
            ButtonRegistrar.Location = new Point(599, 267);
            ButtonRegistrar.Name = "ButtonRegistrar";
            ButtonRegistrar.Size = new Size(94, 29);
            ButtonRegistrar.TabIndex = 12;
            ButtonRegistrar.Text = "Guardar";
            ButtonRegistrar.UseVisualStyleBackColor = true;
            ButtonRegistrar.Click += GuardarNotaStudent_Click;
            // 
            // LabelNameStudent
            // 
            LabelNameStudent.AutoSize = true;
            LabelNameStudent.BackColor = Color.White;
            LabelNameStudent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNameStudent.Location = new Point(14, 12);
            LabelNameStudent.Name = "LabelNameStudent";
            LabelNameStudent.Size = new Size(185, 32);
            LabelNameStudent.TabIndex = 22;
            LabelNameStudent.Text = "NombreStudent";
            // 
            // PanelStudent
            // 
            PanelStudent.Controls.Add(ComboBElecAsig);
            PanelStudent.Controls.Add(label5);
            PanelStudent.Controls.Add(LabelNameStudent);
            PanelStudent.Location = new Point(12, 33);
            PanelStudent.Name = "PanelStudent";
            PanelStudent.Size = new Size(347, 125);
            PanelStudent.TabIndex = 25;
            PanelStudent.Visible = false;
            // 
            // ComboBElecAsig
            // 
            ComboBElecAsig.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBElecAsig.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBElecAsig.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBElecAsig.FormattingEnabled = true;
            ComboBElecAsig.Items.AddRange(new object[] { "Lengua Española", "Ciencias Naturales", "Sociales", "Matemáticas", "Ingles", "Educación Física", "Religión", "Artística", "Diseño y Desarrollo de Bases de Datos", "Ofimática", "Administración y Diseño de Sistemas Informáticos" });
            ComboBElecAsig.Location = new Point(142, 77);
            ComboBElecAsig.Name = "ComboBElecAsig";
            ComboBElecAsig.Size = new Size(183, 28);
            ComboBElecAsig.TabIndex = 25;
            ComboBElecAsig.Click += TipoNotaAca_TextUpdate;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(26, 73);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 25;
            label5.Text = "Asignatura:";
            // 
            // RegistrarNotaEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(812, 472);
            Controls.Add(PanelStudent);
            Controls.Add(ComboStudentSearch);
            Controls.Add(label6);
            Controls.Add(ButtonSearch);
            Controls.Add(PanelEditCalStudent);
            Name = "RegistrarNotaEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarNotaEstudiante";
            PanelEditCalStudent.ResumeLayout(false);
            PanelEditCalStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            PanelRA.ResumeLayout(false);
            PanelRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            PanelAca.ResumeLayout(false);
            PanelAca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            PanelStudent.ResumeLayout(false);
            PanelStudent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboStudentSearch;
        private Label label6;
        private Button ButtonSearch;
        private Panel PanelEditCalStudent;
        private Label LabelNameStudent;
        private Button ButtonCancel;
        private Button ButtonRegistrar;
        private Panel PanelStudent;
        private Panel PanelAca;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Panel PanelRA;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private Label label5;
        private ComboBox ComboBElecAsig;
    }
}