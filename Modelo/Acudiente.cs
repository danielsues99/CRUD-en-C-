using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Controlador;
namespace Modelo
{
    public class Acudiente
    {
        private string PrimerNombre;
        private string SegundoNombre;
        private string apellidos;
        private string edad;
        private string documento;
        private string Idacudiente;
        Controlador.Conexion objConexion = new Controlador.Conexion();
        public void setPrimerNombre(string PrimerNombre)
        {
            this.PrimerNombre = PrimerNombre;
        }
        public string getPrimerNombre()
        {
            return PrimerNombre;
        }
        public void setSegundoNombre(string SegundoNombre)
        {
            this.SegundoNombre = SegundoNombre;
        }
        public string getSegundoNombre()
        {
            return SegundoNombre;
        }
        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public string getApellidos()
        {
            return apellidos;
        }
        public void setEdad(string edad)
        {
            this.edad = edad;
        }
        public string getedad()
        {
            return edad;
        }

        public void setdocumento(string documento)
        {
            this.documento = documento;
        }
        public string getdocumento()
        {
            return documento;
        }
        public void setIdacudiente(string Idacudiente)
        {
            this.Idacudiente = Idacudiente;
        }
        public string getIdacudiente()
        {
            return Idacudiente;
        }

        public void registraracudiente()
        {
            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                string sentencia;
                sentencia = "insert into acudiente (PrimerNombre, SegundoNombre, Edad, Documento) values (' " + PrimerNombre + "','" + SegundoNombre + "','" + edad + "','" +documento + "')";
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

        public DataTable consultarTodosAcudientes()
        {
            string sentenciaConsultarclaseacudiente = "";
            try
            {
                objConexion.desconectar();
                objConexion.conectar();
                sentenciaConsultarclaseacudiente = "select * from acudiente";
                objConexion.setSentenciaSql(sentenciaConsultarclaseacudiente);
                return objConexion.consultarDatos();
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Error al consultar los Acudientes");
                MessageBox.Show(ex.Message);
                return objConexion.consultarDatos();

            }
        }

        public void ActualizarDatosacudiente()
        {
            string sentencia;
            sentencia = "Update acudiente set PrimerNombre = '" + PrimerNombre + "'," + "SegundoNombre ='" + SegundoNombre + "',Edad = '" + edad + "',Documento = '" + documento +
                "' where id = '" + Idacudiente + "'";
            objConexion.setSentenciaSql(sentencia);
            objConexion.actualizarDatos();
        }
    }
}
