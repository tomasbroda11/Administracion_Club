using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ClubManagement
{
    public partial class formPresentacionReservas : Form
    {
        private Chart chartReservas;

        public formPresentacionReservas()
        {
            InitializeComponent();

            InicializarChart();

            radbutReservasMes.CheckedChanged += RadioButton_CheckedChanged;
            radbutReservasActividad.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void InicializarChart()
        {
            chartReservas = new Chart();

            chartReservas.Size = new System.Drawing.Size(500, 400);
            chartReservas.Location = new System.Drawing.Point(50, 50);

            this.Controls.Add(chartReservas);

            ConfigurarChartPorMes();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radbutReservasMes.Checked)
            {
                ConfigurarChartPorMes();
            }
            else if (radbutReservasActividad.Checked)
            {
                ConfigurarChartPorActividad();
            }
        }

        private void ConfigurarChartPorMes()
        {
            chartReservas.Series.Clear();
            chartReservas.ChartAreas.Clear();

            Series series = new Series("Reservas por Mes");

            ABMreservas abmReservas = new ABMreservas();
            List<Reserva> listadoReservas = abmReservas.consultarReservas();

            Dictionary<string, int> reservasPorMes = new Dictionary<string, int>();

            // Inicializa el diccionario con todos los meses y cantidad inicial en 0
            foreach (var month in System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat.MonthNames.Take(12))
            {
                reservasPorMes.Add(month, 0);
            }

            // Llena el diccionario con las reservas reales
            foreach (Reserva reserva in listadoReservas)
            {
                string nombreMes = reserva.Turno.ToString("MMMM", System.Globalization.CultureInfo.InvariantCulture);
                reservasPorMes[nombreMes] += 1; // O utiliza la lógica necesaria según tus datos
            }

            // Agrega los puntos al gráfico según el diccionario
            foreach (var kvp in reservasPorMes)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            series.ChartType = SeriesChartType.Column;

            chartReservas.Series.Add(series);

            chartReservas.ChartAreas.Add("Default");
            chartReservas.ChartAreas["Default"].AxisX.Title = "Meses";
            chartReservas.ChartAreas["Default"].AxisY.Title = "Cantidad de Reservas";
        }


        private void ConfigurarChartPorActividad()
        {
            chartReservas.Series.Clear();
            chartReservas.ChartAreas.Clear();

            Series series = new Series("Reservas por Actividad");
            series.ChartType = SeriesChartType.Pie;

            ABMreservas abmReservas = new ABMreservas();
            List<Reserva> listadoReservas = abmReservas.consultarReservas();

            // Recorre las reservas y cuenta la cantidad por actividad
            Dictionary<string, int> reservasPorActividad = new Dictionary<string, int>();

            foreach (Reserva reserva in listadoReservas)
            {
                // Accede a la instalación asociada a la reserva
                Instalacion instalacion = reserva.Instalacion;

                if (instalacion != null)
                {
                    // Accede a la actividad asociada a la instalación
                    Actividad actividad = instalacion.Actividad;

                    if (actividad != null)
                    {
                        // Cuenta la reserva por actividad
                        string descripcionActividad = actividad.getDescripcion();
                        if (reservasPorActividad.ContainsKey(descripcionActividad))
                        {
                            reservasPorActividad[descripcionActividad]++;
                        }
                        else
                        {
                            reservasPorActividad.Add(descripcionActividad, 1);
                        }
                    }
                }
            }

            // Agrega los puntos al gráfico
            foreach (var kvp in reservasPorActividad)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.Label = $"{kvp.Key}: {kvp.Value}"; // Agrega la cantidad a la etiqueta
                dataPoint.YValues = new double[] { kvp.Value };
                series.Points.Add(dataPoint);
            }

            chartReservas.Series.Add(series);
            chartReservas.ChartAreas.Add("Default");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuAdmin formMenuAdmin = new formMenuAdmin();
            formMenuAdmin.ShowDialog();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler((s, ev) => ImprimirGrafico(s, ev));

                // Aquí puedes ajustar las propiedades de la impresión, como la impresora seleccionada
                printDocument.PrinterSettings = printDialog.PrinterSettings;

                printDocument.Print();
            }
        }

        private void ImprimirGrafico(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(chartReservas.Width, chartReservas.Height);
            chartReservas.DrawToBitmap(bmp, new Rectangle(0, 0, chartReservas.Width, chartReservas.Height));

            e.Graphics.DrawImage(bmp, e.MarginBounds);

            // Puedes agregar más contenido a imprimir, como el tipo de impresión
            string tipoImpresion = radbutReservasMes.Checked ? "Total de Reservas por Mes" : "Total de Reservas por Actividad";
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString(tipoImpresion, font, Brushes.Black, new PointF(e.MarginBounds.Left, e.MarginBounds.Top - 40));
        }
    }
}
