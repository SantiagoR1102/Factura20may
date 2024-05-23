using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBProductos : ConexBD
    {
        public bool Guardar(int id, string nombre, int precio, int idSubCategoria, int codPro)
        {
            string query = id > 0 ?
                "UPDATE Productos SET Nombre=@Nombre, idSubCategoria=@idSubCategoria, Precio=@Precio, CodigoPro=@CodigoPro WHERE Id=@Id" :
                "INSERT INTO Productos (Nombre, Precio, idSubCategoria, CodigoPro) VALUES (@Nombre, @Precio, @idSubCategoria, @CodigoPro)";

            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Nombre", nombre),
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@idSubCategoria", idSubCategoria),
                    new SqlParameter("@CodigoPro", codPro)
                };

                if (id > 0)
                {
                    parameters.Add(new SqlParameter("@Id", id));
                }

                SqlCommand sqlCommand = COMANDO(query, parameters);
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

        /* LISTAR___________________________________________________________ */
        public List<Modelos.objProductos> Listar()
        {
            List<Modelos.objProductos> r = new List<Modelos.objProductos>();
            try
            {
                string query = @"SELECT p.Id, p.Nombre AS Producto, p.Precio,
                                 p.CodigoPro,
                                 s.Nombre AS SubCategoria, 
                                 c.Nombre AS Categoria 
                                 FROM Productos p 
                                 INNER JOIN SubCategoria s ON s.Id = p.idSubCategoria
                                 INNER JOIN Categoria c ON c.Id = s.idCategoria";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objProductos()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Precio = dataReader.GetInt32(2),
                        CodPro = dataReader.GetInt32(3),
                        SubCategoria = dataReader.GetString(4),
                        categoria = dataReader.GetString(5)
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
