using PaginaCole.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using System;

namespace PaginaCole.Datos
{
    public class SeccionesDatos
    {
        public List<Secciones> Listar7_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar7_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar7_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar7_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar7_5()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_5", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_5(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_5", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar7_6()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar7_6", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener7_6(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener7_6", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar7_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar7_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar7_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar7_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_5()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_5", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_5(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_5", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar8_6()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar8_6", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener8_6(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener8_6", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar8_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar8_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar8_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar8_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_5()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_5", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_5(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_5", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_5(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_5", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar9_6()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar9_6", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener9_6(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener9_6", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar9_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar9_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar9_6(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar9_6", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar10_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar10_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener10_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener10_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar10_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar10_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar10_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar10_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar10_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar10_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener10_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener10_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar10_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar10_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar10_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar10_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar10_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar10_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener10_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener10_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar10_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar10_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar10_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar10_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar10_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar10_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener10_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener10_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar10_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar10_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar10_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar10_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar11_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar11_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener11_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener11_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar11_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar11_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar11_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar11_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar11_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar11_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener11_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener11_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar11_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar11_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar11_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar11_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar11_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar11_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener11_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener11_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar11_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar11_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar11_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar11_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar11_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar11_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener11_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener11_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar11_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar11_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar11_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar11_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar12_1()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar12_1", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener12_1(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener12_1", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar12_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar12_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar12_1(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar12_1", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar12_2()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar12_2", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener12_2(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener12_2", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar12_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar12_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar12_2(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar12_2", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar12_3()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar12_3", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener12_3(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener12_3", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar12_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar12_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar12_3(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar12_3", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public List<Secciones> Listar12_4()
        {
            var oSec = new List<Secciones>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_listar12_4", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Add(new Secciones()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            Cedula = dr["cedula"].ToString(),
                            Seccion = dr["seccion"].ToString(),
                        });
                    }
                }
            }

            return oSec;
        }

        public Secciones Obtener12_4(string cedula)
        {
            var oSec = new Secciones();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_obtener12_4", conexion);
                cmd.Parameters.AddWithValue("cedula", cedula);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oSec.Id = Convert.ToInt32(dr["id"]);
                        oSec.Cedula = dr["cedula"].ToString();
                        oSec.Seccion = dr["seccion"].ToString();
                    }
                }
            }

            return oSec;
        }

        public bool Guardar12_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_agregar12_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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

        public bool Eliminar12_4(Secciones oSec)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_eliminar12_4", conexion);
                    cmd.Parameters.AddWithValue("cedula", oSec.Cedula);
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


