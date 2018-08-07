using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
   public class CLSLLAMADAS
    {
        public String REGISTRAR_LLAMADA(DateTime FCHA, String CLI, String OBS,String VTA, String USUARIO)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_LLAMADA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FCHA", FCHA);
                cmd.Parameters.AddWithValue("CLI", CLI);
                cmd.Parameters.AddWithValue("OBS", OBS);
                cmd.Parameters.AddWithValue("VTA", VTA);
                cmd.Parameters.AddWithValue("USUARIO", USUARIO);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
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
        public DataTable Devolver_LLAMADAST(String  VALOR)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_CONSULTA_LLAMADAS_DIA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(dt);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
        public String QUITAR_LLAMADAS(Int32 VALOR)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("QUITAR_LLAMADA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("VALOR", VALOR);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
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


    }
}
