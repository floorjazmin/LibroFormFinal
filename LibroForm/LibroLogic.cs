using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroForm
{
    class LibroLogic
    {
        //declaro una variableclase de acceso a datos
        private LibroDatos _Librodatos;
        //Esta Clase es la capa de negocios. Aqui estan las validaciones
        //Este metodo guarda los contactos

        //en el constructos Creo una instancia de la clase de acceso a datos 
        public LibroLogic()
        {
            //Creo una instancia del ojeto de acceso a datos en el constructor
            _Librodatos = new LibroDatos();

        }

        public Libro GurdarLibro(Libro libro)
        {

            //Es cero cuando graba un contacto nuevo
            if (libro.Id == 0)


                _Librodatos.InsertarLibros(libro);


            else
            {
                _Librodatos.UpdateLibros(libro);

            }
            return libro;
        }
        //Devueve en una lista los contactos de la base de datos
        public List<Libro> GetLibro(string TextSearch = null)

        {

            return _Librodatos.GetLibro(TextSearch);

        }

        public void BorrarLibro(int Id)
        {

            _Librodatos.BorrarLibros(Id);

        }
    }
}
