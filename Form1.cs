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
        List<Libro> Todo;
        Contador contador = new Contador();
        string[] emp = {"Papel", "Carton (Pasta Dura)", "Tela" , "Cuero", "Otro" };

        
        public Form1()
        {
            InitializeComponent();

            Todo = conexion.buscarTodo();
            dataGridView_libros.DataSource = Todo;
            comboBox_empastado.DataSource = emp;
            contador.actual = 0;
            contador.TotalDatos = Todo.Count;
        }
        
        private void button_crear_Click(object sender, EventArgs e)
        {
            libro.nombre = textBox_nombre.Text;
            libro.empastado = comboBox_empastado.Text;
            libro.genero = textBox_genero.Text;
            libro.disponible = checkBox_disponible.Checked;
            libro.publicacion = dateTimePicker_publicacion.Value;
            libro.edicion = numericUpDown_edicion.Value;
            libro.autor = textBox_autor.Text;

            conexion.Crear(libro);
            Todo = conexion.buscarTodo();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            int indx;
            int.TryParse(textBox_id.Text, out indx);
            if (indx == 0)
            {
                indx = 1;
            }
            BuscarId(indx);
            
        }

        private void button_buscarTodo_Click(object sender, EventArgs e)
        {
            dataGridView_libros.DataSource = conexion.buscarTodo();
            contador.actual=0;
        }
        public void BuscarId(int idLibros)
        {
            
            //contador.TotalDatos = conexion.buscarTodo().Count;
            contador.actual = idLibros;
            if (contador.actual > contador.TotalDatos)
            {
                contador.actual = 1;
            }
            else if (contador.actual <= 0)
            {
                contador.actual=contador.TotalDatos-1;
            }
            DataRow lib = conexion.Buscar(contador.actual);
            textBox_id.Text = lib["idLibros"].ToString();
            textBox_nombre.Text = lib["Nombre"].ToString();
            textBox_genero.Text = lib["Genero"].ToString();
            comboBox_empastado.Text = lib["Empastado"].ToString();
            checkBox_disponible.Checked = (bool)lib["Disponible"];
            dateTimePicker_publicacion.Value = (DateTime)lib["Publicacion"];
            numericUpDown_edicion.Value = (int)lib["Edicion"];
            textBox_autor.Text = lib["Autor"].ToString();

        }

        private void button_anterior_Click(object sender, EventArgs e)
        {
            
            contador.actual--;
            BuscarId(contador.actual);
        }
        
    }
}
