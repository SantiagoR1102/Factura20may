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
            string query = id > 0 ?
                "UPDATE Factura SET CodigoPro=@CodigoPro, Nombre=@Nombre, Cantidad=@Cantidad, Precio=@Precio, Total=@Total WHERE Id=@Id" :
                "INSERT INTO Factura (CodigoPro, Nombre, Cantidad, Precio, Total) VALUES (@CodigoPro, @Nombre, @Cantidad, @Precio, @Total)";

            bool rs = false;

            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
        {
                 new SqlParameter("@CodigoPro", CodigoPro),
                 new SqlParameter("@Nombre", Nombre),
                 new SqlParameter("@Cantidad", Cantidad),
                 new SqlParameter("@Precio", Precio),
                 new SqlParameter("@Total", Total)
        };

                if (id > 0)
                {
                    new SqlParameter("@Id", Total);

                    //parameters.Add(new SqlParameter("@Id", id));
                }

                sqlCommand = COMANDO(query, parameters);
                rs = Convert.ToBoolean(EJECUTAR_COMANDO(sqlCommand));

            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar la factura: " + e.Message);
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




        //listar----------------------------------------------------------------------------------------------------------

        public List<Modelos.objDetalleFactura> Listardetalelfac()
        {
            List<Modelos.objDetalleFactura> r = new List<Modelos.objDetalleFactura>();

            try
            {

                string query = @"SELECT f.id, f.CodigoPro, f.Nombre AS Producto, f.Cantidad, f.Precio, f.Total 
                                    FROM Factura f INNER JOIN Productos p ON f.CodigoPro = p.CodigoPro;";

                SqlDataReader dataReader = DATAREADER(query, null);
                while (dataReader.Read())

                {
                    r.Add(new Modelos.objDetalleFactura()
                    {
                        Id = dataReader.GetInt32(0),
                        CodPro = dataReader.GetInt32(1),
                        Nombre = dataReader.GetString(2),
                        Cantidad = dataReader.GetInt32(3),
                        Precio = dataReader.GetInt32(4),
                        Total = dataReader.GetInt32(5)

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


