using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class formEditEntrenamiento : Form
    {
        Entrenamiento entrenamiento;
        public formEditEntrenamiento(Entrenamiento ent)
        {
            this.entrenamiento = ent;
            InitializeComponent();
        }

        private void formEditEntrenamiento_Load(object sender, EventArgs e)
        {
            cbHoraDesde.Items.Clear();
            List<TimeOnly> todasLasHoras = ObtenerTodasLasHoras();
            foreach (var hora in todasLasHoras)
            {
                cbHoraDesde.Items.Add(hora.ToString("hh:mm tt"));
            }
            cbHoraDesde.SelectedItem = this.entrenamiento.HoraDesde.ToString("hh:mm tt");
            cbHoraHasta.Items.Add(this.entrenamiento.HoraHasta.ToString("hh:mm tt"));
            cbHoraHasta.SelectedItem = this.entrenamiento.HoraHasta.ToString("hh:mm tt");

            cbInstalacion.Items.Clear();
            List<Instalacion> instalaciones = new ABMInstalaciones().consultarInstalaciones(this.entrenamiento.Profesor.getActividad().getDescripcion());

            foreach (Instalacion i in instalaciones)
            {
                cbInstalacion.Items.Add(i.getDescripcion());
            }
            cbInstalacion.SelectedItem = this.entrenamiento.Instalacion.getDescripcion();


            List<String> dias = new List<string> { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            cbDia.SelectedItem = dias[this.entrenamiento.Dia];
        }

        private void cbHoraDesde_SelectedValueChanged(object sender, EventArgs e)
        {
            cbHoraHasta.Items.Clear();
            List<TimeOnly> todasLasHoras = ObtenerTodasLasHoras();
            foreach (var hora in todasLasHoras)
            {
                if (hora.Hour > TimeOnly.Parse(cbHoraDesde.SelectedItem.ToString()).Hour)
                {
                    cbHoraHasta.Items.Add(hora.ToString("hh:mm tt"));
                }
            }
            cbHoraHasta.Enabled = true;
            cbHoraHasta.BackColor = SystemColors.Window;
        }

        private static List<TimeOnly> ObtenerTodasLasHoras()
        {
            return new List<TimeOnly>
            {
                new TimeOnly(8, 0), new TimeOnly(9, 0), new TimeOnly(10, 0), new TimeOnly(11, 0),
                new TimeOnly(12, 0), new TimeOnly(13, 0), new TimeOnly(14, 0), new TimeOnly(15, 0),
                new TimeOnly(16, 0), new TimeOnly(17, 0), new TimeOnly(18, 0), new TimeOnly(19, 0)
            };
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<String> dias = new List<string> { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            if (cbDia.SelectedItem != null && cbHoraDesde.SelectedItem != null && cbHoraHasta.SelectedItem != null && cbInstalacion.SelectedItem != null)
            {
                ABMEntrenamiento abme = new ABMEntrenamiento();
                int dia = dias.IndexOf(cbDia.SelectedItem.ToString());
                TimeOnly horaDesde = TimeOnly.Parse(cbHoraDesde.SelectedItem.ToString());
                TimeOnly horaHasta = TimeOnly.Parse(cbHoraHasta.SelectedItem.ToString());
                Instalacion instalacion = new ABMInstalaciones().obtenerXDescripcion(cbInstalacion.SelectedItem.ToString());
                if (!abme.ExisteEntrenamientoEnFechaYHora(dia, horaDesde, horaHasta, instalacion))
                {
                    Entrenamiento ent = new Entrenamiento();
                    ent.HoraDesde = horaDesde;
                    ent.HoraHasta = horaHasta;
                    ent.Dia = dia;
                    ent.Instalacion = instalacion;
                    ent.Profesor = this.entrenamiento.Profesor;
                    abme.actualizarEntrenamiento(ent);
                }
                else
                {
                    MessageBox.Show("La instalacion no esta disponible en ese dia y hora");
                }
            }
            else
            {
                MessageBox.Show("Elija opcion de instalacion, dia, hora desde, hora hasta");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntrenamientos formEnt = Application.OpenForms["formEntrenamientos"] as formEntrenamientos;
            formEnt.Show();
            this.Close();
        }
    }
}
