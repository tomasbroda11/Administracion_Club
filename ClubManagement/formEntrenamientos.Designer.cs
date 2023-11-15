namespace ClubManagement
{
    partial class formEntrenamientos
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
            btnAgregarEntrenamiento = new Button();
            btnEliminar = new Button();
            lblId = new Label();
            txtId = new TextBox();
            btnAtras = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Dia = new DataGridViewTextBoxColumn();
            HoraDesde = new DataGridViewTextBoxColumn();
            HoraHasta = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            Instalacion = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarEntrenamiento
            // 
            btnAgregarEntrenamiento.Location = new Point(605, 36);
            btnAgregarEntrenamiento.Margin = new Padding(3, 2, 3, 2);
            btnAgregarEntrenamiento.Name = "btnAgregarEntrenamiento";
            btnAgregarEntrenamiento.Size = new Size(149, 36);
            btnAgregarEntrenamiento.TabIndex = 16;
            btnAgregarEntrenamiento.Text = "Agregar Entrenamiento";
            btnAgregarEntrenamiento.UseVisualStyleBackColor = true;
            btnAgregarEntrenamiento.Click += btnAgregarEntrenamiento_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(651, 272);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(387, 254);
            lblId.Name = "lblId";
            lblId.Size = new Size(101, 15);
            lblId.TabIndex = 13;
            lblId.Text = "Id entrenamiento:";
            // 
            // txtId
            // 
            txtId.Location = new Point(389, 271);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Ingrese ID";
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 12;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(18, 330);
            btnAtras.Margin = new Padding(3, 2, 3, 2);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(103, 34);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Dia, HoraDesde, HoraHasta, Actividad, Instalacion });
            dataGridView1.Location = new Point(65, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 152);
            dataGridView1.TabIndex = 10;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Dia
            // 
            Dia.HeaderText = "Dia";
            Dia.Name = "Dia";
            // 
            // HoraDesde
            // 
            HoraDesde.HeaderText = "Desde";
            HoraDesde.Name = "HoraDesde";
            // 
            // HoraHasta
            // 
            HoraHasta.HeaderText = "Hasta";
            HoraHasta.Name = "HoraHasta";
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.Name = "Actividad";
            // 
            // Instalacion
            // 
            Instalacion.HeaderText = "Instalacion";
            Instalacion.Name = "Instalacion";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(254, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 50);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Entrenamientos";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(559, 272);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(82, 22);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // formEntrenamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 402);
            Controls.Add(btnAgregarEntrenamiento);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnAtras);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Name = "formEntrenamientos";
            Text = "formEntrenamientos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarEntrenamiento;
        private Button btnEliminar;
        private Label lblId;
        private TextBox txtId;
        private Button btnAtras;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Dia;
        private DataGridViewTextBoxColumn HoraDesde;
        private DataGridViewTextBoxColumn HoraHasta;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Instalacion;
        private Label lblTitle;
        private Button btnActualizar;
    }
}