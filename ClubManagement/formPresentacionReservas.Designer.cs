namespace ClubManagement
{
    partial class formPresentacionReservas
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
            radbutReservasMes = new RadioButton();
            radbutReservasActividad = new RadioButton();
            button1 = new Button();
            btnImprimir = new Button();
            SuspendLayout();
            // 
            // radbutReservasMes
            // 
            radbutReservasMes.AutoSize = true;
            radbutReservasMes.Location = new Point(581, 25);
            radbutReservasMes.Margin = new Padding(3, 2, 3, 2);
            radbutReservasMes.Name = "radbutReservasMes";
            radbutReservasMes.Size = new Size(116, 19);
            radbutReservasMes.TabIndex = 0;
            radbutReservasMes.TabStop = true;
            radbutReservasMes.Text = "Reservas por Mes";
            radbutReservasMes.UseVisualStyleBackColor = true;
            // 
            // radbutReservasActividad
            // 
            radbutReservasActividad.AutoSize = true;
            radbutReservasActividad.Location = new Point(581, 48);
            radbutReservasActividad.Margin = new Padding(3, 2, 3, 2);
            radbutReservasActividad.Name = "radbutReservasActividad";
            radbutReservasActividad.Size = new Size(144, 19);
            radbutReservasActividad.TabIndex = 1;
            radbutReservasActividad.TabStop = true;
            radbutReservasActividad.Text = "Reservas por Actividad";
            radbutReservasActividad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 28);
            button1.TabIndex = 2;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(128, 255, 255);
            btnImprimir.Location = new Point(620, 98);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(66, 47);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // formPresentacionReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 486);
            Controls.Add(btnImprimir);
            Controls.Add(button1);
            Controls.Add(radbutReservasActividad);
            Controls.Add(radbutReservasMes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "formPresentacionReservas";
            Text = "Hisotrico de reservas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radbutReservasMes;
        private RadioButton radbutReservasActividad;
        private Button button1;
        private Button btnImprimir;
    }
}