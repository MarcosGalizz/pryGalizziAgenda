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
            coneccionBaseDatos = new OleDbConnection(cadenaConexion);
            coneccionBaseDatos.Open();
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandText = "SELECT MAX(IdActividad) FROM Actividades;";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            int ultimoId = Convert.ToInt32(lectorDataReader[0]);
            comandoBaseDatos.CommandText = $"INSERT INTO Actividades (IdActividad, Asunto, Fecha, Observacion" +
        $"VALUES ({ultimoId++}, '{actividad}', {fecha}, {observacion})";
            lectorDataReader = comandoBaseDatos.ExecuteReader();
            MessageBox.Show("Producto agregado con éxito.");
        }
    }
}
