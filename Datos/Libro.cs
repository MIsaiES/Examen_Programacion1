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

    }
}
