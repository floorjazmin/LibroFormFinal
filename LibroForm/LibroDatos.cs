using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroForm
{
    class LibroDatos
    {
        SqlConnection conec = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Libros;Data Source=DESKTOP-0F4UOPG\\SQLEXPRESS");
        public void InsertarLibros(Libro libro)
        {
            try
            {
                //abro la coneccion
                conec.Open();

                //creo el sql para insertar
                string query = @"INSERT INTO Libros (Titulo, Autor, ISBN, Paginas, Edicion, Editorial, CiudadyPais, FechaDeEdicion) VALUES (@Titulo, @Autor, @ISBN, @Paginas, @Edicion, @Editorial, @CiudadyPais, @FechaDeEdicion)";
                //creo los parametrs
                SqlParameter Titulo = new SqlParameter("@Titulo", libro.Titulo);

                SqlParameter Autor = new SqlParameter("@Autor", libro.Autor);

                SqlParameter ISBN = new SqlParameter("@ISBN", libro.ISBN);

                SqlParameter Paginas = new SqlParameter("@Paginas", libro.Paginas);

                SqlParameter Edicion = new SqlParameter("@Edicion", libro.Edicion);

                SqlParameter Editorial = new SqlParameter("@Editorial", libro.Editorial);

                SqlParameter CiudadyPais = new SqlParameter("@CiudadyPais", libro.CiudadyPais);

                SqlParameter FechaDeEdicion = new SqlParameter("@FechaDeEdicion", libro.FechaDeEdicion);


                //creo el comando mandando os parametro
                SqlCommand comando = new SqlCommand(query, conec);
                comando.Parameters.Add(Titulo);
                comando.Parameters.Add(Autor);
                comando.Parameters.Add(ISBN);
                comando.Parameters.Add(Paginas);
                comando.Parameters.Add(Edicion);
                comando.Parameters.Add(Editorial);
                comando.Parameters.Add(CiudadyPais);
                comando.Parameters.Add(FechaDeEdicion);
                //Este comando devuelve cantidad de filas afectadas y cero si no
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            //cierra la coneccion
            finally
            {
                conec.Close();
            }
        }

        public List<Libro> GetLibro(string search = null)
        {
            //Lista para guardar los contactos
            List<Libro> libros = new List<Libro>();
            try
            {
                conec.Open();
                string query = @"SELECT Id, Titulo, Autor, ISBN, Paginas, Edicion, Editorial, CiudadyPais, FechaDeEdicion
                                   FROM Libros";
                SqlCommand comando = new SqlCommand();
                if (!string.IsNullOrEmpty(search))
                {
                    //Agrega esto al query para que busque 
                    query += @" WHERE Titulo LIKE @Search OR Autor LIKE @Search OR ISBN LIKE @Search OR Paginas LIKE @Search OR Edicion LIKE @Search OR Editorial LIKE @Search OR CiudadyPais LIKE @Search OR FechaDeEdicion LIKE @Search";

                    //que lo buscado aparece en cualquier lugar de la columna
                    comando.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }

                comando.CommandText = query;
                comando.Connection = conec;

                //El data reader Trae todos los registros
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    //Itero el reader y lo agrego a la lista
                    libros.Add(new Libro
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Paginas = int.Parse(reader["Paginas"].ToString()),
                        Edicion = reader["Edicion"].ToString(),
                        Editorial = reader["Editorial"].ToString(),
                        CiudadyPais = reader["CiudadyPais"].ToString(),
                        FechaDeEdicion = reader["FechaDeEdicion"].ToString(),

                    });
                }



            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conec.Close();
            }
            return libros;

        }

        public void UpdateLibros(Libro libro)
        {
            try
            {
                //abro la coneccion
                conec.Open();

                //creo el sql para insertar
                string query = @"
                                 UPDATE  Libros 
                       SET Titulo=@Titulo, Autor=@Autor,ISBN=@ISBN,Paginas=@Paginas, Edicion=@Edicion, Editorial=@Editorial, CiudadyPais=@CiudadyPais, FechaDeEdicion=@FechaDeEdicion
                          WHERE Id=@Id";

                //creo los parametros
                SqlParameter Id = new SqlParameter("@Id", libro.Id);

                SqlParameter Titulo = new SqlParameter("@Titulo", libro.Titulo);

                SqlParameter Autor = new SqlParameter("@Autor", libro.Autor);

                SqlParameter ISBN = new SqlParameter("@ISBN", libro.ISBN);

                SqlParameter Paginas = new SqlParameter("@Paginas", libro.Paginas);

                SqlParameter Edicion = new SqlParameter("@Edicion", libro.Edicion);

                SqlParameter Editorial = new SqlParameter("@Editorial", libro.Editorial);

                SqlParameter CiudadyPais = new SqlParameter("@CiudadyPais", libro.CiudadyPais);

                SqlParameter FechaDeEdicion = new SqlParameter("@FechaDeEdicion", libro.FechaDeEdicion);

                //creo el comando mandando os parametro
                SqlCommand comando = new SqlCommand(query, conec);
                comando.Parameters.Add(Titulo);
                comando.Parameters.Add(Autor);
                comando.Parameters.Add(ISBN);
                comando.Parameters.Add(Paginas);
                comando.Parameters.Add(Edicion);
                comando.Parameters.Add(Editorial);
                comando.Parameters.Add(CiudadyPais);
                comando.Parameters.Add(FechaDeEdicion);
                //Este comando devuelve cantidad de filas afectadas y cero si no
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

               // throw;
            }
            //cierra la coneccion
            finally
            {
                conec.Close();
            }
        }
        public void BorrarLibros(int Id)

        {
            try
            {
                //abro la coneccion
                conec.Open();

                //creo el sql para insertar
                string query = @"
                                 DELETE FROM Libros WHERE Id=@Id";
                //creo los parametrs


                //creo el comando mandando el parametro
                SqlCommand comando = new SqlCommand(query, conec);
                //Solo necesito id para borrar
                comando.Parameters.Add(new SqlParameter("@Id", Id));

                //Este comando devuelve cantidad de filas afectadas y cero si no
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            //cierra la coneccion
            finally
            {
                conec.Close();
            }
        }
    } 
    
}
