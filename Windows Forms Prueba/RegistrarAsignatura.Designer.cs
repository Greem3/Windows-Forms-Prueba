namespace Windows_Forms_Prueba
{
    partial class RegistrarAsignatura
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
            label1 = new Label();
            BoxAsigNombre = new TextBox();
            label2 = new Label();
            ComboBNewCursos = new ComboBox();
            panel1 = new Panel();
            ComboBTecnicaAsig = new ComboBox();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // BoxAsigNombre
            // 
            BoxAsigNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxAsigNombre.Location = new Point(151, 32);
            BoxAsigNombre.Name = "BoxAsigNombre";
            BoxAsigNombre.PlaceholderText = "Nombre";
            BoxAsigNombre.Size = new Size(240, 32);
            BoxAsigNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(79, 100);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 4;
            label2.Text = "Tipo:";
            // 
            // ComboBNewCursos
            // 
            ComboBNewCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBNewCursos.FormattingEnabled = true;
            ComboBNewCursos.Items.AddRange(new object[] { "Académica", "Técnica" });
            ComboBNewCursos.Location = new Point(151, 104);
            ComboBNewCursos.Name = "ComboBNewCursos";
            ComboBNewCursos.Size = new Size(240, 28);
            ComboBNewCursos.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Controls.Add(ComboBTecnicaAsig);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(585, 207);
            panel1.TabIndex = 16;
            // 
            // ComboBTecnicaAsig
            // 
            ComboBTecnicaAsig.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBTecnicaAsig.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBTecnicaAsig.FormattingEnabled = true;
            ComboBTecnicaAsig.Items.AddRange(new object[] { "Diseño y Desarrollo de Bases de Datos" });
            ComboBTecnicaAsig.Location = new Point(139, 80);
            ComboBTecnicaAsig.Name = "ComboBTecnicaAsig";
            ComboBTecnicaAsig.Size = new Size(240, 28);
            ComboBTecnicaAsig.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(36, 74);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 2;
            label4.Text = "Técnica:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(139, 25);
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
            label3.Location = new Point(75, 20);
            label3.Name = "label3";
            label3.Size = new Size(58, 32);
            label3.TabIndex = 0;
            label3.Text = "RAs:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(689, 409);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 18;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(589, 409);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 17;
            ButtonSave.Text = "Registrar";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // RegistrarAsignatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(panel1);
            Controls.Add(ComboBNewCursos);
            Controls.Add(label2);
            Controls.Add(BoxAsigNombre);
            Controls.Add(label1);
            Name = "RegistrarAsignatura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Asignatura";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox BoxAsigNombre;
        private Label label2;
        private ComboBox ComboBNewCursos;
        private Panel panel1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private ComboBox ComboBTecnicaAsig;
        private Button ButtonCancel;
        private Button ButtonSave;
    }
}