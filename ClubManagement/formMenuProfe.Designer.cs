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
            btnEntrenamientos = new Button();
            lblMenu = new Label();
            SuspendLayout();
            // 
            // btn_menu_salir
            // 
            btn_menu_salir.BackColor = Color.LightCoral;
            btn_menu_salir.Location = new Point(296, 311);
            btn_menu_salir.Margin = new Padding(3, 4, 3, 4);
            btn_menu_salir.Name = "btn_menu_salir";
            btn_menu_salir.Size = new Size(184, 44);
            btn_menu_salir.TabIndex = 15;
            btn_menu_salir.Text = "Salir";
            btn_menu_salir.UseVisualStyleBackColor = false;
            btn_menu_salir.Click += btn_menu_salir_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(296, 218);
            btnDatos.Margin = new Padding(3, 4, 3, 4);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(184, 44);
            btnDatos.TabIndex = 14;
            btnDatos.Text = "Mis Datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // btnEntrenamientos
            // 
            btnEntrenamientos.BackColor = Color.FromArgb(192, 192, 255);
            btnEntrenamientos.Location = new Point(296, 157);
            btnEntrenamientos.Margin = new Padding(3, 4, 3, 4);
            btnEntrenamientos.Name = "btnEntrenamientos";
            btnEntrenamientos.Size = new Size(184, 44);
            btnEntrenamientos.TabIndex = 12;
            btnEntrenamientos.Text = "Mis entrenamientos";
            btnEntrenamientos.UseVisualStyleBackColor = false;
            btnEntrenamientos.Click += btnEntrenamientos_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(258, 25);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(285, 46);
            lblMenu.TabIndex = 9;
            lblMenu.Text = "Panel Profesores";
            // 
            // formMenuProfe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btn_menu_salir);
            Controls.Add(btnDatos);
            Controls.Add(btnEntrenamientos);
            Controls.Add(lblMenu);
            Name = "formMenuProfe";
            Text = "Profesores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_menu_salir;
        private Button btnDatos;
        private Button btnEntrenamientos;
        private Label lblMenu;
    }
}