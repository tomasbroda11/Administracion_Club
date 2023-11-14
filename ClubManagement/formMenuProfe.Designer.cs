namespace ClubManagement
{
    partial class formMenuProfe
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
            btn_menu_salir = new Button();
            btnDatos = new Button();
            button3 = new Button();
            btnEntrenamientos = new Button();
            btnSocios = new Button();
            btnProfesores = new Button();
            lblMenu = new Label();
            SuspendLayout();
            // 
            // btn_menu_salir
            // 
            btn_menu_salir.BackColor = Color.LightCoral;
            btn_menu_salir.Location = new Point(258, 295);
            btn_menu_salir.Name = "btn_menu_salir";
            btn_menu_salir.Size = new Size(161, 33);
            btn_menu_salir.TabIndex = 15;
            btn_menu_salir.Text = "Salir";
            btn_menu_salir.UseVisualStyleBackColor = false;
            btn_menu_salir.Click += btn_menu_salir_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(258, 251);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(161, 33);
            btnDatos.TabIndex = 14;
            btnDatos.Text = "Mis Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // button3
            // 
            button3.Location = new Point(258, 212);
            button3.Name = "button3";
            button3.Size = new Size(161, 33);
            button3.TabIndex = 13;
            button3.Text = "Actividades";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnEntrenamientos
            // 
            btnEntrenamientos.BackColor = Color.FromArgb(192, 192, 255);
            btnEntrenamientos.Location = new Point(258, 82);
            btnEntrenamientos.Name = "btnEntrenamientos";
            btnEntrenamientos.Size = new Size(161, 33);
            btnEntrenamientos.TabIndex = 12;
            btnEntrenamientos.Text = "Mis entrenamientos";
            btnEntrenamientos.UseVisualStyleBackColor = false;
            btnEntrenamientos.Click += btnEntrenamientos_Click;
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(258, 134);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(161, 33);
            btnSocios.TabIndex = 11;
            btnSocios.Text = "Socios";
            btnSocios.UseVisualStyleBackColor = true;
            // 
            // btnProfesores
            // 
            btnProfesores.Location = new Point(258, 173);
            btnProfesores.Name = "btnProfesores";
            btnProfesores.Size = new Size(161, 33);
            btnProfesores.TabIndex = 10;
            btnProfesores.Text = "Profesores";
            btnProfesores.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(226, 19);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(231, 37);
            lblMenu.TabIndex = 9;
            lblMenu.Text = "Panel Profesores";
            // 
            // formMenuProfe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_menu_salir);
            Controls.Add(btnDatos);
            Controls.Add(button3);
            Controls.Add(btnEntrenamientos);
            Controls.Add(btnSocios);
            Controls.Add(btnProfesores);
            Controls.Add(lblMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formMenuProfe";
            Text = "Profesores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_menu_salir;
        private Button btnDatos;
        private Button button3;
        private Button btnEntrenamientos;
        private Button btnSocios;
        private Button btnProfesores;
        private Label lblMenu;
    }
}