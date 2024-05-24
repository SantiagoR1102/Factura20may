using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelos;

namespace ConexionBD
{
    public class DBFacturacion : ConexBD
    {
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
    }
}