namespace Windows_Forms_Prueba
{
    partial class ListProfesores
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
            PanelListProfs = new Panel();
            DGVListaProfesores = new DataGridView();
            ProfNombre1 = new DataGridViewTextBoxColumn();
            ProfNombre2 = new DataGridViewTextBoxColumn();
            ProfApellido1 = new DataGridViewTextBoxColumn();
            ProfApellido2 = new DataGridViewTextBoxColumn();
            ProfClaseEncargada = new DataGridViewTextBoxColumn();
            ProfClasesAcademicas = new DataGridViewTextBoxColumn();
            ProfClasesTecnicas = new DataGridViewTextBoxColumn();
            PanelListProfs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVListaProfesores).BeginInit();
            SuspendLayout();
            // 
            // PanelListProfs
            // 
            PanelListProfs.BackColor = Color.Transparent;
            PanelListProfs.Controls.Add(DGVListaProfesores);
            PanelListProfs.Location = new Point(0, 1);
            PanelListProfs.Name = "PanelListProfs";
            PanelListProfs.Size = new Size(1723, 1002);
            PanelListProfs.TabIndex = 14;
            PanelListProfs.Visible = false;
            // 
            // DGVListaProfesores
            // 
            DGVListaProfesores.BackgroundColor = Color.FromArgb(40, 40, 40);
            DGVListaProfesores.BorderStyle = BorderStyle.None;
            DGVListaProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVListaProfesores.Columns.AddRange(new DataGridViewColumn[] { ProfNombre1, ProfNombre2, ProfApellido1, ProfApellido2, ProfClaseEncargada, ProfClasesAcademicas, ProfClasesTecnicas });
            DGVListaProfesores.Location = new Point(0, 0);
            DGVListaProfesores.Name = "DGVListaProfesores";
            DGVListaProfesores.ReadOnly = true;
            DGVListaProfesores.RowHeadersWidth = 51;
            DGVListaProfesores.RowTemplate.Height = 28;
            DGVListaProfesores.Size = new Size(1121, 336);
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
            // ProfClasesAcademicas
            // 
            ProfClasesAcademicas.HeaderText = "Clases Academicas";
            ProfClasesAcademicas.MinimumWidth = 6;
            ProfClasesAcademicas.Name = "ProfClasesAcademicas";
            ProfClasesAcademicas.ReadOnly = true;
            ProfClasesAcademicas.Width = 175;
            // 
            // ProfClasesTecnicas
            // 
            ProfClasesTecnicas.HeaderText = "Clases Técnicas";
            ProfClasesTecnicas.MinimumWidth = 6;
            ProfClasesTecnicas.Name = "ProfClasesTecnicas";
            ProfClasesTecnicas.ReadOnly = true;
            ProfClasesTecnicas.Width = 140;
            // 
            // ListProfesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1705, 955);
            Controls.Add(PanelListProfs);
            Name = "ListProfesores";
            Text = "ListProfesores";
            PanelListProfs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVListaProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelListProfs;
        private DataGridView DGVListaProfesores;
        private DataGridViewTextBoxColumn ProfNombre1;
        private DataGridViewTextBoxColumn ProfNombre2;
        private DataGridViewTextBoxColumn ProfApellido1;
        private DataGridViewTextBoxColumn ProfApellido2;
        private DataGridViewTextBoxColumn ProfClaseEncargada;
        private DataGridViewTextBoxColumn ProfClasesAcademicas;
        private DataGridViewTextBoxColumn ProfClasesTecnicas;
    }
}