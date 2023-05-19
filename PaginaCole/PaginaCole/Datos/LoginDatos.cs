using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class LoginDatos
    {
        public Login UsuariosE(string cedula, string user, string pass)
        {
            var oLogin = new Login();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioE", conexion);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLogin.Id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return oLogin;
        }

        public Login UsuariosA(string cedula, string user, string pass)
        {
            var oLogin = new Login();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioA", conexion);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLogin.Id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return oLogin;
        }

        public Login UsuariosC(string cedula, string user, string pass)
        {
            var oLogin = new Login();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioC", conexion);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLogin.Id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return oLogin;
        }

        public Login UsuariosD(string cedula, string user, string pass)
        {
            var oLogin = new Login();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_usuarioD", conexion);
                cmd.Parameters.AddWithValue("user", user);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLogin.Id = Convert.ToInt32(dr["id"]);
                    }
                }
            }

            return oLogin;
        }
    }
}
