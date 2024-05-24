using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBFacturacion : ConexBD
    {
        //Guardar Datos de la list

        public bool Guardar(int id, int CodigoPro, string Nombre, int Cantidad, int Precio, int Total)
        {
            string Query = id > 0 ? "UPDATE Cliente SET CodigoPro=@CodigoPro, Nombre=@Nombre, Cantidad=@Cantidad, Precio=@Precio, Total=@Total WHERE Id=@Id" :
                                    "INSERT INTO Cliente (CodigoPro, Nombre, Cantidad, Precio, Total) VALUES (@CodigoPro, @Nombre, @Cantidad, @Precio, @Total)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@CodigoPro", CodigoPro));
                parameters.Add(new SqlParameter("@Nombre", Nombre));
                parameters.Add(new SqlParameter("@Cantidad", Cantidad));
                parameters.Add(new SqlParameter("@Precio", Precio));
                parameters.Add(new SqlParameter("@Total", Total));

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



        //listar

        public List<Modelos.objDetalleFactura> Listardetalelfac()
        {
            List<Modelos.objDetalleFactura> r = new List<Modelos.objDetalleFactura>();

            try
            {

                dataReader = DATAREADER("SELECT CodigoPro, Nombre, Cantidad, Precio, Total FROM Productos", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objDetalleFactura()
                    {
                        CodPro = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Cantidad = dataReader.GetInt32(2),
                        Precio = dataReader.GetInt32(3),
                        Total = dataReader.GetInt32(4)

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


