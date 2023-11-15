using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClubManagement
{
    public partial class formMenuAdmin : Form
    {
        public formMenuAdmin()
        {
            InitializeComponent();
        }

        private void btn_menu_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSocios formSocios = new formSocios();
            formSocios.ShowDialog();
            this.Close();
        }

        private void formMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.Hide();
            formProfesores formProfe = new formProfesores();
            formProfe.ShowDialog();
            this.Close();
        }

        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstalaciones formInstalacion = new formInstalaciones();
            formInstalacion.ShowDialog();
            this.Close();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ImprimirReservasDelDia();
        }
        private void ImprimirReservasDelDia()
        {

            DateTime fechaActual = DateTime.Now.Date;
            ABMreservas abmr = new ABMreservas();
            List<Reserva> reservas = abmr.reservasPorFecha(fechaActual);

            if (reservas.Count > 0)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (sender, e) =>
                {
                    float yPos = 10;

                    foreach (Reserva reserva in reservas)
                    {
                        e.Graphics.DrawString($"\n\nReserva #{reserva.Id}\n" +
                                              $"Fecha y Hora: {reserva.Turno}\n" +
                                              $"Usuario: {reserva.Persona.getNombre()} {reserva.Persona.getApellido()}\n" +
                                              $"Instalación: {reserva.Instalacion.getDescripcion()}\n\n",
                                              new Font("Arial", 14, FontStyle.Bold),
                                              Brushes.Black,
                                              new PointF(10, yPos));

                        yPos += 100;
                    }
                };
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay reservas para imprimir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();    
            formPresentacionReservas formPres = new formPresentacionReservas();
            formPres.ShowDialog();
            this.Close();
        }
    }
}

