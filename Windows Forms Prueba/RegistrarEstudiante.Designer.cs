namespace Windows_Forms_Prueba
{
    partial class RegistrarEstudiante
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
            panel4 = new Panel();
            NUPLista = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            ComboBStudentTecnica = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            ComboBCursos = new ComboBox();
            ButtonCancel = new Button();
            ButtonRegistrar = new Button();
            BoxStudentPass = new TextBox();
            BoxStudentName = new TextBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUPLista).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(NUPLista);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(ComboBStudentTecnica);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(ComboBCursos);
            panel4.Controls.Add(ButtonCancel);
            panel4.Controls.Add(ButtonRegistrar);
            panel4.Controls.Add(BoxStudentPass);
            panel4.Controls.Add(BoxStudentName);
            panel4.Location = new Point(3, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(653, 368);
            panel4.TabIndex = 6;
            // 
            // NUPLista
            // 
            NUPLista.Location = new Point(133, 283);
            NUPLista.Maximum = new decimal(new int[] { 40, 0, 0, 0 });
            NUPLista.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUPLista.Name = "NUPLista";
            NUPLista.Size = new Size(42, 27);
            NUPLista.TabIndex = 21;
            NUPLista.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(42, 281);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 20;
            label5.Text = "No. Lista:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 102);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 19;
            label4.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(42, 39);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // ComboBStudentTecnica
            // 
            ComboBStudentTecnica.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBStudentTecnica.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBStudentTecnica.FormattingEnabled = true;
            ComboBStudentTecnica.Items.AddRange(new object[] { "Desarrollo y Administración de Aplicaciones Informáticas", "Servicios Gastronómicos", "Instalaciónes Eléctricas", "Equipos Electrónicos", "Refrigeración y Acondicionamiente de Aire", "Gestión Administrativa y Tributaria", "Comercio y Mercadeo" });
            ComboBStudentTecnica.Location = new Point(133, 220);
            ComboBStudentTecnica.Name = "ComboBStudentTecnica";
            ComboBStudentTecnica.Size = new Size(240, 28);
            ComboBStudentTecnica.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(50, 223);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 16;
            label1.Text = "Técnica:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(63, 164);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 15;
            label3.Text = "Curso:";
            // 
            // ComboBCursos
            // 
            ComboBCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBCursos.FormattingEnabled = true;
            ComboBCursos.Items.AddRange(new object[] { "4to Secundaria", "5to Secundaria", "6to Secundaria" });
            ComboBCursos.Location = new Point(133, 164);
            ComboBCursos.Name = "ComboBCursos";
            ComboBCursos.Size = new Size(240, 28);
            ComboBCursos.TabIndex = 14;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(550, 330);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += CancelStudent_Click;
            // 
            // ButtonRegistrar
            // 
            ButtonRegistrar.Location = new Point(450, 330);
            ButtonRegistrar.Name = "ButtonRegistrar";
            ButtonRegistrar.Size = new Size(94, 29);
            ButtonRegistrar.TabIndex = 12;
            ButtonRegistrar.Text = "Registrar";
            ButtonRegistrar.UseVisualStyleBackColor = true;
            ButtonRegistrar.Click += RegistrarStudent_Click;
            // 
            // BoxStudentPass
            // 
            BoxStudentPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxStudentPass.Location = new Point(133, 99);
            BoxStudentPass.Name = "BoxStudentPass";
            BoxStudentPass.PasswordChar = '*';
            BoxStudentPass.PlaceholderText = "Contraseña";
            BoxStudentPass.Size = new Size(240, 32);
            BoxStudentPass.TabIndex = 4;
            // 
            // BoxStudentName
            // 
            BoxStudentName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxStudentName.Location = new Point(133, 36);
            BoxStudentName.Name = "BoxStudentName";
            BoxStudentName.PlaceholderText = "Nombre";
            BoxStudentName.Size = new Size(240, 32);
            BoxStudentName.TabIndex = 2;
            // 
            // RegistrarEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(655, 370);
            Controls.Add(panel4);
            Name = "RegistrarEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Estudiante";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUPLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private ComboBox ComboBCursos;
        private Button ButtonCancel;
        private Button ButtonRegistrar;
        private Panel panel5;
        private CheckedListBox checkedListBox1;
        private Label label1;
        private Panel panel6;
        private CheckedListBox checkedListBox2;
        private Label label2;
        private TextBox BoxStudentPass;
        private TextBox BoxStudentName;
        private Label label3;
        private ComboBox ComboBStudentTecnica;
        private Label label4;
        private Label label5;
        private NumericUpDown NUPLista;
    }
}