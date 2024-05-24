using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

        
        public (string Nombre, int? Precio) BuscarProductoPorCodigo(string codigoPro)
        {
            string nombre = null;
            int? precio = null;
            string query = "SELECT Nombre, Precio FROM Productos WHERE CodigoPro = @CodigoPro";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CodigoPro", codigoPro)
                };

                SqlDataReader reader = DATAREADER(query, parameters);

                if (reader.Read())
                {
                    nombre = reader.GetString(0);
                    precio = reader.GetInt32(1);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                CerrarConexion();
            }

            return (nombre, precio);
        }

    }

}


