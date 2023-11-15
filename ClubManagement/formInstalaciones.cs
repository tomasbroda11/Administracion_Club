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
    public partial class formInstalaciones : Form
    {
        public formInstalaciones()
        {
            InitializeComponent();
        }

        ABMInstalaciones abmInstalaciones = new ABMInstalaciones();

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuAdmin formMenuAd = new formMenuAdmin();
            formMenuAd.Show();
            this.Close();
        }

        private void formInstalacion_Load(object sender, EventArgs e)
        {
            List<Instalacion> instalaciones = abmInstalaciones.obtenerTodasInstalaciones();

            foreach (Instalacion instalacion in instalaciones)
            {
                int rowIndex = dataInstalaciones.Rows.Add();

                dataInstalaciones.Rows[rowIndex].Cells["ID"].Value = instalacion.getId();
                dataInstalaciones.Rows[rowIndex].Cells["Descripcion"].Value = instalacion.getDescripcion();
                dataInstalaciones.Rows[rowIndex].Cells["Actividad"].Value = instalacion.Actividad.getDescripcion();
                dataInstalaciones.Rows[rowIndex].Cells["Activo"].Value = instalacion.getActivo();
            }
            foreach (DataGridViewColumn column in dataInstalaciones.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            foreach (DataGridViewRow row in dataInstalaciones.Rows)
            {
                if (row.Cells["Activo"].Value != null && (int)row.Cells["Activo"].Value == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ABMInstalaciones abmInstalaciones = new ABMInstalaciones();
                Instalacion instalacion = abmInstalaciones.obtenerInstalacionPorId(int.Parse(txtIdInstalacion.Text));

                if (instalacion != null)
                {
                    abmInstalaciones.bajaLogica(instalacion.getId());
                    MessageBox.Show("La instalacion se dio de baja con exito!");
                    this.Hide();
                    formInstalaciones formInstalaciones = new formInstalaciones();
                    formInstalaciones.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La instalacion no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ABMInstalaciones abmInstalaciones = new ABMInstalaciones();
            Instalacion instalacion = abmInstalaciones.obtenerInstalacionPorId(int.Parse(txtIdInstalacion.Text));

            if (instalacion != null)
            {
                this.Hide();
                formActualizarInstalacion formActualizarInstalacion = new formActualizarInstalacion(instalacion);
                formActualizarInstalacion.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("La instalacion no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAddInstalacion formAddInstalacion = new formAddInstalacion();
            formAddInstalacion.ShowDialog();
            this.Close();
        }
    }
}
