using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class CLSMEMORANDUM
    {
        public Int32 APLICAR_MEMO(string CRP1, string CRP2, string CRP3, DateTime FECH, String ASTO, Int32 APLIC_A, String USUARIO, String TIP)
        {
            Int32 msje = 0;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("APLICA_MEMO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CRP1", CRP1);
                cmd.Parameters.AddWithValue("CRP2", CRP2);
                cmd.Parameters.AddWithValue("CRP3", CRP3);
                cmd.Parameters.AddWithValue("FECH", FECH);
                cmd.Parameters.AddWithValue("ASTO", ASTO);
                cmd.Parameters.AddWithValue("APLIC_A", APLIC_A);
                cmd.Parameters.AddWithValue("USUARIO", USUARIO);
                cmd.Parameters.AddWithValue("TIP", TIP);
                cmd.Parameters.Add("MSJE", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = Convert.ToInt32(cmd.Parameters["MSJE"].Value);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();


        }

        public String MODIFICAR_MEMO(Int32 CODIGO,string CRP1, string CRP2, string CRP3, DateTime FECH, String ASTO, Int32 APLIC_A, String USUARIO, String TIP)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_MEMO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", CODIGO);
                cmd.Parameters.AddWithValue("CRP1", CRP1);
                cmd.Parameters.AddWithValue("CRP2", CRP2);
                cmd.Parameters.AddWithValue("CRP3", CRP3);
                cmd.Parameters.AddWithValue("FECH", FECH);
                cmd.Parameters.AddWithValue("ASTO", ASTO);
                cmd.Parameters.AddWithValue("APLIC_A", APLIC_A);
                cmd.Parameters.AddWithValue("USUARIO", USUARIO);
                cmd.Parameters.AddWithValue("TIP", TIP);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();


        }

        public DataTable RPT_VER_MEMOS_FECHAS(DateTime DE, DateTime HASTA)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_MEMOS_X_FECHA", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("DEL", DE);
                da.SelectCommand.Parameters.AddWithValue("AL", HASTA);
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


        public DataTable VER_MEMOS_FECHAS(DateTime DE, DateTime HASTA)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_MEMOS_X_FECHA", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("DEL", DE);
                da.SelectCommand.Parameters.AddWithValue("AL", HASTA);
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

        public DataTable VER_MEMO_CODIGO(Int32 CODIGO)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_MEMO_COD", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("COD", CODIGO);
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
        public DataTable VER_MEMOS_MODIFICAR_FECHAS(DateTime DE, DateTime HASTA)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_CONSULTA_MEMOS_FECHAS", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("DEL", DE);
                da.SelectCommand.Parameters.AddWithValue("AL", HASTA);
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

        public DataTable VER_MEMOS_MODIFICAR_FECHAS_ARMA(DateTime DE, DateTime HASTA,int ARMA)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_CONSULTA_MEMOS_FECHAS_ARMADOR", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("DEL", DE);
                da.SelectCommand.Parameters.AddWithValue("AL", HASTA);
                da.SelectCommand.Parameters.AddWithValue("ARMA", ARMA);
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

        public DataTable VER_MEMOS_FECHAS_USUARIO(DateTime DE, DateTime HASTA,Int32 USUARIO)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("VER_CONSULTA_MEMOS_FECHAS_ARMADOR", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("DEL", DE);
                da.SelectCommand.Parameters.AddWithValue("AL", HASTA);
                da.SelectCommand.Parameters.AddWithValue("ARMA", USUARIO);
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
    }
}
