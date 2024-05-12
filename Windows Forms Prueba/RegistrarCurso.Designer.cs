namespace Windows_Forms_Prueba
{
    partial class RegistrarCurso
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
            ComboBNewCursos = new ComboBox();
            label2 = new Label();
            BoxAsigNombre = new TextBox();
            label1 = new Label();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ComboBNewCursos
            // 
            ComboBNewCursos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBNewCursos.AutoCompleteSource = AutoCompleteSource.ListItems;
            ComboBNewCursos.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBNewCursos.FormattingEnabled = true;
            ComboBNewCursos.Items.AddRange(new object[] { "Académica", "Técnica" });
            ComboBNewCursos.Location = new Point(205, 100);
            ComboBNewCursos.Name = "ComboBNewCursos";
            ComboBNewCursos.Size = new Size(240, 28);
            ComboBNewCursos.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(133, 96);
            label2.Name = "label2";
            label2.Size = new Size(66, 32);
            label2.TabIndex = 18;
            label2.Text = "Tipo:";
            // 
            // BoxAsigNombre
            // 
            BoxAsigNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxAsigNombre.Location = new Point(205, 42);
            BoxAsigNombre.Name = "BoxAsigNombre";
            BoxAsigNombre.PlaceholderText = "Nombre";
            BoxAsigNombre.Size = new Size(240, 32);
            BoxAsigNombre.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(92, 40);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(547, 204);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 21;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(447, 204);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 20;
            ButtonSave.Text = "Registrar";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(4, 148);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 22;
            label3.Text = "Número de Aula:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(205, 155);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(71, 27);
            numericUpDown1.TabIndex = 23;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // RegistrarCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(658, 247);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(ComboBNewCursos);
            Controls.Add(label2);
            Controls.Add(BoxAsigNombre);
            Controls.Add(label1);
            Name = "RegistrarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarCurso";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBNewCursos;
        private Label label2;
        private TextBox BoxAsigNombre;
        private Label label1;
        private Button ButtonCancel;
        private Button ButtonSave;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}