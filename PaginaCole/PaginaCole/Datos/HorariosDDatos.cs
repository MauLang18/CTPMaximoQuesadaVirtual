using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class HorariosDDatos
    {
        public List<HorarioDiario> ListarHorariosD()
        {
            var oSec = new List<HorarioDiario>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listarHorarios", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new HorarioDiario()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            IDD = Convert.ToInt32(dr["IDD"]),
                            Imagen = dr["Imagen"].ToString(),
                            Grado = dr["Grado"].ToString(),
                            Fecha = dr["Fecha"].ToString(),
                            IDS = Convert.ToInt32(dr["IDS"]),
                            ImagenS = dr["ImagenS"].ToString(),
                            Seccion = dr["Seccion"].ToString()
                        });
                    }
                }
            }

            return oSec;
        }
        public bool GuardarHD(HorariosD oHorarios)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarHorariosD", conexion);
                    cmd.Parameters.AddWithValue("fecha", oHorarios.Dia);
                    cmd.Parameters.AddWithValue("horario", oHorarios.Imagen);
                    cmd.Parameters.AddWithValue("grado", oHorarios.Grado);
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

        public HorarioDiario ObtenerHD(int id)
        {
            var oEst = new HorarioDiario();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtenerHD", conexion);
                cmd.Parameters.AddWithValue("ID", id);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oEst.ID = Convert.ToInt32(dr["ID"]);
                        oEst.Imagen = dr["Imagen"].ToString();
                        oEst.Fecha = dr["Fecha"].ToString();
                        oEst.Grado = dr["Grado"].ToString();
                    }
                }
            }

            return oEst;
        }

        public bool GuardarHS(HorarioDiario oHorarios)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregarHorariosS", conexion);
                    cmd.Parameters.AddWithValue("Seccion", oHorarios.Seccion);
                    cmd.Parameters.AddWithValue("ImagenS", oHorarios.ImagenS);
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

        public bool ModificarHD(HorarioDiario oHorarios)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_modificarHD", conexion);
                    cmd.Parameters.AddWithValue("ID", oHorarios.ID);
                    cmd.Parameters.AddWithValue("Fecha", oHorarios.Fecha);
                    cmd.Parameters.AddWithValue("Grado", oHorarios.Grado);
                    cmd.Parameters.AddWithValue("Imagen", oHorarios.Imagen);
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

        public bool EliminarHD(HorarioDiario oHorarios)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminarHD", conexion);
                    cmd.Parameters.AddWithValue("ID", oHorarios.ID);
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
