using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class AdministrativosDatos
    {
        public List<Administrativos> ListarA()
        {
            var oAdm = new List<Administrativos>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_lstarrAd", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oAdm.Add(new Administrativos()
                        {
                            Cedula = dr["cedula"].ToString(),
                            Nombre = dr["nombre"].ToString(),
                            Apellido1 = dr["apellido1"].ToString(),
                            Apellido2 = dr["apellido2"].ToString(),
                        });
                    }
                }
            }

            return oAdm;
        }

        public Administrativos ObtenerA(string cedula)
        {
            var oAdm = new Administrativos();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtenerAd", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oAdm.Cedula = dr["cedula"].ToString();
                        oAdm.Nombre = dr["nombre"].ToString();
                        oAdm.Apellido1 = dr["apellido1"].ToString();
                        oAdm.Apellido2 = dr["apellido2"].ToString();
                    }
                }
            }

            return oAdm;
        }

        public bool GuardarA(Administrativos oAdm)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarAd", conexion);
                    cmd.Parameters.AddWithValue("cedula", oAdm.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oAdm.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oAdm.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oAdm.Apellido2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool EditarA(Administrativos oAdm)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_modificarAd", conexion);
                    cmd.Parameters.AddWithValue("cedula", oAdm.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oAdm.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oAdm.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oAdm.Apellido2);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

        public bool EliminarA(Administrativos oAdm)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminarAd", conexion);
                    cmd.Parameters.AddWithValue("cedula", oAdm.Cedula);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                rpta = true;

            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

            return rpta;
        }

    }
}
