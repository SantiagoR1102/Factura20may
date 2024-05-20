using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBCliente : ConexBD
    {
        public bool GuardarClie(int id, string Nombre, string Apellido, string Correo, int Telefono, string Direccion)
        {
            string Query = id > 0 ? "UPDATE Cliente SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, Telefono=@Telefono, Direccion=@Direccion WHERE Id=@Id" :
                                    "INSERT INTO Cliente (Nombre, Apellido, Correo, Telefono, Direccion) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Direccion)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Nombre", Nombre));
                parameters.Add(new SqlParameter("@Apellido", Apellido));
                parameters.Add(new SqlParameter("@Correo", Correo));
                parameters.Add(new SqlParameter("@Telefono", Telefono));
                parameters.Add(new SqlParameter("@Direccion", Direccion));

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



/*

        private string connectionString;
        public DBCliente(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public DataRow ObtenerClientePorId(int id)
        {
            DataRow cliente = null;
            string query = "SELECT Nombre, Apellido, Correo, Telefono, Direccion FROM Cliente WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Id", id));
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            cliente = dt.Rows[0];
                        }
                    }
                }
            }

            return cliente;
        }*/






        /*LISTAR-----------------------------------------------------*/
        public List<Modelos.objCliente> ListarCli()
        {
            List<Modelos.objCliente> r = new List<Modelos.objCliente>();

            try
            {
                dataReader = DATAREADER("SELECT id, Nombre, Apellido, Correo, Telefono, Direccion FROM Cliente", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objCliente()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Apellido= dataReader.GetString(2),
                        Correo = dataReader.GetString(3),
                        Direccion = dataReader.GetString(5),
                        Telefono = dataReader.GetInt32(4)

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
