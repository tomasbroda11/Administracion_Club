namespace ClubManagement
{
    partial class formActualizarInstalacion
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
            btnCancelar = new Button();
            label2 = new Label();
            cbActividades = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbActivo = new ComboBox();
            txtDescripcion = new TextBox();
            txtID = new TextBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(261, 32);
            label1.TabIndex = 1;
            label1.Text = "Actualizar Instalacion";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 192, 192);
            btnCancelar.Location = new Point(169, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 30);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(116, 211);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Actividad";
            // 
            // cbActividades
            // 
            cbActividades.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActividades.FlatStyle = FlatStyle.System;
            cbActividades.FormattingEnabled = true;
            cbActividades.Location = new Point(181, 208);
            cbActividades.Name = "cbActividades";
            cbActividades.Size = new Size(237, 23);
            cbActividades.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 101);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 7;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(103, 139);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 8;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(133, 174);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Activa";
            // 
            // cbActivo
            // 
            cbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActivo.FlatStyle = FlatStyle.System;
            cbActivo.FormattingEnabled = true;
            cbActivo.Items.AddRange(new object[] { "0", "1" });
            cbActivo.Location = new Point(181, 171);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(237, 23);
            cbActivo.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(181, 136);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(237, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(181, 98);
            txtID.Name = "txtID";
            txtID.Size = new Size(237, 23);
            txtID.TabIndex = 12;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 255, 255);
            btnActualizar.Location = new Point(343, 303);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 30);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // formActualizarInstalacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 345);
            Controls.Add(btnActualizar);
            Controls.Add(txtID);
            Controls.Add(txtDescripcion);
            Controls.Add(cbActivo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbActividades);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Name = "formActualizarInstalacion";
            Text = "formActualizarInstalacion";
            Load += formActualizarInstalacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private Label label2;
        private ComboBox cbActividades;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbActivo;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private Button btnActualizar;
    }
}