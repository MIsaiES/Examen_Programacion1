using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Programacion1.Datos
{
    internal class Libro
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string genero { get; set; }
        public string empastado { get; set; }
        public bool disponible { get; set; }
        public DateTime publicacion {  get; set; }
        public decimal edicion { get; set; }
        public string autor {  get; set; }

        public Libro(int ID, string Nombre, string Genero, string Empastado, bool Disponible, DateTime Publicacion, decimal Edicion, string Autor)
        {
            id = ID;
            nombre = Nombre;
            genero = Genero;
            empastado = Empastado;
            disponible = Disponible;
            publicacion = Publicacion;
            edicion = Edicion;
            autor = Autor;
        }
        public Libro() { }
    }
}
