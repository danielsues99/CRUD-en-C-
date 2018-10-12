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
    public partial class Consultart : Form
    {

        DataTable tablaestudiante = new DataTable();
        estudiante objEstudiante = new estudiante();
        public Consultart()
        {
            InitializeComponent();
            tablaestudiante = objEstudiante.consultarTodosEstudiantes();
            dataGridView1.DataSource = tablaestudiante;

            
        }

        private void Consultart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point punto = dataGridView1.CurrentCellAddress;
            int n_fila = punto.Y;
            int n_columna = punto.X;
            modificarDatos(tablaestudiante, n_fila);

        }

        private void modificarDatos(DataTable tabla, int varIndex)
        {
            int index;
            index = varIndex;

            Nombre.Text = tabla.Rows[index]["nombre"].ToString();
            Apellido.Text = tabla.Rows[index]["apellido"].ToString();
            Documento.Text = tabla.Rows[index]["documento"].ToString();
            Fecha_nacimiento.Text = tabla.Rows[index]["fecha_nacimiento"].ToString();
            labelId.Text = tabla.Rows[index]["id"].ToString();



           

           

           
         

        }


        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Nombre.Text == "")
            {
                Nombre.Focus();
                MessageBox.Show("este campo esta vacio");
            }
            else if(Apellido.Text == "")

            {

                Apellido.Focus();
                MessageBox.Show("este campo esta vacio");
            }
            else if(Documento.Text == "")
            {

                Documento.Focus();
                MessageBox.Show("este campo esta vacio");

            }
            else if (Fecha_nacimiento.Text == "")
            {

                Fecha_nacimiento.Focus();
                MessageBox.Show("este campo esta vacio");



            }

            else
            {

               


            }









        }
    }
}
