using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBCategorias : ConexBD
    {


        /*ELIMINAR DATOS A LA BASE DE DATOS------------------------------------------------------------*/

        public bool eliminarDatos(int id)
        {


            bool rs = false;
            try
            {
                sqlCommand = COMANDO("DELETE FROM Categoria WHERE Id=" + id, null);
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

        /*ACTUALIZAR LOS DATOS A LA BASE DE DATOS------------------------------------------------------------*/

        public bool ActualizarDatos(int id, string nuevoNombre)
        {
            bool resultado = false;
            try
            {
                sqlCommand = COMANDO("UPDATE Categoria SET Nombre = '" + nuevoNombre + "' WHERE Id = " + id, null);
                resultado = Convert.ToBoolean(EJECUTAR_COMANDO(sqlCommand));
            }
            catch (Exception e)
            {
                throw new Exception("Error al actualizar datos: " + e.Message);
            }
            finally
            {
                CerrarConexion();
            }
            return resultado;
        }

        /*GUARDAR LOS DATOS---------------------------------------------------*/

        public bool Guardar(int id, string Nombre)
        {
            string Query = id > 0 ? "UPDATE Categoria SET Nombre = '" + Nombre + "' " +
                "WHERE Id = " + id : "INSERT INTO Categoria (Nombre) VALUES ('" + Nombre + "')";
            bool rs = false;
            try
            {
                sqlCommand = COMANDO(Query, null);

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

        /*MUESTRA LOS DATOS EN LA TABLA-------------------------------------------------*/

        public List<Modelos.objCategoria> Listar()
        {
            List<Modelos.objCategoria> r = new List<Modelos.objCategoria>();
            try
            {
                dataReader = DATAREADER("SELECT id, Nombre FROM categoria", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objCategoria()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1)
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




