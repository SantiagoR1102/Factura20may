using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBProductos : ConexBD
    {
        public bool Guardar(int id, string Nombre, int Precio, int idSubCategoria)
        {
            string Query = id > 0 ? "UPDATE Productos SET Nombre=@Nombre, idSubCategoria=@idSubCategoria, Precio=@Precio WHERE id=@Id" :
                                     "INSERT INTO Productos (Nombre, Precio, idSubCategoria) VALUES (@Nombre, @Precio, @idSubCategoria)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Nombre", Nombre),
                    new SqlParameter("@Precio", Precio),
                    new SqlParameter("@idSubCategoria", idSubCategoria)
                };

                if (id > 0)
                {
                    parameters.Add(new SqlParameter("@Id", id));
                }

                SqlCommand sqlCommand = COMANDO(Query, parameters);
                rs = EJECUTAR_COMANDO(sqlCommand);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return rs;
        }

        /*LISTAR___________________________________________________________*/
        public List<Modelos.objProductos> Listar()
        {
            List<Modelos.objProductos> r = new List<Modelos.objProductos>();
            try
            {
                SqlDataReader dataReader = DATAREADER("SELECT a.id, a.Nombre, a.Precio, b.Nombre AS SubCategoria, b.id AS idSubCategoria " +
                                                      "FROM Productos a " +
                                                      "INNER JOIN SubCategoria b ON b.id = a.idSubCategoria", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objProductos()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Precio = dataReader.GetInt32(2),
                        idSubCategoria = dataReader.GetInt32(4) // Cambiado a la columna correcta
                    });
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return r;
        }
    }
}
