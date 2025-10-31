using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGalizziAgenda
{
    internal class clsConeccionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../db/dbAgenda.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);


                nombreBaseDeDatos = Path.GetFileName(coneccionBaseDatos.DataSource);
                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }
        public void cargarDgv(DataGridView dgvActividades)
        {
            try
            {
                dgvActividades.Rows.Clear();
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                
                comandoBaseDatos.CommandText = $"SELECT * FROM Actividades";
                lectorDataReader = comandoBaseDatos.ExecuteReader();
                while (lectorDataReader.Read())
                {
                    dgvActividades.Rows.Add(lectorDataReader[1], lectorDataReader[2], lectorDataReader[3]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la categoría o el valor ingresado.");
            }
        }
        public void agregarActividad(string actividad, string fecha, string observacion)
        {
            try
            {

                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = "SELECT MAX(IdActividad) FROM Actividades;";
                object resultado = comandoBaseDatos.ExecuteScalar();
                int ultimoId = 0;
                if (resultado != null)
                {
                    ultimoId = Convert.ToInt32(resultado);
                }
                int nuevoId = ultimoId++;

                comandoBaseDatos.CommandText = $"INSERT INTO Actividades (Asunto, Fecha, Observación) " +
                               $"VALUES ('{actividad}', #{fecha}#, '{observacion}')";
                comandoBaseDatos.ExecuteNonQuery();
                MessageBox.Show("Actividad agregada con éxito.");
                coneccionBaseDatos.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo agregar la actividad.");
            }
        }
        public void eliminarActividad(string asunto)
        {
            try
            {
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);
                coneccionBaseDatos.Open();
                comandoBaseDatos = new OleDbCommand();
                comandoBaseDatos.Connection = coneccionBaseDatos;
                comandoBaseDatos.CommandText = $"DELETE FROM Actividades WHERE Asunto = '{asunto}'";
                comandoBaseDatos.ExecuteNonQuery();
                MessageBox.Show("Actividad eliminada.");
                coneccionBaseDatos.Close();
            }
            catch
            {
                MessageBox.Show("Error al eliminar actividad.");
            }
        }
    }
}
