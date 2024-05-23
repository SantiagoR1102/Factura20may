using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Modelos;

namespace ConexionBD
{
    public class DBFacturacion : ConexBD
    {
        public objCliente BuscarClientePorNombre(string nombre)
        {
            objCliente cliente = null;
            string query = "SELECT Nombre FROM Cliente WHERE Nombre LIKE @Nombre";

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@Nombre", "%" + nombre + "%")
                };

                SqlDataReader reader = DATAREADER(query, parameters);

                if (reader.Read())
                {
                    cliente = new objCliente
                    {
                        Nombre = reader.GetString(0)
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el cliente: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return cliente;
        }
    }
}
