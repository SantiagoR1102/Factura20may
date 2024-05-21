using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBProductos : ConexBD
    {

        public bool Guardar(string Nombre, int id, int Precio, int idSubCategoria)
        {
            string Query = id > 0 ? "UPDATE Productos SET Nombre=@Nombre, idSubCategoria=@idSubCategoria, Precio=@Precio WHERE id=@Id" :
                "INSERT INTO Productos (Nombre, Precio, idSubCategoria ) VALUES (@Nombre, @Precio, @idSubCategoria)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Nombre", Nombre));
                parameters.Add(new SqlParameter("@Precio", Precio));
                parameters.Add(new SqlParameter("@idSubCategoria", idSubCategoria));
                if (id > 0)
                {
                    parameters.Add(new SqlParameter("@Id", id));
                }

                sqlCommand = COMANDO(Query, parameters);
                rs = Convert.ToBoolean(EJECUTAR_COMANDO(sqlCommand));

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




        /*LISTAR_________----------------------------------------------------*/
        public List<Modelos.objProductos> Listar()
        {
            List<Modelos.objProductos> r = new List<Modelos.objProductos>();
            try
            {


                dataReader = DATAREADER("SELECT id,Nombre,Precio,idSubCategoria", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objProductos()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Precio = dataReader.GetInt32(2),
                        idSubCategoria = dataReader.GetInt32(3)
                    });
                }
            }catch(Exception e)
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



