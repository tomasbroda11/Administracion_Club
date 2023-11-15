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
            radbutTotalReservas = new RadioButton();
            radbutPorActividad = new RadioButton();
            SuspendLayout();
            // 
            // radbutTotalReservas
            // 
            radbutTotalReservas.AutoSize = true;
            radbutTotalReservas.Location = new Point(978, 12);
            radbutTotalReservas.Name = "radbutTotalReservas";
            radbutTotalReservas.Size = new Size(120, 24);
            radbutTotalReservas.TabIndex = 0;
            radbutTotalReservas.TabStop = true;
            radbutTotalReservas.Text = "Total reservas";
            radbutTotalReservas.UseVisualStyleBackColor = true;
            radbutTotalReservas.CheckedChanged += radbutTotalReservas_CheckedChanged;
            // 
            // radbutPorActividad
            // 
            radbutPorActividad.AutoSize = true;
            radbutPorActividad.Location = new Point(981, 42);
            radbutPorActividad.Name = "radbutPorActividad";
            radbutPorActividad.Size = new Size(116, 24);
            radbutPorActividad.TabIndex = 1;
            radbutPorActividad.TabStop = true;
            radbutPorActividad.Text = "Por actividad";
            radbutPorActividad.UseVisualStyleBackColor = true;
            radbutPorActividad.CheckedChanged += radbutPorActividad_CheckedChanged;
            // 
            // formPresentacionReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 606);
            Controls.Add(radbutPorActividad);
            Controls.Add(radbutTotalReservas);
            Name = "formPresentacionReservas";
            Text = "Hisotrico de reservas";
            Load += formPresentacionReservas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radbutTotalReservas;
        private RadioButton radbutPorActividad;
    }
}