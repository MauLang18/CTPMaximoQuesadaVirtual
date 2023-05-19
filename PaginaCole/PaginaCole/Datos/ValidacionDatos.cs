using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class ValidacionDatos
    {
        public Registros CedE(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_cedE", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros UserE(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_UserE", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros CedD(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_cedD", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros UserD(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_UserD", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros CedA(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_cedA", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

        public Registros UserA(string cedula)
        {
            var oRegistros = new Registros();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_UserA", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oRegistros.Cedula = dr["cedula"].ToString();
                    }
                }
            }

            return oRegistros;
        }

    }
}
