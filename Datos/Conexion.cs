﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
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
        MySqlConnection conexionConnection;
        public Conexion()
        { 
            conexionConnection = new MySqlConnection(conexion);
           
        }

        
        public DataTable Buscar(int idlibros)
        {
            DataTable tabla = new DataTable();

                try
                {
                    string consulta = "SELECT * FROM libros WHERE idLibros=@idLibros";
                    MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
                    command.Parameters.AddWithValue("@idLibros", idlibros);
                    MySqlDataAdapter tablasql = new MySqlDataAdapter(command);
                    conexionConnection.Open();
                    tablasql.Fill(tabla);
                }
                catch (Exception excp) { MessageBox.Show("Fallo al Momento de Mostrar los Datos, Error: " + excp.Message); }
                finally { conexionConnection.Close(); }
            
            return tabla;
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
                MessageBox.Show("Registro Creado Exitosamente");
            }
            catch (Exception excp) { MessageBox.Show("Fallo al Momento de Ingresar los Datos, Error: "+excp.Message); }
                
            finally { conexionConnection.Close(); }
        }

        public void Actualizar(Libro libro)
        {
            try
            { 
            string consulta = "UPDATE libros SET Nombre = @Nombre, Genero =  @Genero, Empastado = @Empastado, Disponible = @Disponible, Publicacion = @Publicacion, Edicion =  @Edicion, Autor =  @Autor WHERE idLibros = @idLibros ";
            MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
            command.Parameters.AddWithValue("@Nombre", libro.nombre);
            command.Parameters.AddWithValue("@Genero", libro.genero);
            command.Parameters.AddWithValue("@Empastado", libro.empastado);
            command.Parameters.AddWithValue("@Disponible", libro.disponible);
            command.Parameters.AddWithValue("@Publicacion", libro.publicacion);
            command.Parameters.AddWithValue("@Edicion", libro.edicion);
            command.Parameters.AddWithValue("@Autor", libro.autor);
            command.Parameters.AddWithValue("@idLibros", libro.id);

            conexionConnection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Registro Actualizado Exitosamente");
            }
            catch (Exception excp) { MessageBox.Show("Fallo al Momento de Actualizar los Datos, Error: " + excp.Message); }

            finally { conexionConnection.Close(); }
        
    }

        public List<Libro> buscarTodo()
        {
            List<Libro> lista = new List<Libro> ();
            
            using (MySqlConnection conect = new MySqlConnection(conexion))
            {
                string consulta = "SELECT * FROM libros";

                try
                {   MySqlCommand command = new MySqlCommand(consulta, conect);
                    conect.Open();
                    MySqlDataReader lector = command.ExecuteReader();
                    while (lector.Read())
                    {
                        Libro libro = new Libro
                            (
                                ID: lector.GetInt32("idLibros"), 
                                Nombre: lector.GetString("Nombre"),
                                Genero: lector.GetString("Genero"), 
                                Empastado:lector.GetString("Empastado"),
                                Disponible: lector.GetBoolean("Disponible"), 
                                Publicacion: lector.GetDateTime("Publicacion"),
                                Edicion: lector.GetDecimal("Edicion"), Autor: 
                                lector.GetString("Autor")
                            ) ;
                        lista.Add(libro);
                    }
                    lector.Close();
                }
                catch (Exception excp) { MessageBox.Show("Fallo al Momento de Leer los Datos, Error: " + excp.Message); }

                finally { conect.Close(); }
            }
            return lista;
        }
        public void Borrar(int idLibros)
        {
            try
            {
                string consulta = "DELETE FROM libros Where idLibros = @idLibros";
                MySqlCommand command = new MySqlCommand(consulta, conexionConnection);
                command.Parameters.AddWithValue("@idLibros", idLibros);

                conexionConnection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados Exitosamente");
            }
            catch (Exception excp) { MessageBox.Show("Fallo al Momento de Borrar los Datos, Error: " + excp.Message); }

            finally { conexionConnection.Close(); }
        }

    }
}
