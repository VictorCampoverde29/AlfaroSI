using MySql.Data.MySqlClient;
using System;

using System.Data;
using System.Linq;
using System.Text;

namespace LIBRERIA
{
    public class CLSACTIVIDAD
    {

        public DataTable Ver_actividades_total(DateTime f1)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("ver_actividades_por_estado", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("fch", f1);
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(DT);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }

        public DataTable Ver_terminadas(DateTime f1,DateTime f2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Ver_Actividades_ter_x_fechas", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("f1", f1);
                da.SelectCommand.Parameters.AddWithValue("f2", f2);
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(DT);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public DataTable llenar_pendientes_mes()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ver_actividades_pendientes", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public String Nueva_Actividad(String DESCRI ,String ESTA ,
DateTime F_INI, DateTime F_FIN , DateTime H_INICIO ,DateTime H_FIN ,
String AREA,int PTJE,String COD_USU)
        {
            String msje = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("NUEVA_ACTIVIDAD_DIARIA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("ESTA", ESTA);
                cmd.Parameters.AddWithValue("F_INI", F_INI);
                cmd.Parameters.AddWithValue("F_FIN", F_FIN);
                cmd.Parameters.AddWithValue("H_INICIO", H_INICIO);
                cmd.Parameters.AddWithValue("H_FIN", H_FIN);
                cmd.Parameters.AddWithValue("AREA", AREA);
                cmd.Parameters.AddWithValue("PTJE", PTJE);
                cmd.Parameters.AddWithValue("COD_USU", COD_USU);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return msje;
        }

        public String Editar_Actividad(Int32 COD,String DESCRI, String ESTA,
DateTime F_INI, DateTime F_FIN, DateTime H_INICIO, DateTime H_FIN,
String AREA, int PTJE, String COD_USU)
        {
            String msje = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("EDITAR_ACTIVIDAD", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD",COD);
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("ESTA", ESTA);
                cmd.Parameters.AddWithValue("F_INI", F_INI);
                cmd.Parameters.AddWithValue("F_FIN", F_FIN);
                cmd.Parameters.AddWithValue("H_INICIO", H_INICIO);
                cmd.Parameters.AddWithValue("H_FIN", H_FIN);
                cmd.Parameters.AddWithValue("AREA", AREA);
                cmd.Parameters.AddWithValue("PTJE", PTJE);
                cmd.Parameters.AddWithValue("COD_USU", COD_USU);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return msje;
        }

        public String Eliminar_Actividad(Int32 numero)
        {
            String msje = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_ACTIVIDAD", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", numero);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return msje;
        }

        public String Terminar_Actividad(Int32 numero,DateTime ffin,DateTime hfin,Int32 ptje)
        {
            String msje = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("TERMINAR_ACTIVIDAD", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", numero);
                cmd.Parameters.AddWithValue("F_FIN", ffin);
                cmd.Parameters.AddWithValue("H_FIN", hfin);
                cmd.Parameters.AddWithValue("PTJE", ptje);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return msje;
        }
    }
}
