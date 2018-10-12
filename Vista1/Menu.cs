using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            consultar objconsultar = new consultar();
            objconsultar.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar objRegistrar = new Registrar();
            objRegistrar.Show();
            this.Hide();
       
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
