using Examen_Programacion1.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Programacion1
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();
        Libro libro = new Libro();
        public Form1()
        {
            InitializeComponent();
        }
        //Combobox values
        private void button_crear_Click(object sender, EventArgs e)
        {
            libro.nombre = textBox_nombre.Text;
            libro.empastado = comboBox_empastado.Text;
            libro.genero = textBox_genero.Text;
            libro.disponible = checkBox_disponible.Checked;
            libro.publicacion = dateTimePicker_publicacion.Value;
            libro.edicion = numericUpDown_edicion.Value;
            

        }
        
    }
}
