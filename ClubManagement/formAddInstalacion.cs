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
    public partial class formAddInstalacion : Form
    {
        public formAddInstalacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInstalaciones formInstalaciones = new formInstalaciones();
            formInstalaciones.ShowDialog();
            this.Close();
        }

        private void formAddInstalacion_Load(object sender, EventArgs e)
        {
            ABMActividades abmActividades = new ABMActividades();
            List<Actividad> listadoActividades = abmActividades.obtenerTodasActividades();

            List<string> descripcionesActividades = listadoActividades.Select(actividad => actividad.getDescripcion()).ToList();
            cbActividades.Items.AddRange(descripcionesActividades.ToArray());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length == 0 || txtDescripcion.Text.Length == 0 || cbActivo.SelectedIndex == -1 || cbActividades.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                ABMInstalaciones abmInstalaciones = new ABMInstalaciones();
                Instalacion instalacionEncontrada = abmInstalaciones.obtenerInstalacionPorId(int.Parse(txtID.Text));

                if(instalacionEncontrada != null)
                {
                    MessageBox.Show("El ID ingresado ya se encuentra en uso, elija otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ABMActividades abmActividades = new ABMActividades();
                    Actividad actividadSeleccionada = abmActividades.obtenerActividadPorDesc(cbActividades.SelectedItem.ToString());
                    Instalacion nuevaInstalacion = new Instalacion
                        (
                            int.Parse(txtID.Text),
                            txtDescripcion.Text,
                            int.Parse(cbActivo.SelectedIndex.ToString()),
                            actividadSeleccionada
                        );
                    abmInstalaciones.add(nuevaInstalacion);

                    MessageBox.Show("La instalacion se agregó con exito!");
                    this.Hide();
                    formInstalaciones formInstalaciones = new formInstalaciones();
                    formInstalaciones.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
