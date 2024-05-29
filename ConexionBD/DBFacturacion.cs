using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBFacturacion : ConexBD
    {

        /*Guardar*/
        public bool Guardar(objFacturacion modelo)
        {
            bool rs = false;
            try
            {
                string query = "INSERT INTO Factura_Encabezado (Cedula, Total) VALUES ('"+modelo.Cedula+"', '"+modelo.TotalFinal+"') ";
                sqlCommand = COMANDO(query, null);
                bool i = EJECUTAR_COMANDO(sqlCommand);
                if (i)
                {
                    rs = true;
                    int idFactura = IdFactura();
                    if(idFactura > 0)
                    {
                        if(modelo.Detalle.Count > 0)
                        {

                            GuardarDetalle(modelo.Detalle, idFactura);
                        }
                    }
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
            return rs;
        }

        public int IdFactura()
        {
            int rs = 0;
            try
            {
                string query = "SELECT TOP 1 Id FROM Factura_Encabezado ORDER BY Id DESC";
                sqlCommand = COMANDO(query, null);
                dataTable= DATATABLE(sqlCommand);
                if(dataTable != null || dataTable.Rows.Count > 0)
                {
                    rs = dataTable.Rows[0].Field<int>("Id");
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
            return rs;

        }

        public bool GuardarDetalle(List<objDetalleFactura> modelo, int id)
        {
            bool rs = false;
            try
            {
              

                for (int x = 0; x < modelo.Count; x++)
                {
                    string detalles = "INSERT INTO Factura_Detalle (CodigoProducto, Precio, Total, Cantidad, IdFactura ) VALUES ('" + modelo[x].CodPro + "', '" + modelo[x].Precio + "', '" + modelo[x].Total + "', '" + modelo[x].Cantidad + "', '" + id + "') ";
                    sqlCommand = COMANDO(detalles, null);
                    bool i = EJECUTAR_COMANDO(sqlCommand);
                    if (i)
                    {
                        rs = true;
                    }
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
            return rs;
        }

    }
    


}


