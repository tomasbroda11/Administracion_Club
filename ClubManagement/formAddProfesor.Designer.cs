namespace ClubManagement
{
    partial class formAddProfesor
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
            lblTitle = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblMail = new Label();
            lblValidar = new Label();
            txtRepitePass = new TextBox();
            txtPass = new TextBox();
            lblConfPass = new Label();
            lblPass = new Label();
            cbActividad = new ComboBox();
            label1 = new Label();
            btnAtras = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(235, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(322, 50);
            lblTitle.TabIndex = 34;
            lblTitle.Text = "Agregar Profesor";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.Window;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(259, 82);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(298, 27);
            txtDNI.TabIndex = 29;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(218, 86);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 33;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(259, 141);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(259, 204);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(298, 27);
            txtApellido.TabIndex = 31;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(259, 258);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(298, 27);
            txtMail.TabIndex = 32;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(193, 204);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 26;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(191, 145);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(218, 262);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 20);
            lblMail.TabIndex = 28;
            lblMail.Text = "Mail";
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidar.Location = new Point(317, 472);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(91, 25);
            lblValidar.TabIndex = 39;
            lblValidar.Text = "validador";
            lblValidar.Visible = false;
            // 
            // txtRepitePass
            // 
            txtRepitePass.BackColor = SystemColors.Window;
            txtRepitePass.BorderStyle = BorderStyle.FixedSingle;
            txtRepitePass.Cursor = Cursors.IBeam;
            txtRepitePass.Location = new Point(259, 370);
            txtRepitePass.Margin = new Padding(3, 4, 3, 4);
            txtRepitePass.Name = "txtRepitePass";
            txtRepitePass.PasswordChar = '*';
            txtRepitePass.Size = new Size(298, 27);
            txtRepitePass.TabIndex = 38;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(259, 307);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(298, 27);
            txtPass.TabIndex = 37;
            // 
            // lblConfPass
            // 
            lblConfPass.AutoSize = true;
            lblConfPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfPass.Location = new Point(98, 372);
            lblConfPass.Name = "lblConfPass";
            lblConfPass.Size = new Size(155, 20);
            lblConfPass.TabIndex = 36;
            lblConfPass.Text = "Confirma contraseña";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(173, 311);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(88, 20);
            lblPass.TabIndex = 35;
            lblPass.Text = "Contraseña";
            // 
            // cbActividad
            // 
            cbActividad.FormattingEnabled = true;
            cbActividad.Items.AddRange(new object[] { "Natación", "Fútbol", "Tenis", "Yoga", "Baloncesto", "Voleibol", "Hockey", "Rugby" });
            cbActividad.Location = new Point(259, 430);
            cbActividad.Name = "cbActividad";
            cbActividad.Size = new Size(298, 28);
            cbActividad.TabIndex = 40;
            cbActividad.SelectedValueChanged += cbActividad_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 433);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 41;
            label1.Text = "Actividad";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(231, 511);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 29);
            btnAtras.TabIndex = 42;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(453, 511);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 43;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // formAddProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(btnAceptar);
            Controls.Add(btnAtras);
            Controls.Add(label1);
            Controls.Add(cbActividad);
            Controls.Add(lblValidar);
            Controls.Add(txtRepitePass);
            Controls.Add(txtPass);
            Controls.Add(lblConfPass);
            Controls.Add(lblPass);
            Controls.Add(lblTitle);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblMail);
            Name = "formAddProfesor";
            Text = "Añadir profesor";
            Load += formAddProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblMail;
        private Label lblValidar;
        private TextBox txtRepitePass;
        private TextBox txtPass;
        private Label lblConfPass;
        private Label lblPass;
        private ComboBox cbActividad;
        private Label label1;
        private Button btnAtras;
        private Button btnAceptar;
    }
}