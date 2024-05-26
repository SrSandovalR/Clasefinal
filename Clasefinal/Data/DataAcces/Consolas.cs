using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clasefinal.Data.DataAcces
{
    internal class Consolas
    {
        private string connectionString = "Server=LocalHost;Database=consolas;uid=root;Pwd=1212ABCD0909aa";
        private MySqlConnection connection;



        public void Insertar(model usr)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nombre_consola", usr.nombre_consola_);
                cmd.Parameters.AddWithValue("@compania", usr.compania_);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", usr.anio_lanzamiento_);
                cmd.Parameters.AddWithValue("@generacion", usr.generacion_);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        public DataTable Leerconsolas()
        {
            DataTable consola = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(consola);
                    }
                }
            }

            return consola;
        }



        public void Actualizar(model usr)
        {
            try
            {
                string query = "UPDATE catalogo_consolas SET nombre_consola = @nombre_consola, compania = @compania, anio_lanzamiento = @anio_lanzamiento, generacion = @generacion";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre_consola", usr.nombre_consola_);
                cmd.Parameters.AddWithValue("@compania", usr.compania_);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", usr.anio_lanzamiento_);
                cmd.Parameters.AddWithValue("@generacion", usr.generacion_);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void EliminarRegistroPorId(int id_consola)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM catalogo_consolas WHERE id_consola = @id_consola";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_consola", id_consola);
                    int filaeliminada = command.ExecuteNonQuery();

                    if (filaeliminada > 0)
                    {
                        Console.WriteLine("Se eliminó el registro con ID: " + id_consola);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró un registro con ID: " + id_consola);
                    }
                }
            }




        }
    }
}
