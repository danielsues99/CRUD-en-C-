using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;
using System.Data;


namespace Modelo
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string documento;
        private string fechaNacimiento;
        private string Id;

        Controlador.Conexion objConexion = new Controlador.Conexion();

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public string getApellido()
        {
            return apellido;
        }
     

        public void setDocumento(string documento)
        {
            this.documento = documento;
        }
        public string getDocumento()
        {
            return documento;
        }

        public void setFechaNacimiento(string fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public string getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void setIdEstudiante(string Id)
        {
            this.Id = Id;
        }
        public string getIdEstudiante()
        {
            return Id;
        }


        public void registrarestudiante()
        {
            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                string sentencia;
                sentencia = "insert into estudiante (Nombre, Apellido, Documento, FechaNacimiento) values (' " + nombre + "','" + apellido + "','" +documento+"','" + fechaNacimiento + "')";
                objConexion.setSentenciaSql(sentencia);
                objConexion.insertarDatos();
                objConexion.desconectar();
            }
            catch (Exception e)
            {
                objConexion.desconectar();
                throw (e);
            }
        }

        public DataTable consultarTodosEstudiantes()
        {
            string sentenciaConsultarclaseestudiante = "";
            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                sentenciaConsultarclaseestudiante = "select * from estudiante";
                objConexion.setSentenciaSql(sentenciaConsultarclaseestudiante);
                return objConexion.consultarDatos();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Error al consultar los estudiantes");
                MessageBox.Show(ex.Message);
                return objConexion.consultarDatos();

            }
        }
        public void ActualizarDatosEstudiante()
        {
            string sentencia;
            sentencia = "Update estudiante set nombre = '" + nombre + "'," + "apellido ='" + apellido + "',documento = '" + documento + "',FechaNacimiento = '" + fechaNacimiento +
                "' where id = '" + Id + "'";
            objConexion.setSentenciaSql(sentencia);
            objConexion.actualizarDatos();
        }


    }
}
