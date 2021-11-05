using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroForm
{
    public partial class FormLibro : Form
    {
        //declaro una variable gloal de la clase contactologic puedo acceder desde cualquir clase
        private LibroLogic _librologic;
        //Creo una nuwva instancia de cocntacto para obtener el id. con esta instancia voy a saber si esta editando o grabando un nuevo contacto
        private Libro _libro;
        public FormLibro()
        {
            InitializeComponent();
            _librologic = new LibroLogic();

        }

        private void botSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botGuardar_Click(object sender, EventArgs e)
        {

            //guarda el contacto
            SaveLibro();
            //cierra la coneccion
            this.Close();
            //actualiza la carga de contactos en la grilla en el formulario main. Llamando al formulario padre para que se actualice
            ((FormDGV)this.Owner).CargarLibro();
        }

        //guarda el contacto
        private void SaveLibro()
        {
            Libro libro = new Libro();
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.ISBN = txtISBN.Text;
            libro.Paginas = int.Parse(txtPaginas.Text);
            libro.Edicion = txtAutor.Text;
            libro.Editorial = txtAutor.Text;
            libro.CiudadyPais = txtAutor.Text;
            


            //Si el Id es distinto de null este metdo se ejecuto y id tiene algo , y si no ponemos 0. Si entro por edit contact id tiene algo y si no esta vacio
            // contacto.Id = _contacto != null ? _contacto.Id : 0;

            //Si la instancia _contacto es distinto de null significa que entro por el edit entonces uso el id , y si no entro por guardar y guardo 0
            //ya que usa el mismo boton de guardar necesito diferenciar si esta editando o grabando uno nuevo por eso usa _contacto
            //? para verdadero y : para falso.
            libro.Id = _libro != null ? _libro.Id : 0;
            _librologic.GurdarLibro(libro);

        }

        //se ejecuta cuando selecciona editar en la grilla
        public void LoadLibro(Libro libro)
        {//aqui en esta variabl global copio la instancia e contacto para guardarme el ID del contacto
            _libro = libro;
            if (libro != null)
            {
                ClearForm();
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                txtISBN.Text = libro.ISBN;
                txtPaginas.Text = libro.Paginas.ToString();
                txtEdicion.Text = libro.Edicion;
                txtEditorial.Text = libro.Editorial;
                txtCiudadyPais.Text = libro.CiudadyPais;
            }

        }
        private void ClearForm()
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtISBN.Text = string.Empty;
            txtPaginas.Text = string.Empty;
            txtEdicion.Text = string.Empty;
            txtEditorial.Text = string.Empty;
            txtCiudadyPais.Text = string.Empty;

        }
        private bool ValidarDato()
        {
            //valida los campos ingresados por el usuario
            bool datoValido;
            datoValido = true;
            DTPFechadeEdicion.MaxDate = DateTime.Today;
            if (txtTitulo.Text.Trim() == "")
            {

                MessageBox.Show("El Titulo está vacío");
                datoValido = false;
                txtTitulo.Focus();

            }

            if (txtAutor.Text.Trim() == "")
            {
                MessageBox.Show("El Autor está vacío");
                txtAutor.Focus();
                datoValido = false;
            }

            try
            {
                int.Parse(txtISBN.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El dato ISBN es incorrecto o esta vacio");
                datoValido = false;
            }
            try
            {
                int.Parse(txtPaginas.Text);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("El dato de las Páginas es incorrecto o esta vacio");
                datoValido = false;
            }

            if (txtEdicion.Text.Trim() == "")
            {
                MessageBox.Show("El dato de Edicion está vacío");
                txtEdicion.Focus();
                datoValido = false;
            }

            if (txtEditorial.Text.Trim() == "")
            {
                MessageBox.Show("El dato de la Editorial está vacío");
                txtEditorial.Focus();
                datoValido = false;
            }

            if (txtCiudadyPais.Text.Trim() == "")
            {
                MessageBox.Show("El dato de la Ciudad y Pais está vacío");
                txtCiudadyPais.Focus();
                datoValido = false;
            }


            return datoValido;
        }
    }
}
