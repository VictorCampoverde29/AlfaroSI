using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LIBRERIA
{
    public class CLSREPORTES
    {
        public DataTable REPORTE_GENERADO()
        {
            DataTable Datos = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM REPORTE_VALORADO", Conexionbd.con);
                da.Fill(Datos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Datos;
        }
        public DataTable REPORTE_GENERADO2()
        {
            DataTable Datos = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM reporte_valorado2", Conexionbd.con);
                da.Fill(Datos);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return Datos;
        }

        public DataTable REPORTE_SOBRANTES_INVENTARIOS()
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ver_sobrantes", Conexionbd.con);
                da.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }
        public DataTable RP_COMPARA_CAJAS()
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM REPORTE_COMPARA_CAJAS", Conexionbd.con);
                da.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable REPORTE_CARGO_X_CODPERDIDA(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_CARGO_DET", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_DETALLE_CARGO_X_CODPERDIDA(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_DETALLES_X_CODIGO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_SOBRANTES_X_CODIGO(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_SOBRANTES_SEGUN_COD", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("NUM", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }
        public DataTable REPORTE_MES_X_CATEGORIA(Int32 VALOR,Int32 año)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_X_CATEGORIA_X_MES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("AÑO", año);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REP_FORMATO_TRANSPORTISTA(DateTime FECHA)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_FORMATO_TRANSPORTISTA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FEC", FECHA);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

      
        public DataTable REPORTE_ACTIVIDADES_TERMINADAS_X_FECHA(DateTime f1,DateTime f2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_FORMATO_TRANSPORTISTA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("F1", f1);
                cmd.SelectCommand.Parameters.AddWithValue("F2", f2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable TORTA(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("TORTA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable VER_MEMO(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_MEMO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable IMPR_GUIA_D(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("IMPRESION_GUIAS_DEVO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable IMPR_GUIA_DEVOL_AREA_DEVOL(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("IMPRESION_GUIAS_DEVOLUCION_DEVOLUCIONES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
                Conexionbd.Desconectar();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }
        public DataTable IMPR_GUIA_DEVOL_DETALLES(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("IMPRESION_GUIAS_DEVOLUCION_DETALLES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }


       

        public DataTable IMPR_GUIA_DEVOL_DETALLES_AREA_DEVOLUCION(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("IMPRESION_GUIAS_DEVOLUCION_DETALLES_DEVO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD_DEVOL", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_LL_RANGO(DateTime f1,DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_LLAMADAS_VENTA_X_RANGO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FECHA1", f1);
                cmd.SelectCommand.Parameters.AddWithValue("FECHA2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_COMIDA_RANGO(DateTime f1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_COMIDA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("DEL", f1);
                cmd.SelectCommand.Parameters.AddWithValue("AL", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }
        public DataTable REPORTE_COMIDA_RANGO_MODIFICAR(DateTime f1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_MENU_MODIFICAR", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("DEL", f1);
                cmd.SelectCommand.Parameters.AddWithValue("AL", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }
        public DataTable REPORTE_ESTADOS_FECHA(Char ESTADO,DateTime f1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_GUIAS_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
               
                cmd.SelectCommand.Parameters.AddWithValue("EST", ESTADO);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", f1);
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

        public DataTable REPORTE_TRANSLADADAS_FECHA(DateTime f1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_GUIAS_TRANSLADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", f1);
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

        public DataTable LISTAR_DETALLES_CAJAS_USUARIOS(Int32 VALOR)
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
                ex.ToString();
            }
            return DT;
        }

        public DataTable REPORTE_LLAMADAS_X_FECHA(DateTime VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_LLAMADAS_X_FECHA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FECHA", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }

        public DataTable LLAMADAS_FECHA(DateTime FECHA)
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
        public DataTable REPORTE_VENTAS_LLAMADAS_X_FECHA (DateTime FECH)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_LLAMADAS_VENTA_X_FECHA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FECHA", FECH);
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

        public DataTable REPORTE_CONSULTA_LLAMADAS_X_FECHA_TK(String VALOR,DateTime FECH)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("REPORTE_CONSULTA_LLAMADAS_X_FEHCA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("FECH", FECH);
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

        public DataTable REPORTES_RECLAMOS_HISTORIAL( DateTime DEL,DateTime AL,String EST)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_REPORTE_RECLAMOS_FECHAS_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("DEL", DEL );
                cmd.SelectCommand.Parameters.AddWithValue("AL", AL);
                cmd.SelectCommand.Parameters.AddWithValue("EST", EST);
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

        

         public DataTable VER_ACTAS_ASEG_FECHA(DateTime DEL, DateTime AL)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_ACTAS_X_FECHAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", DEL);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", AL);
                
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
        public DataTable BUSQUEDAD_ACTAS_X_FECHA_X_LAB(DateTime DEL, DateTime AL, int LAB)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUSQUEDAD_ACTAS_X_FECHA_LAB", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", DEL);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", AL);
                cmd.SelectCommand.Parameters.AddWithValue("LAB", LAB);
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


        public DataTable BUSQUEDAD_ACTAS_X_FECHA(DateTime DEL, DateTime AL)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("BUSQUEDAD_ACTAS_X_FECHA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("FCHA1", DEL);
                cmd.SelectCommand.Parameters.AddWithValue("FCHA2", AL);             
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

        public DataTable ACTAS_X_COD_DEV( int COD)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("ACTAS_X_COD_DEVOL", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", COD);
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

        public DataTable DET_ACTAS_X_COD_DEV(int COD)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DETALLES_ACTA_X_COD", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", COD);
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
