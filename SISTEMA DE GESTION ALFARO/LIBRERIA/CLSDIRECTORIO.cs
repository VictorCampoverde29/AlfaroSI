using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class CLSDIRECTORIO
    {

        public DataTable MOSTRAR_DIRECTORIO_CLIENTES()
        {
            DataTable DT = new DataTable();
            try
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM MOSTRAR_DIRECTORIO_CLIENTES", Conexionbd.con);
                DA.Fill(DT);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable MOSTRAR_DIRECTORIO_CONTACTOS()
        {
            DataTable DT = new DataTable();
            try
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("SELECT * FROM MOSTRAR_DIRECTORIO_CONTACTOS", Conexionbd.con);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable MOSTRAR_DIRECTORIO_CLIENTES_SEGUN_ZONA(String zona)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_SEGUN_ZONA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("ZO", zona);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable BUSQUEDAD_PERSONALIZADA_(String zona)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_SEGUN_ZONA", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("ZO", zona);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable filtrar_DIRECTORIO_CLIENTES(String VALOR, String zona)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_DE_CLIENTES", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
                cmd.SelectCommand.Parameters.AddWithValue("ZO", zona);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DT;
        }
        public DataTable filtrar_DIRECTORIO_Contactos(String VALOR)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_DE_CONTACTOS", Conexionbd.con);
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
        }


        public DataTable filtrar_DIRECTORIO_CLIENTES_X_NOMBRE(String VALOR)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_DE_CLIENTES_X_NOMBRE", Conexionbd.con);
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
        }

        public DataTable filtrar_DIRECTORIO_CONTACTOS_X_EMPRESA(String VALOR)
        {
            DataTable DT = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_DE_CONTACTOS_X_EMPRESA", Conexionbd.con);
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
        }

        public String REGISTRAR_CLIENTE(String ZNA,String NOMBRE,String CORREO, String TELEFONO,String OBSRV, String CLASI)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DIRECTORIO_CLIENTES", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ZNA", ZNA);
                cmd.Parameters.AddWithValue("NMBRE", NOMBRE);
                cmd.Parameters.AddWithValue("EML", CORREO);
                cmd.Parameters.AddWithValue("TELE", TELEFONO);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("CLASF", CLASI);
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

        public String REGISTRAR_CONTACTO( String NOMBRE, String CORREO, String TELEFONO, String OBSRV, String CLASI)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_DIRECTORIO_CONTACTOS", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NMBRE", NOMBRE);
                cmd.Parameters.AddWithValue("EML", CORREO);
                cmd.Parameters.AddWithValue("TELE", TELEFONO);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("CLASF", CLASI);
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


        public String MODIFICAR_CLIENTE(Int32 ID, String ZNA, String NOMBRE, String CORREO, String TELEFONO,Int32 ESTADO, String OBSRV, String CLASI)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_DIRECTORIO_CLIENTES", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", ID);
                cmd.Parameters.AddWithValue("ZNA", ZNA);
                cmd.Parameters.AddWithValue("NMBRE", NOMBRE);
                cmd.Parameters.AddWithValue("EML", CORREO);
                cmd.Parameters.AddWithValue("TELE", TELEFONO);
                cmd.Parameters.AddWithValue("ESTE", ESTADO);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("CLASF", CLASI);
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
        public String MODIFICAR_CONTACTOS(Int32 ID,  String NOMBRE, String CORREO, String TELEFONO, Int32 ESTADO, String OBSRV, String CLASI)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_DIRECTORIO_CONTACTOS", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", ID);
                cmd.Parameters.AddWithValue("NMBRE", NOMBRE);
                cmd.Parameters.AddWithValue("EML", CORREO);
                cmd.Parameters.AddWithValue("TELE", TELEFONO);
                cmd.Parameters.AddWithValue("ESTE", ESTADO);
                cmd.Parameters.AddWithValue("OBS", OBSRV);
                cmd.Parameters.AddWithValue("CLASF", CLASI);
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
