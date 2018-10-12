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

namespace Vista
{
    public partial class Registrar : Form
    {
        estudiante objEstudiante = new estudiante();

        public Registrar()
        {
            InitializeComponent();
        }

        private void BTNregistrar_Click(object sender, EventArgs e)
        {
            if (textnombre.Text == "")
            {
                textnombre.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (textapellido.Text == "")
            {
                textapellido.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (textdocumento.Text == "")
            {
                textdocumento.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else if (textnacimiento.Text == "")
            {
                textnacimiento.Focus();
                MessageBox.Show("Este campo esta vacio");
            }
            else
            {

                objEstudiante.setNombre(textnombre.Text);
                objEstudiante.setApellido(textapellido.Text);
                objEstudiante.setDocumento(textdocumento.Text);
                objEstudiante.setFecha_Nacimiento(textnacimiento.Text);

                //todos los set
                objEstudiante.registrarestudiante();
                MessageBox.Show("Usuario registrar");





            }
        }

        private void BTNmenu_Click(object sender, EventArgs e)
        {
            Menu objMenu = new Menu();
            objMenu.Show();
            this.Hide();
        }
    }
}
