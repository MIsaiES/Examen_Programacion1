namespace Examen_Programacion1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_genero = new System.Windows.Forms.Label();
            this.label_Empastado = new System.Windows.Forms.Label();
            this.label_publicacion = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_genero = new System.Windows.Forms.TextBox();
            this.comboBox_empastado = new System.Windows.Forms.ComboBox();
            this.checkBox_disponible = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_publicacion = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_libros = new System.Windows.Forms.DataGridView();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_crear = new System.Windows.Forms.Button();
            this.button_borrar = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscarTodo = new System.Windows.Forms.Button();
            this.numericUpDown_edicion = new System.Windows.Forms.NumericUpDown();
            this.label_edicion = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.textBox_autor = new System.Windows.Forms.TextBox();
            this.button_siguiente = new System.Windows.Forms.Button();
            this.button_anterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_libros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edicion)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(40, 12);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre";
            // 
            // label_genero
            // 
            this.label_genero.AutoSize = true;
            this.label_genero.Location = new System.Drawing.Point(40, 38);
            this.label_genero.Name = "label_genero";
            this.label_genero.Size = new System.Drawing.Size(42, 13);
            this.label_genero.TabIndex = 1;
            this.label_genero.Text = "Genero";
            // 
            // label_Empastado
            // 
            this.label_Empastado.AutoSize = true;
            this.label_Empastado.Location = new System.Drawing.Point(40, 70);
            this.label_Empastado.Name = "label_Empastado";
            this.label_Empastado.Size = new System.Drawing.Size(60, 13);
            this.label_Empastado.TabIndex = 2;
            this.label_Empastado.Text = "Empastado";
            // 
            // label_publicacion
            // 
            this.label_publicacion.AutoSize = true;
            this.label_publicacion.Location = new System.Drawing.Point(38, 120);
            this.label_publicacion.Name = "label_publicacion";
            this.label_publicacion.Size = new System.Drawing.Size(62, 13);
            this.label_publicacion.TabIndex = 4;
            this.label_publicacion.Text = "Publicación";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(91, 12);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 5;
            // 
            // textBox_genero
            // 
            this.textBox_genero.Location = new System.Drawing.Point(91, 38);
            this.textBox_genero.Name = "textBox_genero";
            this.textBox_genero.Size = new System.Drawing.Size(100, 20);
            this.textBox_genero.TabIndex = 6;
            // 
            // comboBox_empastado
            // 
            this.comboBox_empastado.FormattingEnabled = true;
            this.comboBox_empastado.Location = new System.Drawing.Point(107, 70);
            this.comboBox_empastado.Name = "comboBox_empastado";
            this.comboBox_empastado.Size = new System.Drawing.Size(121, 21);
            this.comboBox_empastado.TabIndex = 7;
            // 
            // checkBox_disponible
            // 
            this.checkBox_disponible.AutoSize = true;
            this.checkBox_disponible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_disponible.Location = new System.Drawing.Point(41, 97);
            this.checkBox_disponible.Name = "checkBox_disponible";
            this.checkBox_disponible.Size = new System.Drawing.Size(75, 17);
            this.checkBox_disponible.TabIndex = 8;
            this.checkBox_disponible.Text = "Disponible";
            this.checkBox_disponible.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_publicacion
            // 
            this.dateTimePicker_publicacion.Location = new System.Drawing.Point(106, 120);
            this.dateTimePicker_publicacion.Name = "dateTimePicker_publicacion";
            this.dateTimePicker_publicacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_publicacion.TabIndex = 9;
            // 
            // dataGridView_libros
            // 
            this.dataGridView_libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_libros.Location = new System.Drawing.Point(43, 259);
            this.dataGridView_libros.Name = "dataGridView_libros";
            this.dataGridView_libros.RowHeadersWidth = 45;
            this.dataGridView_libros.Size = new System.Drawing.Size(711, 169);
            this.dataGridView_libros.TabIndex = 10;
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(152, 75);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(124, 23);
            this.button_actualizar.TabIndex = 11;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = true;
            // 
            // button_crear
            // 
            this.button_crear.Location = new System.Drawing.Point(106, 214);
            this.button_crear.Name = "button_crear";
            this.button_crear.Size = new System.Drawing.Size(190, 39);
            this.button_crear.TabIndex = 12;
            this.button_crear.Text = "Crear";
            this.button_crear.UseVisualStyleBackColor = true;
            this.button_crear.Click += new System.EventHandler(this.button_crear_Click);
            // 
            // button_borrar
            // 
            this.button_borrar.Location = new System.Drawing.Point(152, 104);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(124, 23);
            this.button_borrar.TabIndex = 13;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(152, 18);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(124, 23);
            this.button_buscar.TabIndex = 14;
            this.button_buscar.Text = "Buscar por ID";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(22, 62);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 15;
            this.label_id.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(46, 59);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_buscarTodo);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.button_actualizar);
            this.groupBox1.Controls.Add(this.label_id);
            this.groupBox1.Controls.Add(this.button_borrar);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Location = new System.Drawing.Point(417, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda y Manejo de Datos";
            // 
            // button_buscarTodo
            // 
            this.button_buscarTodo.Location = new System.Drawing.Point(152, 46);
            this.button_buscarTodo.Name = "button_buscarTodo";
            this.button_buscarTodo.Size = new System.Drawing.Size(124, 23);
            this.button_buscarTodo.TabIndex = 17;
            this.button_buscarTodo.Text = "Buscar Todo";
            this.button_buscarTodo.UseVisualStyleBackColor = true;
            this.button_buscarTodo.Click += new System.EventHandler(this.button_buscarTodo_Click);
            // 
            // numericUpDown_edicion
            // 
            this.numericUpDown_edicion.Location = new System.Drawing.Point(106, 150);
            this.numericUpDown_edicion.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_edicion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_edicion.Name = "numericUpDown_edicion";
            this.numericUpDown_edicion.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_edicion.TabIndex = 18;
            this.numericUpDown_edicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_edicion
            // 
            this.label_edicion.AutoEllipsis = true;
            this.label_edicion.AutoSize = true;
            this.label_edicion.Location = new System.Drawing.Point(42, 152);
            this.label_edicion.Name = "label_edicion";
            this.label_edicion.Size = new System.Drawing.Size(42, 13);
            this.label_edicion.TabIndex = 19;
            this.label_edicion.Text = "Edición";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Location = new System.Drawing.Point(42, 177);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(32, 13);
            this.label_autor.TabIndex = 20;
            this.label_autor.Text = "Autor";
            // 
            // textBox_autor
            // 
            this.textBox_autor.Location = new System.Drawing.Point(107, 177);
            this.textBox_autor.Name = "textBox_autor";
            this.textBox_autor.Size = new System.Drawing.Size(100, 20);
            this.textBox_autor.TabIndex = 21;
            // 
            // button_siguiente
            // 
            this.button_siguiente.Location = new System.Drawing.Point(498, 214);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(190, 39);
            this.button_siguiente.TabIndex = 22;
            this.button_siguiente.Text = "Siguiente";
            this.button_siguiente.UseVisualStyleBackColor = true;
            // 
            // button_anterior
            // 
            this.button_anterior.Location = new System.Drawing.Point(302, 214);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(190, 39);
            this.button_anterior.TabIndex = 23;
            this.button_anterior.Text = "Anterior";
            this.button_anterior.UseVisualStyleBackColor = true;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_anterior);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.textBox_autor);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_edicion);
            this.Controls.Add(this.numericUpDown_edicion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_crear);
            this.Controls.Add(this.dataGridView_libros);
            this.Controls.Add(this.dateTimePicker_publicacion);
            this.Controls.Add(this.checkBox_disponible);
            this.Controls.Add(this.comboBox_empastado);
            this.Controls.Add(this.textBox_genero);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_publicacion);
            this.Controls.Add(this.label_Empastado);
            this.Controls.Add(this.label_genero);
            this.Controls.Add(this.label_nombre);
            this.Name = "Form1";
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_libros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_edicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_genero;
        private System.Windows.Forms.Label label_Empastado;
        private System.Windows.Forms.Label label_publicacion;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_genero;
        private System.Windows.Forms.ComboBox comboBox_empastado;
        private System.Windows.Forms.CheckBox checkBox_disponible;
        private System.Windows.Forms.DateTimePicker dateTimePicker_publicacion;
        private System.Windows.Forms.DataGridView dataGridView_libros;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_crear;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_edicion;
        private System.Windows.Forms.Label label_edicion;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.TextBox textBox_autor;
        private System.Windows.Forms.Button button_buscarTodo;
        private System.Windows.Forms.Button button_siguiente;
        private System.Windows.Forms.Button button_anterior;
    }
}

