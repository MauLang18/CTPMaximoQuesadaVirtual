using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class RegistroEDatos
    {

        public Registros ObtenerE(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioEE", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Id = Convert.ToInt32(dr["id"]);
                        oRegistros.User = dr["usser"].ToString();
                        oRegistros.Pass = dr["pass"].ToString();
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros ObtenerEE(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioEE", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return oRegistros;
        }

        public bool GuardarE(Registros oRegistros)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarE", conexion);
                    cmd.Parameters.AddWithValue("cedula", oRegistros.Cedula);
                    cmd.Parameters.AddWithValue("user", oRegistros.User);
                    cmd.Parameters.AddWithValue("pass", oRegistros.Pass);
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

        public bool EditarE(Registros oRegistros)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_editarE", conexion);
                    cmd.Parameters.AddWithValue("user", oRegistros.User);
                    cmd.Parameters.AddWithValue("pass", oRegistros.Pass);
                    cmd.Parameters.AddWithValue("cedula", oRegistros.Cedula);
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

        public bool EliminarE(string cedula)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminarE", conexion);
                    cmd.Parameters.AddWithValue("cedula", cedula);
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
