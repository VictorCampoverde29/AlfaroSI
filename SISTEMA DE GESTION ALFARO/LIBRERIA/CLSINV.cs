using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
  public  class CLSINV
    {

        public DataTable VER_PROD_INVENTARIO_ST(Int32 MODI,String VALOR,Int32 IDINV)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VISTA_PROD_DEL_INV_SIST", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("MODIFICADOR", MODI);
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("ID_INV", IDINV);
               
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable VER_INVENTARIOS_SEGUN_FECHA(DateTime f1, DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_INVENTARIOS_X_RANGO", Conexionbd.con);
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
        public String NUEVO_SOBRANTE(String CODALF, String NOMBR,
           String LOTE, Int32 LINEA, Int32 CANTID, DateTime FVTO, String USUARIO, Int32 COD_INVE)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_SOBRANTE_AL_INVENTARIO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod_alf", CODALF);
                cmd.Parameters.AddWithValue("nombre_producto", NOMBR);
                cmd.Parameters.AddWithValue("lte", LOTE);
                cmd.Parameters.AddWithValue("cod_linea", LINEA);
                cmd.Parameters.AddWithValue("cant", CANTID);
                cmd.Parameters.AddWithValue("vto", FVTO);
                cmd.Parameters.AddWithValue("usuario", USUARIO);
                cmd.Parameters.AddWithValue("inventario", COD_INVE);
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

        public String ELIMINA_PROD_INV_ST(Int32 COD)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINA_DET_INV_ST", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
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
        public String NUEVO_INV( String NOMBR, String USUARIO,DateTime DEL,DateTime AL,String TIPO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_INVENTARIO_NUEVO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", NOMBR);
                cmd.Parameters.AddWithValue("usuario", USUARIO);
                cmd.Parameters.AddWithValue("f_ini", DEL);
                cmd.Parameters.AddWithValue("f_fin", AL);
                cmd.Parameters.AddWithValue("tip", TIPO);
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


        public String NUEVO_PROD_SISTEMAS
            (String NOMBR, int CANT,String CATEGORIA,String MARCA,String SERIE,String COMENTARIOS,
            String ESTADO,int AREA,int INV)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_PROD_INVENTARIO_SIST", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre_producto", NOMBR);
                cmd.Parameters.AddWithValue("cant", CANT);
                cmd.Parameters.AddWithValue("CAT", CATEGORIA);
                cmd.Parameters.AddWithValue("MARC",MARCA);
                cmd.Parameters.AddWithValue("SER", SERIE);
                cmd.Parameters.AddWithValue("COMEN", COMENTARIOS);
                cmd.Parameters.AddWithValue("ESTP", ESTADO);
                cmd.Parameters.AddWithValue("AREA", AREA);
                cmd.Parameters.AddWithValue("inventario", INV);
               
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
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

        public String MODIFICAR_INV(Int32 COD,String NOMBR, String ESTADO, DateTime DEL, DateTime AL)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_INVENTARIO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD_INV",COD );
                cmd.Parameters.AddWithValue("DES", NOMBR);
                cmd.Parameters.AddWithValue("APT", DEL);
                cmd.Parameters.AddWithValue("CIERRE", AL);
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


        public String REGULARIZAR_SOBRANTE(Int32 COD, String TEXTO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGULARIZAR_SOBRANTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NUM", COD);
                cmd.Parameters.AddWithValue("OBSERV", TEXTO);
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

        public String REGULARIZAR_TODOS(Int32 COD,String TEXTO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGULARIZAR_SOBRANTE_X_COD_INV", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NUM", COD);
                cmd.Parameters.AddWithValue("OBSERV", TEXTO);
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


        public String ELIMINAR_SOBRANTE(Int32 COD)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ELIMINAR_SOBRANTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", COD);
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
        public DataTable llenar_INVENTARIOS_ACTIVOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM VER_INVENTARIOS_ACTIVOS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

      
        public DataTable LLENAR_AREAS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM VER_AREAS_ACTIVAS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
        public DataTable llenar_INVENTARIOS_ACTIVOS_SISTEMAS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM VER_INVENTARIOS_ACTIVOS_SISTEMAS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public DataTable Devolver_SOBRANTES_INV_ESTADO_LINEA(Int32 CLINEA,Int32 CODINV,String ESTADO)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_SOBRANTES_POR_LINEA_X_ESTADO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("CODLINEA", CLINEA);
                cmd.SelectCommand.Parameters.AddWithValue("COD_INVE", CODINV);
                cmd.SelectCommand.Parameters.AddWithValue("EST", ESTADO);
                
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


        public DataTable Devolver_datos_inv_x_cod(Int32 CODINV)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_DATOS_DE_INV_X_COD", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", CODINV);
             

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


        public DataTable Devolver_detalles_inv_x_cod(Int32 CODINV)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_DET_INV", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", CODINV);
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
        public DataTable llenar_LINEAS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_LINEAS", Conexionbd.con);
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
