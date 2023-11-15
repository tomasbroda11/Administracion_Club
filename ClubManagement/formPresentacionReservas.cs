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
        private Chart chartReservasMes;
        private Chart chartReservasActividad;


        public formPresentacionReservas()
        {
            InitializeComponent();
            InitializeCharts();
            InitializeRadioButtons();

            radbutTotalReservas.CheckedChanged += (s, e) => CargarDatos();

        }

        private void InitializeCharts()
        {
            chartReservasMes = InitializeChart("Total de Reservas por Mes");
            chartReservasActividad = InitializeChart("Total de Reservas por Actividad");

            Controls.Add(chartReservasMes);
            Controls.Add(chartReservasActividad);
            chartReservasActividad.Visible = false;
        }

        private Chart InitializeChart(string title)
        {
            Chart chart = new Chart
            {
                Size = new Size(600, 400)
            };

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("Reservas")
            {
                ChartType = SeriesChartType.Column
            };
            chart.Series.Add(series);

            chartArea.AxisX.Title = "Meses o Actividades";
            chartArea.AxisY.Title = "Cantidad de Reservas";

            chart.Titles.Add(new Title(title));

            return chart;
        }

        private void InitializeRadioButtons()
        {

            radbutTotalReservas.CheckedChanged += (s, e) => CargarDatos();

        }

        private void formPresentacionReservas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<DataPoint> puntosReservas = new List<DataPoint>();
            ABMreservas abmRes = new ABMreservas();
            List<Reserva> reservas = abmRes.consultarReservas();

            var reservasAgrupadas = reservas
                .GroupBy(r => radbutTotalReservas.Checked ? (object)r.Turno.Month : r.Instalacion.Actividad.getDescripcion())
                .OrderBy(g => g.Key);

            chartReservasMes.Series["Reservas"].Points.Clear();
            chartReservasActividad.Series["Reservas"].Points.Clear();

            foreach (var grupo in reservasAgrupadas)
            {
                string etiqueta = radbutTotalReservas.Checked ?
                    MesAMesString(Convert.ToInt32(grupo.Key)) :
                    grupo.Key.ToString();

                int cantidadReservas = grupo.Count();

                if (radbutTotalReservas.Checked)
                {
                    chartReservasMes.Series["Reservas"].Points.AddXY(etiqueta, cantidadReservas);
                }
                else
                {
                    chartReservasActividad.Series["Reservas"].Points.AddXY(etiqueta, cantidadReservas);
                }
            }
        }



        private string MesAMesString(int mes)
        {
            switch (mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
                default: return "";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler((s, ev) => ImprimirGrafico(s, ev));
                printDocument.Print();
            }
        }

        private void ImprimirGrafico(object sender, PrintPageEventArgs e)
        {
            Chart chartAImprimir = radbutTotalReservas.Checked ? chartReservasMes : chartReservasActividad;

            Bitmap bmp = new Bitmap(chartAImprimir.Width, chartAImprimir.Height);
            chartAImprimir.DrawToBitmap(bmp, new Rectangle(0, 0, chartAImprimir.Width, chartAImprimir.Height));

            e.Graphics.DrawImage(bmp, e.MarginBounds);

            string tipoImpresion = radbutTotalReservas.Checked ? "Total de Reservas por Mes" : "Total de Reservas por Actividad";
            Font font = new Font("Arial", 12);
            e.Graphics.DrawString(tipoImpresion, font, Brushes.Black, new PointF(e.MarginBounds.Left, e.MarginBounds.Top - 40));
        }

        private void radbutTotalReservas_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void radbutPorActividad_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosActivdad();
        }

        private void CargarDatosActivdad()
        {
            List<DataPoint> puntosReservas = new List<DataPoint>();
            ABMreservas abmRes = new ABMreservas();
            List<Reserva> reservas = abmRes.consultarReservas();

            var reservasAgrupadas = reservas
                .GroupBy(r => radbutTotalReservas.Checked ? (object)r.Turno.Month : r.Instalacion.Actividad.getDescripcion())
                .OrderBy(g => g.Key);

            chartReservasActividad.Series["Reservas"].Points.Clear();

            foreach (var grupo in reservasAgrupadas)
            {
                string etiqueta = radbutTotalReservas.Checked ?
                    MesAMesString(Convert.ToInt32(grupo.Key)) :
                    grupo.Key.ToString();

                int cantidadReservas = radbutTotalReservas.Checked ?
                    grupo.Count() :
                    grupo.Count();

                chartReservasActividad.Series["Reservas"].Points.AddXY(etiqueta, cantidadReservas);
            }

            chartReservasActividad.Refresh();
        }
    }






}
