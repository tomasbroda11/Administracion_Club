using Entidades;
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
    public partial class formMenuProfe : Form
    {
        Profesor profe;
        public formMenuProfe(Profesor p)
        {
            InitializeComponent();
            this.profe = p;
        }

        private void btn_menu_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();
            this.Close();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            formActualizarSocio formActualizar = new formActualizarSocio(this.profe);
            formActualizar.ShowDialog();
        }

        private void btnEntrenamientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            formEntrenamientos formEnt = new formEntrenamientos(this.profe);
            formEnt.ShowDialog();
        }
    }
}
