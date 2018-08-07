using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
   public class CLSDESCARGAS
    {
        public String REGISTRAR_DESCARGA(String OBSRV , String EPCRGA, String CB,String CANTI,
DateTime FECHA, String LB_EMPRESA)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DESCARGA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("EMP_CARGA", EPCRGA);
                cmd.Parameters.AddWithValue("CANT_BULTOS", CB);
                cmd.Parameters.AddWithValue("CANT", CANTI);
                cmd.Parameters.AddWithValue("FCHA", FECHA);
                cmd.Parameters.AddWithValue("LAB_EMPRESA", LB_EMPRESA);
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


        public String Confirma_t_ingresos(Int32 COD,String PT,DateTime HS, String BULTOS,
 String CONDUCTOR,String LICENCIA,String PLACA)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("CONFIRMA_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("COD", COD);
                cmd.Parameters.AddWithValue("PARTIDA", PT);
                cmd.Parameters.AddWithValue("HORAS", HS);
                cmd.Parameters.AddWithValue("BULTOS", BULTOS);
                cmd.Parameters.AddWithValue("COND", CONDUCTOR);
                cmd.Parameters.AddWithValue("LIC", LICENCIA);
                cmd.Parameters.AddWithValue("PLC", PLACA);
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
        public DataTable llenar_PERSOnal_x_codigo(Int32 valor)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("LLENAR_PERSONAL_DESCARGA_VISITA_COD", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("COD", valor);
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }


        public DataTable llenar_descargas_x_estado(Int32 estado,DateTime del,DateTime al)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("ver_descargas_segun_estado", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("EST", estado);
                da.SelectCommand.Parameters.AddWithValue("DEL", del);
                da.SelectCommand.Parameters.AddWithValue("AL", al );
                da.SelectCommand.ExecuteNonQuery();
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public String REGISTRAR_DETALLE_DESCARGA(String NOM ,String  NDOC ,String TPO ,Int32 COD_DESCARGA )
        {
            String msje="-------";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DETALLE_DESCARGA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOM", NOM);
                cmd.Parameters.AddWithValue("NDOC", NDOC);
                cmd.Parameters.AddWithValue("TPO", TPO);
                cmd.Parameters.AddWithValue("COD_DESCARGA", COD_DESCARGA);
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();
        }


        public String ELIMINAR_DETALLE_DESCARGA(String NOM,  Int32 COD_DESCARGA)
        {
            String msje = "-------";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINA_DETALLE_DESCARGA_VISITA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOM", NOM);
                cmd.Parameters.AddWithValue("COD_DESCARGA", COD_DESCARGA);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();
        }

        public String REGISTRAR_VISITA(String OBSRV, String EPCRGA,
DateTime FECHA, String LB_EMPRESA)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_VISITA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("EMP_CARGA", EPCRGA);
                cmd.Parameters.AddWithValue("FCHA", FECHA);
                cmd.Parameters.AddWithValue("LAB_EMPRESA", LB_EMPRESA);
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

        public String MODIFICAR_VISITA(Int32 cod,String OBSRV, String EPCRGA,
DateTime FECHA,DateTime HORA, String LB_EMPRESA)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODI_VISITA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", cod);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("EMP_CARGA", EPCRGA);
                cmd.Parameters.AddWithValue("FCHA", FECHA);
                cmd.Parameters.AddWithValue("HOR", HORA);
                cmd.Parameters.AddWithValue("LAB_EMPRESA", LB_EMPRESA);
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

        public String MODIFICAR_DESCARGA(Int32 cod, String OBSRV, String EPCRGA,String bultos,String CANTID,
DateTime FECHA, DateTime HORA, String LB_EMPRESA)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_DESCARGA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", cod);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("EMP_CARGA", EPCRGA);
                cmd.Parameters.AddWithValue("CANT_BULTOS", bultos);
                cmd.Parameters.AddWithValue("CANTI", CANTID);
                cmd.Parameters.AddWithValue("FCHA", FECHA);
                cmd.Parameters.AddWithValue("HOR", HORA);
                cmd.Parameters.AddWithValue("LAB_EMPRESA", LB_EMPRESA);
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

        public String REGISTRAR_DETALLE_VISITA(String NOM, String NDOC, Int32 COD_DESCARGA)
        {
            String msje = "-------";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DET_VISITA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOM", NOM);
                cmd.Parameters.AddWithValue("NDOC", NDOC);
                cmd.Parameters.AddWithValue("COD_DESCARGA", COD_DESCARGA);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();
        }


        public DataTable llenar_descargas_rp(DateTime FECHA)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("Reporte_de_descargas", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("fc", FECHA);
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

        public DataTable llenar_visitas_rp(DateTime FECHA)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("Reporte_de_visitas", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("fc", FECHA);
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



        public DataTable llenar_VISITA(DateTime FECHA)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("CONSULTA_VISITAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA", FECHA);
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
        public DataTable llenar_descarga(DateTime FECHA)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("CONSULTA_DESCARGAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA", FECHA);
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
    }
}
