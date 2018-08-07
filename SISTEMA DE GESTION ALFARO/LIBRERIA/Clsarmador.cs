using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
    public class Clsarmador
    {
        public DataTable llenar_ARMADOR()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_ARMADOR_ACTIVO", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public DataTable llenar_ARMADOR_CORD_PARA_RECLAMOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ver_solo_armadores", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }


        public DataTable llenar_ARMADOR_TODOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_AMADOR_TODOS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
        public String ASIGNAR_LINEA(Int32 IDARMADOR, String IDLINEA,
String DESCRIPCION)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERTAR_ARMADOR_LINEA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODARMADOR", IDARMADOR);
                cmd.Parameters.AddWithValue("CODLINEA", IDLINEA);
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

        public String REG_ARMADOR(string NOMBRE, string DNI,String CARGO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERTAR_ARMADOR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOMBREA", NOMBRE);
                cmd.Parameters.AddWithValue("DNI_T", DNI); 
                    cmd.Parameters.AddWithValue("CARGOT", CARGO); 
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


        public String MODIFICAR_ARMADOR(int COD,string NOMBRE, string DNI, String CARGO,int ESTADO)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_TRABAJADOR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.AddWithValue("NOMB", NOMBRE);
                cmd.Parameters.AddWithValue("DN", DNI);
                cmd.Parameters.AddWithValue("EST", ESTADO);
                cmd.Parameters.AddWithValue("CARG", CARGO);
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
    }
  }
