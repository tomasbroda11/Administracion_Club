using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class formEntrenamientos : Form
    {
        Profesor profesor;
        public formEntrenamientos(Profesor p)
        {
            InitializeComponent();
            this.profesor = p;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuProfe formMenuProf = new formMenuProfe(this.profesor);
            formMenuProf.Show();
            this.Close();
        }

        private void formEntrenamientos_Load(object sender, EventArgs e)
        {
            ABMEntrenamiento abmE = new ABMEntrenamiento();

            List<Entrenamiento> entrenamientosList = abmE.ConsultarEntrenamientosProfesor(this.profesor.getDni().ToString());

            foreach (Entrenamiento ent in entrenamientosList)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = ent.IdEntrenamiento;
                dataGridView1.Rows[rowIndex].Cells["Dia"].Value = CultureInfo.CurrentCulture.DateTimeFormat.GetDayName((DayOfWeek)ent.Dia);
                dataGridView1.Rows[rowIndex].Cells["HoraDesde"].Value = ent.HoraDesde;
                dataGridView1.Rows[rowIndex].Cells["HoraHasta"].Value = ent.HoraHasta;
                dataGridView1.Rows[rowIndex].Cells["Actividad"].Value = ent.Instalacion.Actividad.getDescripcion();
                dataGridView1.Rows[rowIndex].Cells["Instalacion"].Value = ent.Instalacion.getDescripcion();

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAgregarEntrenamiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAddEntrenamiento formAddP = new formAddEntrenamiento(this.profesor);
            formAddP.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el entrenamiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ABMEntrenamiento abme = new ABMEntrenamiento();
                Entrenamiento ent = abme.obtenerEntrenamientoXId(int.Parse(txtId.Text));
                if (ent != null)
                {
                    abme.eliminarEntrenamiento(int.Parse(txtId.Text));
                    MessageBox.Show("Entrenamiento eliminado con exito!");
                    this.Hide();
                    formEntrenamientos fe = new formEntrenamientos(this.profesor);
                    fe.Show();
                    this.Close();
                }
                else MessageBox.Show("No existe el ID ingresado.");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ABMEntrenamiento abme = new ABMEntrenamiento();
            Entrenamiento ent = abme.obtenerEntrenamientoXId(int.Parse(txtId.Text));
            if (ent != null)
            {
                this.Hide();
                formEditEntrenamiento formEditE = new formEditEntrenamiento(ent);
                formEditE.Show();
                this.Close();
            }
            else MessageBox.Show("No existe el ID ingresado.");
        }
    }
}
