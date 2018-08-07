using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace LIBRERIA
{
   public class Modulos
    {
        public DataTable llenar_TODOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_TODO_LOS_MODULOS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public DataTable llenar() {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_MODULOS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public DataTable llenar_configuracion_modulos()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_CONFIG_MODULOS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public string CREAR_MODULO(String DESCRIPC, int ESTADO)
        {
            string MSJE;
            try
            {
                MySqlCommand cmd = new MySqlCommand("NUEVO_MODULO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOM", DESCRIPC);
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


        public string MODIFICAR_MODULO(String DESCRIPC, int CODIGOMODULO, int ESTADO)
        {
            string MSJE;
            try
            {
                MySqlCommand cmd = new MySqlCommand("EDITAR_MODULO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", CODIGOMODULO);
                cmd.Parameters.AddWithValue("NOM", DESCRIPC);
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


        public string MODIFICAR_ESTADO(String CODIGOUSUARIO,int CODIGOMODULO,int ESTADO)
        {
            string MSJE;
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_ACCESOS", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODMOD", CODIGOMODULO);
                cmd.Parameters.AddWithValue("CODUSUA", CODIGOUSUARIO);
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



        public string DAR_ACCESO(String CODIGOUSUARIO, int CODIGOMODULO)
        {
            string MSJE;
            try
            {
                MySqlCommand cmd = new MySqlCommand("NUEVO_ACCESO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODMOD", CODIGOMODULO);
                cmd.Parameters.AddWithValue("CODUSUA", CODIGOUSUARIO);
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

        public DataTable llenar_configuracion_modulos_x_seleccion(int ID)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("LLENAR_MODULOS_X_SELECCION", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("COD", ID);
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
    }
}
