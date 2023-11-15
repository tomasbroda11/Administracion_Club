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
    public partial class formProfesores : Form
    {
        public formProfesores()
        {
            InitializeComponent();
        }

        private void formProfesores_Load(object sender, EventArgs e)
        {
            ABMpersonas abmProfes = new ABMpersonas();
            List<Profesor> profesoresList = abmProfes.obtenerProfesores();

            foreach (Profesor profe in profesoresList)
            {

                int rowIndex = dataProfesores.Rows.Add();

                dataProfesores.Rows[rowIndex].Cells["Dni"].Value = profe.getDni();
                dataProfesores.Rows[rowIndex].Cells["Nombre"].Value = profe.getNombre();
                dataProfesores.Rows[rowIndex].Cells["Apellido"].Value = profe.getApellido();
                dataProfesores.Rows[rowIndex].Cells["Email"].Value = profe.getMail();
                dataProfesores.Rows[rowIndex].Cells["Actividad"].Value = profe.getActividad().getDescripcion();

            }
            foreach (DataGridViewColumn column in dataProfesores.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuAdmin formMenuAd = new formMenuAdmin();
            formMenuAd.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                ABMpersonas abmPersonas = new ABMpersonas();
                Persona personaExiste = abmPersonas.buscaPersonaXDni(txtDni.Text);
                if (personaExiste != null)
                {
                    abmPersonas.delete(txtDni.Text);
                    MessageBox.Show("Profesor eliminado con exito!");
                    this.Hide();
                    formProfesores formProf = new formProfesores();
                    formProf.Show();
                    this.Close();
                }
                else MessageBox.Show("No existe el dni ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAddProfesor formAddProfe = new formAddProfesor();   
            formAddProfe.Show();    
            this.Close();   
        }
    }
}
