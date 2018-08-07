using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LIBRERIA
{
    public class CLSMENU
    {
        public DataTable Llenar_Menus(String usu)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_PADRES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("USU", usu);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(dt);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public DataTable Llenar_Menus_ACTIVAR(String usu)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_PADRES_CON_TODO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("USU", usu);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(dt);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
        }

        public String Devuelve_Acceso(String nom ,String per,Int32 cod )
        {
            String msje = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("verifica_acceso", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", nom);
                cmd.Parameters.AddWithValue("per", per);
                cmd.Parameters.AddWithValue("cod", cod);
                cmd.Parameters.Add("msje",MySqlDbType.VarChar,100).Direction=ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["msje"].Value.ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
        }

        public void ACTUALIZA_ACCESO(Int32 CODIGO,bool ACCESO)
        {
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ACTUALIZA_ACCESO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("IDBARRA", CODIGO);
                cmd.Parameters.AddWithValue("ACCESO", ACCESO);
             
                cmd.ExecuteNonQuery();
              

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public String CONFIGURACION_BASE(String DESCRIP,String NOMBRE,Int32 PADRE,String PERFIL)
        {
            String msje = "--";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ASIGNA_BARRA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DES", DESCRIP);
                cmd.Parameters.AddWithValue("NOMB", NOMBRE);
                cmd.Parameters.AddWithValue("PAD", PADRE);
                cmd.Parameters.AddWithValue("PERF", PERFIL);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar,100).Direction=ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();
                return msje;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
