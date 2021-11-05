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
    public partial class FormDGV : Form
    {
        //Creo una instancia de la capa de negocios
        private LibroLogic _librologic;
        public FormDGV()
        {
            InitializeComponent();
            _librologic = new LibroLogic();
        }

        private void botAgregar_Click(object sender, EventArgs e)
        {
            //llamo al formulario para agregar datos.
            FormLibro formlibro = new FormLibro();
            formlibro.ShowDialog(this);
        }

        private void FormDGV_Load(object sender, EventArgs e)
        {
            CargarLibro();
        }

        //Carga contactos de la base de datos en la grilla
        public void CargarLibro(String SearchText = null)
        {
            List<Libro> libro = _librologic.GetLibro(SearchText);
            GridLibros.DataSource = libro;

        }

        private void GridLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cell va a ser nulo si no hace click en editar , o sea e la columna de editar. El dataGridviewLinkcell es alguna de las celdas de las columnas de editar o eliminar
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //Veo que link apreto para saber que hacer
            if (cell.Value.ToString() == "Editar")
            {
                //llamo al formulario de contactos para poder editar
                FormLibro formlibro = new FormLibro();
                //metodo que carga el contacto seleccionado
                formlibro.LoadLibro(new Libro
                {
                    Id = int.Parse((GridLibros.Rows[e.RowIndex].Cells[0]).Value.ToString()),
                    Titulo = GridLibros.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Autor = GridLibros.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    ISBN = GridLibros.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Paginas = int.Parse((GridLibros.Rows[e.RowIndex].Cells[4]).Value.ToString()),
                    Edicion = GridLibros.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Editorial = GridLibros.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    CiudadyPais = GridLibros.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    FechaDeEdicion = (GridLibros.Rows[e.RowIndex].Cells[8]).Value.ToString(),
                });
                //Muestra el formulario de educion
                formlibro.ShowDialog(this);
            }
            //si selecciona eliminar
            else if (cell.Value.ToString() == "Eliminar")
            {
                BorrarLibro(int.Parse((GridLibros.Rows[e.RowIndex].Cells[0]).Value.ToString()));
                CargarLibro();

            }
        }

        private void BorrarLibro(int id)
        {
            _librologic.BorrarLibro(id);
        }

        private void botBuscar_Click(object sender, EventArgs e)
        {
            CargarLibro(txtSearch.Text);
            txtSearch.Text = string.Empty;
        }
    }
}
