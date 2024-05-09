namespace Windows_Forms_Prueba
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
            BoxNewNameProf = new TextBox();
            label2 = new Label();
            LabelNameProf = new Label();
            label1 = new Label();
            ComboProfSearch = new ComboBox();
            label3 = new Label();
            BoxNewPassProf = new TextBox();
            PanelProfInfo.SuspendLayout();
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
            PanelProfInfo.Controls.Add(BoxNewPassProf);
            PanelProfInfo.Controls.Add(label3);
            PanelProfInfo.Controls.Add(BoxNewNameProf);
            PanelProfInfo.Controls.Add(label2);
            PanelProfInfo.Controls.Add(LabelNameProf);
            PanelProfInfo.Location = new Point(-1, 39);
            PanelProfInfo.Name = "PanelProfInfo";
            PanelProfInfo.Size = new Size(801, 413);
            PanelProfInfo.TabIndex = 3;
            PanelProfInfo.Visible = false;
            // 
            // BoxNewNameProf
            // 
            BoxNewNameProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewNameProf.Location = new Point(193, 98);
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
            label2.Location = new Point(35, 98);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 3;
            label3.Text = "Nueva Contraseña:";
            // 
            // BoxNewPassProf
            // 
            BoxNewPassProf.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BoxNewPassProf.Location = new Point(193, 150);
            BoxNewPassProf.Name = "BoxNewPassProf";
            BoxNewPassProf.Size = new Size(240, 32);
            BoxNewPassProf.TabIndex = 4;
            // 
            // EditarProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(800, 450);
            Controls.Add(ComboProfSearch);
            Controls.Add(label1);
            Controls.Add(PanelProfInfo);
            Controls.Add(ButtonSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "EditarProfesor";
            ShowIcon = false;
            Text = "EditarProfesor";
            PanelProfInfo.ResumeLayout(false);
            PanelProfInfo.PerformLayout();
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
    }
}