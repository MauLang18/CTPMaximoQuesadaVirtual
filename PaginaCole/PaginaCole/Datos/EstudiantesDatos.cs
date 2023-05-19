using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class EstudiantesDatos
    {
        public List<Estudiantes> ListarE()
        {
            var oEst = new List<Estudiantes>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_lstarrEs", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oEst.Add(new Estudiantes()
                        {
                            Cedula = dr["cedula"].ToString(),
                            Nombre = dr["nombre"].ToString(),
                            Apellido1 = dr["apellido1"].ToString(),
                            Apellido2 = dr["apellido2"].ToString(),
                        });
                    }
                }
            }

            return oEst;
        }

        public Estudiantes ObtenerE(string cedula)
        {
            var oEst = new Estudiantes();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtenerEs", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oEst.Cedula = dr["cedula"].ToString();
                        oEst.Nombre = dr["nombre"].ToString();
                        oEst.Apellido1 = dr["apellido1"].ToString();
                        oEst.Apellido2 = dr["apellido2"].ToString();
                    }
                }
            }

            return oEst;
        }

        public bool GuardarE(Estudiantes oEst)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarEs", conexion);
                    cmd.Parameters.AddWithValue("cedula", oEst.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oEst.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oEst.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oEst.Apellido2);
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

        public bool EditarE(Estudiantes oEst)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_modificarEs", conexion);
                    cmd.Parameters.AddWithValue("cedula", oEst.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oEst.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oEst.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oEst.Apellido2);
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

        public bool EliminarE(Estudiantes oEst)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminarEs", conexion);
                    cmd.Parameters.AddWithValue("cedula", oEst.Cedula);
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
