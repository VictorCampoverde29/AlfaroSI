using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class CLSSERIES
    {
        public String REG_SERIE(string TIPO,String COMPU, string USUARIO,int SERIE,int CORRELATIVO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTAR_SERIES", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TIP", TIPO);
                cmd.Parameters.AddWithValue("COMPU", COMPU);
                cmd.Parameters.AddWithValue("USU", USUARIO);
                cmd.Parameters.AddWithValue("SER", SERIE);
                cmd.Parameters.AddWithValue("CORREL", CORRELATIVO);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return MSJE;
            Conexionbd.Desconectar();

        }


        public String MODIFICAR_SERIE(Int32 COD,String ESTADO,string TIPO, String COMPU, string USUARIO, int SERIE, int CORRELATIVO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_SERIES", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.AddWithValue("EST", ESTADO);
                cmd.Parameters.AddWithValue("TIP", TIPO);
                cmd.Parameters.AddWithValue("COMPU", COMPU);
                cmd.Parameters.AddWithValue("USU", USUARIO);
                cmd.Parameters.AddWithValue("SER", SERIE);
                cmd.Parameters.AddWithValue("CORREL", CORRELATIVO);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return MSJE;
            Conexionbd.Desconectar();

        }
        public DataTable llenar_SERIES()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_SERIES", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
    }
}
