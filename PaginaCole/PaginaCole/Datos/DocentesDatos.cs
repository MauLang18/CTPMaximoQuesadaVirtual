using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class DocentesDatos
    {
        public List<Docentes> ListarD()
        {
            var oDoc = new List<Docentes>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_lstarrDo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oDoc.Add(new Docentes()
                        {
                            Cedula = dr["cedula"].ToString(),
                            Nombre = dr["nombre"].ToString(),
                            Apellido1 = dr["apellido1"].ToString(),
                            Apellido2 = dr["apellido2"].ToString(),
                        });
                    }
                }
            }

            return oDoc;
        }

        public Docentes ObtenerD(string cedula)
        {
            var oDoc = new Docentes();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtenerDo", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oDoc.Cedula = dr["cedula"].ToString();
                        oDoc.Nombre = dr["nombre"].ToString();
                        oDoc.Apellido1 = dr["apellido1"].ToString();
                        oDoc.Apellido2 = dr["apellido2"].ToString();
                    }
                }
            }

            return oDoc;
        }

        public bool GuardarD(Docentes oDoc)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarDo", conexion);
                    cmd.Parameters.AddWithValue("cedula", oDoc.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oDoc.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oDoc.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oDoc.Apellido2);
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

        public bool EditarD(Docentes oDoc)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_modificarDo", conexion);
                    cmd.Parameters.AddWithValue("cedula", oDoc.Cedula);
                    cmd.Parameters.AddWithValue("nombre", oDoc.Nombre);
                    cmd.Parameters.AddWithValue("apellido1", oDoc.Apellido1);
                    cmd.Parameters.AddWithValue("apellido2", oDoc.Apellido2);
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

        public bool EliminarD(Docentes oDoc)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminarDo", conexion);
                    cmd.Parameters.AddWithValue("cedula", oDoc.Cedula);
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
