using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroForm
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int Paginas { get; set; }
        public string Edicion { get; set; }
        public string Editorial { get; set; }
        public string CiudadyPais { get; set; }
        public string FechaDeEdicion { get; set; }
    }
}
