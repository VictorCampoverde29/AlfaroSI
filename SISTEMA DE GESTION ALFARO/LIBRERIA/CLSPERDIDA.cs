using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
  public class CLSPERDIDA
    {
        public DataTable DEVOLVER_ARMADOR(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVOLVER_PERDIDAS_TRABAJADOR", Conexionbd.con);
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

        public DataTable DEVOLVER_ARMADOR_ESTADO(Int32 VALOR,char ESTADO)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVOLVER_PERDIDAS_TRABAJADOR_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("ESTADO_I", ESTADO);
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
        public DataTable DEVOLVER_ARMADOR_PER_MES(String VALOR,Int32 MES)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVOLVER_PERDIDAS_TRABAJADOR_MES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("MES", MES);
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

        public DataTable CONSULT_ARMADOR_FECHA_ESTADO(String VALOR,Char est,DateTime F1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("CONSULTA_PERDIDAS_TRABAJADOR_FECHAS", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("ESTA", est);
                cmd.SelectCommand.Parameters.AddWithValue("F1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("F2", F2);

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
        public DataTable DEVOLVER_ARMADOR_FACT(Char VALOR,DateTime DEL,DateTime AL)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVOLVER_PERDIDAS_TRABAJADOR_FACT", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("EST", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("DEL", DEL);
                cmd.SelectCommand.Parameters.AddWithValue("AL", AL);


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
    
        public String QUITAR_DETALLES(Int32 VALOR)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("QUITAR_DETALLE_PERDIDA", Conexionbd.con);
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


        public String MODIFICAR_PERDIDA(int COD,DateTime F_GEST,Char EST, String ALFA, String DESCRI, String LTE, DateTime VTO,
   String AR, int CANT, String MOTI, String OBSV)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Modificar_Perdida", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", COD);
                cmd.Parameters.AddWithValue("F_GEST", F_GEST);
                cmd.Parameters.AddWithValue("EST", EST);
                cmd.Parameters.AddWithValue("ALFA", ALFA);
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("LTE", LTE);
                cmd.Parameters.AddWithValue("VTO", VTO);
                cmd.Parameters.AddWithValue("AR", AR);
                cmd.Parameters.AddWithValue("CANT", CANT);
                cmd.Parameters.AddWithValue("MOTI", MOTI);
                cmd.Parameters.AddWithValue("OBSV", OBSV);
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

        public String REGISTRAR_PERDIDA(DateTime F_GEST, String ALFA,String  DESCRI,String LTE ,DateTime VTO,
        String AR ,int CANT,String MOTI ,String OBSV)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("FORMALIZAR_PERDIDA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("F_GEST", F_GEST);
            cmd.Parameters.AddWithValue("ALFA", ALFA);
            cmd.Parameters.AddWithValue("DESCRI", DESCRI);
            cmd.Parameters.AddWithValue("LTE", LTE);
            cmd.Parameters.AddWithValue("VTO", VTO);
            cmd.Parameters.AddWithValue("AR", AR);
            cmd.Parameters.AddWithValue("CANT", CANT);
            cmd.Parameters.AddWithValue("MOTI", MOTI);
            cmd.Parameters.AddWithValue("OBSV", OBSV);
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
        public String ELIMINAR(Int32 VALOR)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_PERDIDA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", VALOR);
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

        public String FACTURAR()
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("FACTURAR_PERDIDA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
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

      


        public String FACTURAR_TOTAL_PERDIDA(Int32 VALOR)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("CAMBIAR_TOTAL_PERDIDAS", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID_PERDIDA", VALOR);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje =cmd.Parameters["MSJE"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
            Conexionbd.Desconectar();


        }

        public DataTable Devolver_detalles_PERDIDA(int VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("DEVOLVER_DETLL_PERDIDA", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("CODI", VALOR);
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

        public DataTable Devolver_detalles_PERDIDA_FACT(int VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("DEVOLVER_DETALLES_PERDIDA_FACT", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("CODI", VALOR);
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

        public String Registrar_det_PERDIDA(int CODPERDIDA_PRODUCTO ,String DESCRI ,String  DN)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERTAR_DETALLES_PERDIDA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODPERDIDA_PRODUCTO", CODPERDIDA_PRODUCTO);
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("DN", DN);
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


        public String ELIMINAR_DETALLE_PERDIDA(int CODPERDIDA_PRODUCTO, String DESCRI, String DN)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_DETALLE_PERDIDA_X_COD_DNI_NOMBRE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODP", CODPERDIDA_PRODUCTO);
                cmd.Parameters.AddWithValue("NOMB", DESCRI);
                cmd.Parameters.AddWithValue("DN", DN);
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
