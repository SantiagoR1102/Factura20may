using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBSubCategoria : ConexBD
    {
        /*GUARDAR LOS DATOS---------------------------------------------------*/

        public bool GuardarSub(int id, string Nombre, int idCategoria)
        {
            string Query = id > 0 ? "UPDATE SubCategoria SET Nombre=@Nombre, idCategoria=@idCategoria WHERE Id=@Id" :
                              "INSERT INTO SubCategoria (Nombre, idCategoria) VALUES (@Nombre, @idCategoria)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Nombre", Nombre),
                    new SqlParameter("@idCategoria", idCategoria)
                };

                if (id > 0)
                {
                    parameters.Add(new SqlParameter("@Id", id));
                }

                sqlCommand = COMANDO(Query, parameters);
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

        /*LISTAR-----------------------------------------------------*/
        public List<Modelos.objSubCategoria> ListarSubCat()
        {
            List<Modelos.objSubCategoria> r = new List<Modelos.objSubCategoria>();

            try
            {
                dataReader = DATAREADER("select a.id, a.Nombre Subcategoria, b.Nombre Categoria, b.id  from SubCategoria a inner join Categoria b on b.id = a.idCategoria", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objSubCategoria()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Categoria = dataReader.GetString(2),
                        categoria = new Modelos.objCategoria()
                        {
                            Nombre = dataReader.GetString(2),
                            Id = dataReader.GetInt32(3),
                        }
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
