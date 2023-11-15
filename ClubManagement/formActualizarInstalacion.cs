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
    public partial class formActualizarInstalacion : Form
    {
        Instalacion instalacion;
        public formActualizarInstalacion(Instalacion instalacion)
        {
            this.instalacion = instalacion;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstalaciones formInstalaciones = new formInstalaciones();
            formInstalaciones.ShowDialog();
            this.Close();
        }

        private void formActualizarInstalacion_Load(object sender, EventArgs e)
        {
            ABMActividades abmActividades = new ABMActividades();
            List<Actividad> actividades = abmActividades.obtenerTodasActividades();

            txtID.Text = instalacion.getId().ToString();
            txtDescripcion.Text = instalacion.getDescripcion();

            cbActivo.SelectedItem = instalacion.getActivo().ToString();
            List<string> descripcionesActividades = actividades.Select(actividad => actividad.getDescripcion()).ToList();
            cbActividades.Items.AddRange(descripcionesActividades.ToArray());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text.Length == 0 || cbActividades.SelectedItem.ToString().Length == 0)
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error   );
            }
            else
            {
                ABMActividades abmActividades = new ABMActividades();
                Actividad actividadSeleccionada = abmActividades.obtenerActividadPorDesc(cbActividades.SelectedItem.ToString());

                System.Diagnostics.Debug.WriteLine(actividadSeleccionada.getId());

                ABMInstalaciones abmInstalaciones = new ABMInstalaciones();
                Instalacion instalacionActualizada = new Instalacion
                    (
                       instalacion.getId(),
                       txtDescripcion.Text,
                       int.Parse(cbActivo.SelectedItem.ToString()),
                       actividadSeleccionada
                    );
                abmInstalaciones.update(instalacionActualizada);

                MessageBox.Show("La instalacion se actualizo con exito!");
                this.Hide();
                formInstalaciones formInstalaciones = new formInstalaciones();
                formInstalaciones.ShowDialog();
                this.Close();
            }
        }
    }
}
