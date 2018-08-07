using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRERIA
{
   public  class CLSLINEA
    {
        public String RUC;
        public String DIRECCION;
        public static DataTable llenar_LINEAS()
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

        //metodo para cargar la coleccion de datos para el autocomplete
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = llenar_LINEAS();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["descripcion"]));
            }

            return coleccion;
        }
        public DataTable llenar_LINEAS_mantenimiento()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_LINEAS_MANTENIMIENTO", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public String REG_LINEA(string DESCRI, Int32 CODIGOVALOR,string RUC,string DIREC)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERTAR_LINEA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", CODIGOVALOR);
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("RUC_CLI", RUC);
                cmd.Parameters.AddWithValue("DIRC", DIREC);
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


        public String MOD_LINEA(string DESCRI, Int32 CODIGOVALOR, string RUC, string DIREC)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_LINEA", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", CODIGOVALOR);
                cmd.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.Parameters.AddWithValue("RUC_CLI", RUC);
                cmd.Parameters.AddWithValue("DIRC", DIREC);
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


        public String DEVOLVER_RUC_DIRECCION(Int32 VALOR)
        {
            String MSJE="";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DEVOLVER_RUC_DIRECCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("VALOR", VALOR);
                cmd.Parameters.Add("RU", MySqlDbType.VarChar, 11).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("DIRECC", MySqlDbType.VarChar, 45).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                RUC = cmd.Parameters["RU"].Value.ToString();
                DIRECCION = cmd.Parameters["DIRECC"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return MSJE;
            Conexionbd.Desconectar();

        }


        public String ACT_LINEA(Int32 CODIGOLAB, Int32 CODIGOARM)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ACTUALIZAR_LINEA_ARMADOR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGOL", CODIGOLAB);
                cmd.Parameters.AddWithValue("CODIGOA", CODIGOARM);
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

        public String ASIGNAR_LINEA(Int32 CODIGOLAB, Int32 CODIGOARM)
        {
            String MSJE;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ACTUALIZAR_LINEA_ARMADOR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGOL", CODIGOLAB);
                cmd.Parameters.AddWithValue("CODIGOA", CODIGOARM);
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


        public DataTable DEVOLVER_ARMADOR(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_DUEÑO_LINEA", Conexionbd.con);
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

        public DataTable DEVOLVER_LINEAS(Int32 VALOR)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LISTAR_LINEA_DUEÑO", Conexionbd.con);
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