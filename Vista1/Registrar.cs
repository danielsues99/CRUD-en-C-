using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista1
{
    public partial class Registrar : Form
    {
        Estudiante objEstudiante = new Estudiante();
        public Registrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtApellido.Text == "")
            {
                txtApellido.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtDocumento.Text == "")
            {
                txtDocumento.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (txtFechaNacimiento.Text == "")
            {
                txtFechaNacimiento.Focus();
                MessageBox.Show("Este campo esta vacio");
            }

            objEstudiante.setNombre(txtNombre.Text);
            objEstudiante.setApellido(txtApellido.Text);
            objEstudiante.setDocumento(txtDocumento.Text);
            objEstudiante.setFechaNacimiento(txtFechaNacimiento.Text);

            objEstudiante.registrarestudiante();
            MessageBox.Show("Usuario Registrado");
             
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            objMenu.Show();
            this.Hide();

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
