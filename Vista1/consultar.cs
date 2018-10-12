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
    public partial class consultar : Form
    {
        DataTable tablaestudiante = new DataTable();
        Estudiante objEstudiante = new Estudiante();
        public consultar()
        {
            InitializeComponent();
            tablaestudiante = objEstudiante.consultarTodosEstudiantes();
            dataGridView1.DataSource = tablaestudiante;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consultar_Load(object sender, EventArgs e)
        {

        }

        private void Editar_Click(object sender, EventArgs e)
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

            txtNombre.Text = tabla.Rows[index]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[index]["Apellido"].ToString();
            txtDocumento.Text = tabla.Rows[index]["Documento"].ToString();
            txtFechaNacimiento.Text = tabla.Rows[index]["FechaNacimiento"].ToString();
            labelId.Text = tabla.Rows[index]["Id"].ToString();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
            else
            {
                objEstudiante.setNombre(txtNombre.Text);
                objEstudiante.setApellido(txtApellido.Text);
                objEstudiante.setDocumento(txtDocumento.Text);
                objEstudiante.setFechaNacimiento(txtFechaNacimiento.Text);
                objEstudiante.setIdEstudiante(labelId.Text);

                objEstudiante.ActualizarDatosEstudiante();
                tablaestudiante = objEstudiante.consultarTodosEstudiantes();
                dataGridView1.DataSource = tablaestudiante;

            }
        }
    }
}
