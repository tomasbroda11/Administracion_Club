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
            SuspendLayout();
            // 
            // radbutTotalReservas
            // 
            radbutTotalReservas.AutoSize = true;
            radbutTotalReservas.Location = new Point(885, 65);
            radbutTotalReservas.Name = "radbutTotalReservas";
            radbutTotalReservas.Size = new Size(120, 24);
            radbutTotalReservas.TabIndex = 0;
            radbutTotalReservas.TabStop = true;
            radbutTotalReservas.Text = "Total reservas";
            radbutTotalReservas.UseVisualStyleBackColor = true;
            radbutTotalReservas.CheckedChanged += radbutTotalReservas_CheckedChanged;
            // 
            // formPresentacionReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 606);
            Controls.Add(radbutTotalReservas);
            Name = "formPresentacionReservas";
            Text = "Hisotrico de reservas";
            Load += formPresentacionReservas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radbutTotalReservas;
    }
}