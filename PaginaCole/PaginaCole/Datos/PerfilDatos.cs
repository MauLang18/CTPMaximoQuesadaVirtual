using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class PerfilDatos
    {
        public Perfil DatosE(string cedula)
        {
            var oPerfil = new Perfil();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_datosEstudiantes", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPerfil.Cedula = dr["cedula"].ToString();
                        oPerfil.User = dr["usser"].ToString();
                        oPerfil.Seccion = dr["seccion"].ToString();
                        oPerfil.Rango = "Estudiante";
                    }
                }
            }

            return oPerfil;
        }

        public Perfil DatosD(string cedula)
        {
            var oPerfil = new Perfil();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_datosDocentes", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPerfil.Cedula = dr["cedula"].ToString();
                        oPerfil.User = dr["usser"].ToString();
                        oPerfil.Rango = "Docente";
                    }
                }
            }

            return oPerfil;
        }

        public Perfil DatosA(string cedula)
        {
            var oPerfil = new Perfil();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_datosAdministrativos", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPerfil.Cedula = dr["cedula"].ToString();
                        oPerfil.User = dr["usser"].ToString();
                        oPerfil.Rango = "Administrativo";
                    }
                }
            }

            return oPerfil;
        }

        public Perfil DatosC(string cedula)
        {
            var oPerfil = new Perfil();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_datosCreadores", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oPerfil.Cedula = dr["cedula"].ToString();
                        oPerfil.User = dr["usser"].ToString();
                        oPerfil.Rango = "Creador";
                    }
                }
            }

            return oPerfil;
        }
    }
}
