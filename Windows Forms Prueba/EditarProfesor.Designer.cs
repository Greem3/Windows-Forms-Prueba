﻿namespace Windows_Forms_Prueba
{
    partial class EditarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProfesor));
            ButtonSearch = new Button();
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
            BoxNewPassProf = new TextBox();
            label3 = new Label();
            BoxNewNameProf = new TextBox();
            label2 = new Label();
            LabelNameProf = new Label();
            label1 = new Label();
            ComboProfSearch = new ComboBox();
            PanelProfInfo.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.BackColor = Color.Transparent;
            ButtonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSearch.Location = new Point(664, 4);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(136, 31);
            ButtonSearch.TabIndex = 2;
            ButtonSearch.Text = "Buscar";
            ButtonSearch.TextAlign = ContentAlignment.TopCenter;
            ButtonSearch.UseVisualStyleBackColor = false;
            ButtonSearch.Click += BuscarProf_Click;
            // 
            // PanelProfInfo
            // 
            PanelProfInfo.Controls.Add(ButtonCancel);
            PanelProfInfo.Controls.Add(ButtonSave);
            PanelProfInfo.Controls.Add(panel3);
            PanelProfInfo.Controls.Add(panel2);
            PanelProfInfo.Controls.Add(panel1);
            PanelProfInfo.Controls.Add(BoxNewPassProf);
            PanelProfInfo.Controls.Add(label3);
            PanelProfInfo.Controls.Add(BoxNewNameProf);
            PanelProfInfo.Controls.Add(label2);
            PanelProfInfo.Controls.Add(LabelNameProf);
            PanelProfInfo.Location = new Point(-1, 39);
            PanelProfInfo.Name = "PanelProfInfo";
            PanelProfInfo.Size = new Size(902, 685);
            PanelProfInfo.TabIndex = 3;
            PanelProfInfo.Visible = false;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(791, 640);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(94, 29);
            ButtonCancel.TabIndex = 13;
            ButtonCancel.Text = "Cancelar";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += CancelProf_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(691, 640);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 29);
            ButtonSave.TabIndex = 12;
            ButtonSave.Text = "Guardar";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += GuardarProf_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ListBAsigTecnicas);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(442, 406);
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
            label6.Size = new Size(257, 28);
            label6.TabIndex = 6;
            label6.Text = "Asignaturas técnicas que da:";
            // 
            // panel2
            // 
            panel2.Controls.Add(ListBAsigAcademicas);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(20, 406);
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
            label4.Size = new Size(288, 28);
            label4.TabIndex = 6;
            label4.Text = "Asignaturas academicas que da:";
            // 
            // panel1
            // 
            panel1.Controls.Add(ListBTecnicas);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(20, 178);
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
            // BoxNewPassProf
            // 
            BoxNewPassProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewPassProf.Location = new Point(193, 118);
            BoxNewPassProf.Name = "BoxNewPassProf";
            BoxNewPassProf.PasswordChar = '*';
            BoxNewPassProf.Size = new Size(240, 32);
            BoxNewPassProf.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 3;
            label3.Text = "Nueva Contraseña:";
            // 
            // BoxNewNameProf
            // 
            BoxNewNameProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewNameProf.Location = new Point(193, 66);
            BoxNewNameProf.Name = "BoxNewNameProf";
            BoxNewNameProf.Size = new Size(240, 32);
            BoxNewNameProf.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(35, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 1;
            label2.Text = "Nuevo Nombre:";
            // 
            // LabelNameProf
            // 
            LabelNameProf.AutoSize = true;
            LabelNameProf.BackColor = Color.White;
            LabelNameProf.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNameProf.Location = new Point(20, 11);
            LabelNameProf.Name = "LabelNameProf";
            LabelNameProf.Size = new Size(145, 32);
            LabelNameProf.TabIndex = 0;
            LabelNameProf.Text = "NombreProf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(-1, 3);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 4;
            label1.Text = "Buscar Profesor:";
            // 
            // ComboProfSearch
            // 
            ComboProfSearch.FormattingEnabled = true;
            ComboProfSearch.Items.AddRange(new object[] { "José Luis", "Pedro Reyes", "Verkis Galvan", "José Santana" });
            ComboProfSearch.Location = new Point(155, 5);
            ComboProfSearch.Name = "ComboProfSearch";
            ComboProfSearch.Size = new Size(503, 28);
            ComboProfSearch.TabIndex = 5;
            // 
            // EditarProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(896, 720);
            Controls.Add(ComboProfSearch);
            Controls.Add(label1);
            Controls.Add(PanelProfInfo);
            Controls.Add(ButtonSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "EditarProfesor";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Profesor";
            PanelProfInfo.ResumeLayout(false);
            PanelProfInfo.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonSearch;
        private Panel PanelProfInfo;
        private Label label1;
        private ComboBox ComboProfSearch;
        private Label LabelNameProf;
        private Label label2;
        private TextBox BoxNewNameProf;
        private Label label3;
        private TextBox BoxNewPassProf;
        private CheckedListBox ListBAsigAcademicas;
        private Label label4;
        private Label label5;
        private CheckedListBox ListBTecnicas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private CheckedListBox ListBAsigTecnicas;
        private Label label6;
        private Button ButtonSave;
        private Button ButtonCancel;
    }
}