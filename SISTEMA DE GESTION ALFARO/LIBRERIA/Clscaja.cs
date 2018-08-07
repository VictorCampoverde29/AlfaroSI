using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
        public class Clscaja
    {
        public String MODIFICAR_CAJA(Int32 VALOR,String NOMBR,DateTime FEC,String ESTADO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_FECHA_ESTADO_CAJA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", VALOR);
                cmd.Parameters.AddWithValue("NOM", NOMBR);
                cmd.Parameters.AddWithValue("FECHA", FEC);
                cmd.Parameters.AddWithValue("EST", ESTADO);
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
        public String Aperturar_Caja(DateTime FECHA_APERTURA, String ID_USUARIO,
String DESCRIPCION)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("APERTURAR_CAJA_CHICA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("FECHA_APERTURA", FECHA_APERTURA);
                cmd.Parameters.AddWithValue("ID_USUARIO", ID_USUARIO);
                cmd.Parameters.AddWithValue("DESCRIPCION", DESCRIPCION);
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
        public String QUITAR_DET(Int32 VALOR)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("QUITAR_DETALLE_CAJA_CHICA", Conexionbd.con);
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
        public String Registrar_det_cajas(Int32 COD_PROVEDOR, Int32 IDCAJA, String DESCRIPCION,
Char TIPO_DOCU, Decimal MONTO_UTILIZADO, String NUMERO_D)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERTAR_DETALLES", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD_PROVEDOR", COD_PROVEDOR);
                cmd.Parameters.AddWithValue("IDCAJA", IDCAJA);
                cmd.Parameters.AddWithValue("DESCRI", DESCRIPCION);
                cmd.Parameters.AddWithValue("TIPO_DOCU", TIPO_DOCU);
                cmd.Parameters.AddWithValue("MONTO_UTILIZADO", MONTO_UTILIZADO);
                cmd.Parameters.AddWithValue("NUMERO_D", NUMERO_D);
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
        public DataTable Devolver_detalles_caja(int VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("DEVOLVER_DETALLES_SEGUN_COD", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
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
        public DataTable Devolver_cajas_usuario(String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_CAJAS_USUARIOS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public DataTable BUSCAR_CAJAS_MES(Int32 VALOR,Int32 A)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_CAJAS_MES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("AÑO", A); 
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }

        public DataTable BUSCAR_CAJAS_MES_ESTADO(Int32 VALOR,string ESTA,int AÑ)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_CAJAS_MES_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("EST", ESTA);
                cmd.SelectCommand.Parameters.AddWithValue("AÑO", AÑ);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public DataTable VER_GASTO_CAJAS_MES(Int32 VALOR, Int32 AÑ)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REVISAR_CAT_MES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("AÑO", AÑ);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public DataTable VER_GASTO_CAJAS_MES_REPORTE(Int32 VALOR,Int32 AÑ)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REVISAR_CAT_MES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("AÑO", AÑ);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public DataTable BUSCAR_CAJAS(Int32 CODIGO, String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_CAJAS_X_CODIGO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("CODIGO", CODIGO);
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return DT;
            Conexionbd.Desconectar();

        }
        public String LIQUIDAR(Int32 VALOR)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("LIQUIDAR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("VALOR", VALOR);
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
        public String CAMBIAR_ESTADO(Int32 VALOR)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ABRIR_CAJA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("VALOR", VALOR);
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
        public DataTable Devolver_detalle_cajas_id(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_DETALLES_CAJAS_USUARIOS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
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
