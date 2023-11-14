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
    public partial class formAddProfesor : Form
    {
        public formAddProfesor()
        {
            InitializeComponent();
        }
        private void txtDNI_Leave(object sender, EventArgs e)
        {
            if (this.txtDNI.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (this.txtNombre.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (this.txtApellido.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (this.txtMail.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtRepitePass_Leave(object sender, EventArgs e)
        {
            if (this.txtRepitePass.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }
            validar();
        }

        private void txtRepitePass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPass.Text.Length > 0)
            {
                if (this.txtRepitePass.Text != this.txtPass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Las contraseñas no coinciden!";
                }
                else
                {
                    this.lblValidar.Visible = false;
                }
                validar();
            }

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (this.txtRepitePass.Text.Length > 0)
            {
                if (this.txtRepitePass.Text != this.txtPass.Text)
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Las contraseñas no coinciden!";
                }
                else
                {
                    this.lblValidar.Visible = false;
                }
            }
            validar();

        }

        private void cbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cbActividad.SelectedItem == null)
            {

                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos!";
            }
            else
            {
                this.lblValidar.Visible = false;
            }

            validar();
        }
        private void validar()
        {
            if (!(this.txtDNI.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 || this.cbActividad.SelectedValue != null ||
                this.txtMail.Text.Length == 0 || this.txtPass.Text.Length == 0 || this.txtRepitePass.Text.Length == 0) && this.txtPass.Text == this.txtRepitePass.Text)
            {
                this.btnAceptar.Enabled = true;
            }
            else
            {
                this.btnAceptar.Enabled = false;
            }
        }
        private void formAddProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ABMActividades abmAct = new ABMActividades();
            Actividad act = abmAct.obtenerActividadPorDesc(cbActividad.SelectedItem.ToString());
            ABMpersonas profe = new ABMpersonas();
            Profesor p = new Profesor(int.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, txtMail.Text, txtPass.Text, "profesor", act);
            int v = profe.addProfesor(p);
            if (v == 1)
            {
                MessageBox.Show("Alta profesor exitosa!");
                this.Hide();
                formProfesores formProfe = new formProfesores();
                formProfe.Show();
                this.Close();
            }
            else if (v == 2)
            {
                lblValidar.Visible = true;
                lblValidar.Text = "Este DNI ya está registrado.";
                lblValidar.ForeColor = Color.Red;
            }
            else
            {
                lblValidar.Visible = true;
                lblValidar.Text = "Ocurrio un error en el registro. Vuelva a intentar.";
                lblValidar.ForeColor = Color.Red;
            }
        }
    }
}
