using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelos;

namespace ConexionBD
{
    public class DBFacturacion : ConexBD
    {

        // Busca el nombre al poner la cedula 

        public string BuscarNombrePorCedula(string cedula)
        {
            string nombre = null;
            string query = "SELECT Nombre FROM Cliente WHERE Cedula = @Cedula";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Cedula", cedula)
                };

                SqlDataReader reader = DATAREADER(query, parameters);

                if (reader.Read())
                {
                    nombre = reader.GetString(0);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el nombre del cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return nombre;
        }

        //Busca el codigo del producto y trae el precio
        public int? BuscarPrecioPorCodigo(string codigoPro)
        {
            int? precio = null;
            string query = "SELECT Precio FROM Productos WHERE CodigoPro = @CodigoPro";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CodigoPro", codigoPro)
                };
                SqlDataReader reader = DATAREADER(query, parameters);
                if (reader.Read())
                {
                    precio = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el Precio del Producto: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return precio;
        }

    }

}


