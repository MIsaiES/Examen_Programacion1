using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Programacion1.Datos
{
    internal class Conexion
    {
        string conexion = "server=localhost;database=examenprogra1;user=root;password=mdi9382";
        private MySqlConnection conexionConnection;
        public Conexion()
        {
            conexionConnection = new MySqlConnection(conexion);
        }

        public DataTable Buscar(int idlibros)
        {
            DataTable tabla = new DataTable();

            if (idlibros == 0)
            {
                try
                {
                    string consulta = "SELECT * FROM libros";
                    MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
                    MySqlDataAdapter tablasql = new MySqlDataAdapter(command);
                    conexionConnection.Open();
                    tablasql.Fill(tabla);
                }
                catch (Exception excp) { MessageBox.Show("Falló al Momento de Mostrar los Datos, Error: " + excp.Message); }
                finally { conexionConnection.Close(); }
            }
            else
            {
                try
                {
                    string consulta = "SELECT * FROM libros WHERE idlibros=@idlibros";
                    MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
                    command.Parameters.AddWithValue("@idlibros", idlibros);
                    MySqlDataAdapter tablasql = new MySqlDataAdapter(command);
                    conexionConnection.Open();
                    tablasql.Fill(tabla);
                }
                catch (Exception excp) { MessageBox.Show("Falló al Momento de Mostrar los Datos, Error: " + excp.Message); }
                finally { conexionConnection.Close(); }
            }
            return tabla;//Aqui me Quedo hoy
        }

        public void Crear(Libro libro) 
        {
            try
            {
                string consulta = "INSERT INTO libros (Nombre, Genero, Empastado, Disponible, Publicacion, Edicion, Autor) VALUES (@Nombre, @Genero, @Empastado, @Disponible, @Publicacion, @Edicion, @Autor)";
                MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
                command.Parameters.AddWithValue("@Nombre", libro.nombre);
                command.Parameters.AddWithValue("@Genero", libro.genero);
                command.Parameters.AddWithValue("@Empastado", libro.empastado);
                command.Parameters.AddWithValue("@Disponible", libro.disponible);
                command.Parameters.AddWithValue("@Publicacion", libro.publicacion);
                command.Parameters.AddWithValue("@Edicion", libro.edicion);
                command.Parameters.AddWithValue("@Autor", libro.autor);

                conexionConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception excp) { MessageBox.Show("Falló al Momento de Ingresar los Datos, Error: "+excp.Message); }
                
            finally { conexionConnection.Close(); }
        }

        public void Actualizar(Libro libro)
        {
            string consulta = "UPDATE libros SET Nombre = @Nombre, Genero =  @Genero, Empastado = @Empastado, Disponible = @Disponible, Publicacion = @Publicacion, Edicion =  @Edicion, Autor =  @Autor) ";
        }
    }
}
