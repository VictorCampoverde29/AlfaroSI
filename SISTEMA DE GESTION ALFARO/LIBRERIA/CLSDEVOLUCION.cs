using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class CLSDEVOLUCION
    {
        public String Devolver_numero(String USUARIO, String PC)
        {
            String NUMERO = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("DEVOLVER_NUMERO_GUIA_S", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("USU", USUARIO);
                cmd.Parameters.AddWithValue("COMPU", PC);
                cmd.Parameters.Add("NUM", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                NUMERO = cmd.Parameters["NUM"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return NUMERO;
        }

        public String ANULAR_GUIA(Int32 VALOR, String MOTIVO)
        {
            String MSJE = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("ANULAR_GUIAS_DEVOLUCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.Parameters.AddWithValue("MOTI", MOTIVO);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return MSJE;
        }


        public String ANULAR_GUIA_SISTEMAS(Int32 VALOR)
        {
            String MSJE = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_DEVOLUCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", VALOR);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return MSJE;
        }



        public String ELIMINAR_ITEM(Int32 VALOR)
        {
            String MSJE = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_DETALLE_GUIA_DEVOLUCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", VALOR);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return MSJE;
        }


        public String TRASLADO_GUIA(Int32 VALOR, DateTime FECHA_TR)
        {
            String MSJE = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("TRASLADO_GUIA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.Parameters.AddWithValue("FT", FECHA_TR);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return MSJE;
        }

        public Int32 REGISTRO_DETALLE(String Codigo,String unidad, String DESCRIP,
            String CANTI, String LOTE,String vto, String CTF, String MTF, String MTVM, int COD,String ob)
        {
            int NUMERO = 0;
            try
            {
                Conexionbd.Conectar();
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DETALLE_DEVOLUCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CALF", Codigo);
                cmd.Parameters.AddWithValue("UND", unidad);
                cmd.Parameters.AddWithValue("DESCR", DESCRIP);
                cmd.Parameters.AddWithValue("CANT", CANTI);
                cmd.Parameters.AddWithValue("LTE", LOTE);
                cmd.Parameters.AddWithValue("VT", vto); 
                cmd.Parameters.AddWithValue("CANT_F", CTF); 
                cmd.Parameters.AddWithValue("M_FC", MTF); 
                cmd.Parameters.AddWithValue("M_M", MTVM);
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.AddWithValue("OB", ob);
                cmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return NUMERO;
        }
        public Int32 REGISTRO_DEV(String R_FACT, String R_GUIA, int CODTRAS, int CODLINEA, String CODUSU, String NG, String MOTIVO,DateTime FIG)
        {
            int NUMERO = 0;
            try
            {
                Conexionbd.Conectar();
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DEVOLUCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("RE_FT", R_FACT);
                cmd.Parameters.AddWithValue("RE_GUIA", R_GUIA);
                cmd.Parameters.AddWithValue("idTRANSPORTE", CODTRAS);
                cmd.Parameters.AddWithValue("idLINEA", CODLINEA);
                cmd.Parameters.AddWithValue("USUARIO", CODUSU);
                cmd.Parameters.AddWithValue("NUM_GUIA", NG);
                cmd.Parameters.AddWithValue("MOTI", MOTIVO); 
                cmd.Parameters.Add("ID", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("FECHA_INGRESO_MERCA", FIG); 
                cmd.ExecuteNonQuery();
                NUMERO = Convert.ToInt32(cmd.Parameters["ID"].Value.ToString());
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return NUMERO;
        }

        public Int32 REGISTRO_DEV_AREA_DEV(String R_FACT, String R_GUIA, int CODTRAS, int CODLINEA,
            String CODUSU, String NG, String MOTIVO,string NRZ,String DIR,String RUC,String NT)
        {
            int NUMERO = 0;
            try
            {
                Conexionbd.Conectar();
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DEVOLUCION_PARA_DEVO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("RE_FT", R_FACT);
                cmd.Parameters.AddWithValue("RE_GUIA", R_GUIA);
                cmd.Parameters.AddWithValue("idTRANSPORTE", CODTRAS);
                cmd.Parameters.AddWithValue("idLINEA", CODLINEA);
                cmd.Parameters.AddWithValue("USUARIO", CODUSU);
                cmd.Parameters.AddWithValue("NUM_GUIA", NG);
                cmd.Parameters.AddWithValue("MOTI", MOTIVO);
                cmd.Parameters.AddWithValue("NMBRE_RAZ", NRZ);
                cmd.Parameters.AddWithValue("DIREC", DIR);
                cmd.Parameters.AddWithValue("RUC_GUIA", RUC);
                cmd.Parameters.AddWithValue("NOMBRE_TRANSP", NT);
                cmd.Parameters.Add("ID", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                NUMERO = Convert.ToInt32(cmd.Parameters["ID"].Value.ToString());
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return NUMERO;
        }
        public String EDITAR_DEV(int COD,DateTime FEC,String R_FACT, String R_GUIA,String ESTADO, int CODTRAS, int CODLINEA, String CODUSU, String NG, String MOTIVO,DateTime FIG)
        {
            String MSJE;
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_GUIA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.AddWithValue("FEC", FEC);
                cmd.Parameters.AddWithValue("RE_FT", R_FACT);
                cmd.Parameters.AddWithValue("RE_GUIA", R_GUIA);
                cmd.Parameters.AddWithValue("EST", ESTADO);
                cmd.Parameters.AddWithValue("idTRANSPORTE", CODTRAS);
                cmd.Parameters.AddWithValue("idLINEA", CODLINEA);
                cmd.Parameters.AddWithValue("NUM_GUIA", NG);
                cmd.Parameters.AddWithValue("MOTI", MOTIVO); 
                cmd.Parameters.AddWithValue("FIG", FIG); 
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar,255).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            return MSJE;
        }

        public DataTable REPORTE_DESCARGA_X_NUMERO(String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_NUMERO_DESCARGAR", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("NUMERO", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_BUSQ_X_NUMERO(String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_NUMERO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("NUMERO", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }






        public DataTable REPORTE_BUSQ_X_GUIA(String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_GUIAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("GUIA", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_BUSQ_X_FT(String VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_FT", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FT", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_BUSQ_X_LABORATORIO(Int32 VALOR, DateTime F1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_LABORATORIO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable BUSQUEDAD_GUIAS_X_USUARIO(String USU,Char VALOR, DateTime F1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUSQUEDAD_IMPRESION_GUIAS_USUARIO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("EST", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", F2);
                cmd.SelectCommand.Parameters.AddWithValue("USU", USU);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }


        public DataTable REPORTE_BUSQ_X_ESTADO(Char VALOR, DateTime F1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("EST", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_BUSQ_X_TRASNPORTE(Int32 VALOR, DateTime F1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_TRASNPORTE", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("TRP", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable llenar_Detalles_Modificar(int VALOR)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("LLENAR_DET_PARA_MODIFICAR", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("CODIGO", VALOR);
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
        public DataTable REPORTE_BUSQ_X_FECHA(DateTime F1,DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUS_GUIAS_FECHAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

    }
}
