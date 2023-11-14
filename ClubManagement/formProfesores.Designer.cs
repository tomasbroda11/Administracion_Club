namespace ClubManagement
{
    partial class formProfesores
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
            dataProfesores = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            btnAtras = new Button();
            txtDni = new TextBox();
            lblIngresar = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataProfesores).BeginInit();
            SuspendLayout();
            // 
            // dataProfesores
            // 
            dataProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProfesores.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Apellido, Email, Actividad });
            dataProfesores.Location = new Point(57, 118);
            dataProfesores.Name = "dataProfesores";
            dataProfesores.RowHeadersWidth = 51;
            dataProfesores.RowTemplate.Height = 29;
            dataProfesores.Size = new Size(699, 227);
            dataProfesores.TabIndex = 0;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.MinimumWidth = 6;
            Actividad.Name = "Actividad";
            Actividad.Width = 125;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(304, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Profesores";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(26, 386);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(105, 42);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(408, 387);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(148, 27);
            txtDni.TabIndex = 3;
            // 
            // lblIngresar
            // 
            lblIngresar.AutoSize = true;
            lblIngresar.Location = new Point(317, 390);
            lblIngresar.Name = "lblIngresar";
            lblIngresar.Size = new Size(85, 20);
            lblIngresar.TabIndex = 4;
            lblIngresar.Text = "Ingrese dni:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(562, 385);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(662, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(638, 64);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 39);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // formProfesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(lblIngresar);
            Controls.Add(txtDni);
            Controls.Add(btnAtras);
            Controls.Add(lblTitulo);
            Controls.Add(dataProfesores);
            Name = "formProfesores";
            Text = "Profesores";
            Load += formProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dataProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataProfesores;
        private Label lblTitulo;
        private Button btnAtras;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Actividad;
        private TextBox txtDni;
        private Label lblIngresar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnAgregar;
    }
}