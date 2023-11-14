using InicioSesion.Datos.Interfaz;
using InicioSesion.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Datos.Implementacion
{
    internal class FuncionesDao : IFuncionesDao
    {
        public bool Crear(Funciones oFunciones)
        {
            bool resultado = true;
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-KLE7FAD\\SQLEXPRESS;Initial Catalog=Cine2_0;Integrated Security=True");
            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_MAESTRO";
                comando.Parameters.AddWithValue("@dia", oFunciones.Dia);
                comando.Parameters.AddWithValue("@hora", oFunciones.Hora);
                comando.Parameters.AddWithValue("@id_sala", oFunciones.Sala);

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@id_pelicula";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int peliculaNro = (int)parametro.Value;

                SqlCommand cmdDetalle;

                cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", conexion, t);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_pelicula", oFunciones.Pelicula.Pelicula_ID);
                cmdDetalle.Parameters.AddWithValue("@titulo", oFunciones.Pelicula.Titulo);
                cmdDetalle.Parameters.AddWithValue("@genero", oFunciones.Pelicula.Genero);
                cmdDetalle.Parameters.AddWithValue("@director", oFunciones.Pelicula.Director);
                cmdDetalle.Parameters.AddWithValue("@idioma", oFunciones.Pelicula.Idioma);
                cmdDetalle.Parameters.AddWithValue("@duracion", oFunciones.Pelicula.Duracion);
                cmdDetalle.Parameters.AddWithValue("@clasificacion", oFunciones.Pelicula.Clasificacion);

                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
         return resultado;
        }
    }
}
