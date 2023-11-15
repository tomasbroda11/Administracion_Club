namespace ClubManagement
{
    partial class formEditEntrenamiento
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
            cbInstalacion = new ComboBox();
            lblInstalacion = new Label();
            cbDia = new ComboBox();
            lblDia = new Label();
            cbHoraHasta = new ComboBox();
            lblHoraHasta = new Label();
            btnAceptar = new Button();
            cbHoraDesde = new ComboBox();
            lblHoraDesde = new Label();
            btnAtras = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // cbInstalacion
            // 
            cbInstalacion.FormattingEnabled = true;
            cbInstalacion.Location = new Point(194, 300);
            cbInstalacion.Name = "cbInstalacion";
            cbInstalacion.Size = new Size(253, 28);
            cbInstalacion.TabIndex = 35;
            // 
            // lblInstalacion
            // 
            lblInstalacion.AutoSize = true;
            lblInstalacion.Location = new Point(110, 304);
            lblInstalacion.Name = "lblInstalacion";
            lblInstalacion.Size = new Size(83, 20);
            lblInstalacion.TabIndex = 34;
            lblInstalacion.Text = "Instalación:";
            // 
            // cbDia
            // 
            cbDia.FormattingEnabled = true;
            cbDia.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" });
            cbDia.Location = new Point(194, 168);
            cbDia.Name = "cbDia";
            cbDia.Size = new Size(253, 28);
            cbDia.TabIndex = 33;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(160, 172);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(35, 20);
            lblDia.TabIndex = 32;
            lblDia.Text = "Dia:";
            // 
            // cbHoraHasta
            // 
            cbHoraHasta.BackColor = SystemColors.InactiveCaption;
            cbHoraHasta.Enabled = false;
            cbHoraHasta.FormattingEnabled = true;
            cbHoraHasta.Location = new Point(562, 233);
            cbHoraHasta.Name = "cbHoraHasta";
            cbHoraHasta.Size = new Size(253, 28);
            cbHoraHasta.TabIndex = 31;
            // 
            // lblHoraHasta
            // 
            lblHoraHasta.AutoSize = true;
            lblHoraHasta.Location = new Point(478, 237);
            lblHoraHasta.Name = "lblHoraHasta";
            lblHoraHasta.Size = new Size(87, 20);
            lblHoraHasta.TabIndex = 30;
            lblHoraHasta.Text = "Hora Hasta:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Highlight;
            btnAceptar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(595, 472);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 53);
            btnAceptar.TabIndex = 29;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // cbHoraDesde
            // 
            cbHoraDesde.FormattingEnabled = true;
            cbHoraDesde.Location = new Point(194, 233);
            cbHoraDesde.Name = "cbHoraDesde";
            cbHoraDesde.Size = new Size(253, 28);
            cbHoraDesde.TabIndex = 28;
            cbHoraDesde.SelectedValueChanged += cbHoraDesde_SelectedValueChanged_1;
            // 
            // lblHoraDesde
            // 
            lblHoraDesde.AutoSize = true;
            lblHoraDesde.Location = new Point(110, 237);
            lblHoraDesde.Name = "lblHoraDesde";
            lblHoraDesde.Size = new Size(91, 20);
            lblHoraDesde.TabIndex = 27;
            lblHoraDesde.Text = "Hora Desde:";
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(174, 480);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(118, 45);
            btnAtras.TabIndex = 26;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(249, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(493, 62);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Editar Entrenamiento";
            // 
            // formEditEntrenamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cbInstalacion);
            Controls.Add(lblInstalacion);
            Controls.Add(cbDia);
            Controls.Add(lblDia);
            Controls.Add(cbHoraHasta);
            Controls.Add(lblHoraHasta);
            Controls.Add(btnAceptar);
            Controls.Add(cbHoraDesde);
            Controls.Add(lblHoraDesde);
            Controls.Add(btnAtras);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formEditEntrenamiento";
            Text = "formEditEntrenamiento";
            Load += formEditEntrenamiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbInstalacion;
        private Label lblInstalacion;
        private ComboBox cbDia;
        private Label lblDia;
        private ComboBox cbHoraHasta;
        private Label lblHoraHasta;
        private Button btnAceptar;
        private ComboBox cbHoraDesde;
        private Label lblHoraDesde;
        private Button btnAtras;
        private Label lblTitle;
    }
}