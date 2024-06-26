﻿using Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConexionBD
{
    public class DBCliente : ConexBD
    {
        public bool GuardarClie(int id, string Nombre, string Apellido, string Correo, int Telefono, string Direccion, int Cedula)
        {
            string Query = id > 0 ? "UPDATE Cliente SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo, Telefono=@Telefono, Direccion=@Direccion, Cedula=@Cedula WHERE Id=@Id" :
                                    "INSERT INTO Cliente (Nombre, Apellido, Correo, Telefono, Direccion,Cedula) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Direccion, @Cedula)";
            bool rs = false;
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@Nombre", Nombre));
                parameters.Add(new SqlParameter("@Apellido", Apellido));
                parameters.Add(new SqlParameter("@Correo", Correo));
                parameters.Add(new SqlParameter("@Telefono", Telefono));
                parameters.Add(new SqlParameter("@Direccion", Direccion));
                parameters.Add(new SqlParameter("@Cedula", Cedula));


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


        /*LISTAR-----------------------------------------------------*/
        public List<Modelos.objCliente> ListarCli()
        {
            List<Modelos.objCliente> r = new List<Modelos.objCliente>();

            try
            {
                dataReader = DATAREADER("SELECT id, Nombre, Apellido, Correo, Telefono, Direccion, Cedula FROM Cliente", null);
                while (dataReader.Read())
                {
                    r.Add(new Modelos.objCliente()
                    {
                        Id = dataReader.GetInt32(0),
                        Nombre = dataReader.GetString(1),
                        Apellido= dataReader.GetString(2),
                        Correo = dataReader.GetString(3),
                        Direccion = dataReader.GetString(5),
                        Telefono = dataReader.GetInt32(4),
                        Cedula = dataReader.GetInt32(6)


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

        public objCliente Buscar(string codigo)
        {
            objCliente rs = null;

            try
            {
                string query = "SELECT [id] ,[Nombre] ,[Apellido] ,[Correo] ,[Telefono] ,[Direccion] ,[Cedula] FROM [Facturas14mayo].[dbo].[Cliente] WHERE Cedula = "+ codigo;
                sqlCommand = COMANDO(query, null);
                dataTable = DATATABLE(sqlCommand);
                if (dataTable != null || dataTable.Rows.Count > 0)
                {

                    rs = new objCliente()
                    {
                        Cedula = dataTable.Rows[0].Field<int>("Cedula"),
                        Nombre = dataTable.Rows[0].Field<string>("Nombre") + " " + dataTable.Rows[0].Field<string>("Apellido"),
                        Telefono = dataTable.Rows[0].Field<int>("Telefono"),
                        Direccion = dataTable.Rows[0].Field<string>("Direccion")
                    };
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
