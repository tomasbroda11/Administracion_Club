namespace ClubManagement
{
    partial class formInstalaciones
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
            dataInstalaciones = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            Actividad = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnAtras = new Button();
            txtIdInstalacion = new TextBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataInstalaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "Instalaciones";
            // 
            // dataInstalaciones
            // 
            dataInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInstalaciones.Columns.AddRange(new DataGridViewColumn[] { Id, Descripcion, Activo, Actividad });
            dataInstalaciones.Location = new Point(128, 65);
            dataInstalaciones.Name = "dataInstalaciones";
            dataInstalaciones.RowTemplate.Height = 25;
            dataInstalaciones.Size = new Size(417, 191);
            dataInstalaciones.TabIndex = 1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            // 
            // Actividad
            // 
            Actividad.HeaderText = "Actividad";
            Actividad.Name = "Actividad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 297);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(47, 289);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(75, 30);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtIdInstalacion
            // 
            txtIdInstalacion.Location = new Point(373, 294);
            txtIdInstalacion.Name = "txtIdInstalacion";
            txtIdInstalacion.Size = new Size(76, 23);
            txtIdInstalacion.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightPink;
            btnEliminar.Location = new Point(476, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Dar de Baja";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.PaleTurquoise;
            btnActualizar.Location = new Point(572, 291);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SpringGreen;
            btnAgregar.Location = new Point(572, 65);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // formInstalaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 348);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(txtIdInstalacion);
            Controls.Add(btnAtras);
            Controls.Add(label2);
            Controls.Add(dataInstalaciones);
            Controls.Add(label1);
            Name = "formInstalaciones";
            Text = "Instalaciones";
            Load += formInstalacion_Load;
            ((System.ComponentModel.ISupportInitialize)dataInstalaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataInstalaciones;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn Actividad;
        private Label label2;
        private Button btnAtras;
        private TextBox txtIdInstalacion;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}