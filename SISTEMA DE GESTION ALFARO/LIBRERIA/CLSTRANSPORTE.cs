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
   public class CLSTRANSPORTE
    {
        public String RUC;
        public String DEVOLVER_RUC(Int32 VALOR)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DEVOLVER_RUC_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("VALOR", VALOR);
                cmd.Parameters.Add("RU", MySqlDbType.VarChar, 11).Direction = ParameterDirection.Output;
                
                cmd.ExecuteNonQuery();
                RUC = cmd.Parameters["RU"].Value.ToString();
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return MSJE;
            Conexionbd.Desconectar();

        }

        public String NUEVO_TRANSPOC(String NOMBRE,String RUC)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("CREAR_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NOMB", NOMBRE);
                cmd.Parameters.AddWithValue("RU",RUC);
                cmd.Parameters.Add("MSJE", MySqlDbType.String, 100).Direction = ParameterDirection.Output;
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

        public String MODIFICAR_TRANSPOC(Int32 COD,String NOMBRE, String RUC,String ESTADO)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICAR_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.AddWithValue("NOMB", NOMBRE);
                cmd.Parameters.AddWithValue("RU", RUC);
                cmd.Parameters.AddWithValue("EST", ESTADO);
                cmd.Parameters.Add("MSJE", MySqlDbType.String, 100).Direction = ParameterDirection.Output;
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


        public String DESACTIVAR_TRANSPOC(Int32 COD)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DESACTIVAR_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.Add("MSJE", MySqlDbType.String, 100).Direction = ParameterDirection.Output;
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


        public String ACTIVAR_TRANSPOC(Int32 COD)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("ACTIVAR_TRANSPORTE", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CODIGO", COD);
                cmd.Parameters.Add("MSJE", MySqlDbType.String, 100).Direction = ParameterDirection.Output;
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

        public DataTable BUSQ_TRANSPORTISTA_RUC(String VALOR)
        {

         
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("DATOS_TRANSPORTE_RUC", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("RU", VALOR);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }


        public DataTable FIL_TRANSPORTISTA_NOMBRE(String VAL)
        {


            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_DE_TRANNSPORTE_X_NOMBRE", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("VALOR", VAL);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }


        public static DataTable llenar_TRANSPORTISTA()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_TRASNPORTISTA", Conexionbd.con);
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
            DataTable dt = llenar_TRANSPORTISTA();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["NOMBRE"]));
            }

            return coleccion;
        }

        public DataTable PERSONAL_SEGUN_TRANSPORTE(int CODTRANSPORTE)
        {


            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("LLENAR_PERS_TRANSP", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("idtrasp", CODTRANSPORTE);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable FILTRAR_PERSONAL_SEGUN_TRANSPORTE(int CODTRANSPORTE,String NOMBRE)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("Filtrar_Personal_trasp", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                
                cmd.SelectCommand.Parameters.AddWithValue("nom", NOMBRE);
                cmd.SelectCommand.Parameters.AddWithValue("idtrasp", CODTRANSPORTE);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }


        public String DEV_PERSONAL_SEGUN_TRANSPORTE_X_LIC(String LI , Int32 CODTRANSPORTE)
        {
            String msje="";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Dev_Personal_trasp_x_dni", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("lic", LI);
                cmd.Parameters.AddWithValue("idtrasp", CODTRANSPORTE);
                cmd.Parameters.Add("msje", MySqlDbType.String, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje = cmd.Parameters["msje"].Value.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return msje;
        }


        public String REGISTRA_PER_TRA(String NOM,String dni,String funcion, Int32 CODTRANSPORTE)
        {
            String msje = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_PERSONAL_SEGUN_TRSP", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", NOM);
                cmd.Parameters.AddWithValue("d_lic", dni);
                cmd.Parameters.AddWithValue("func", funcion);
                cmd.Parameters.AddWithValue("transporte", CODTRANSPORTE);
                cmd.ExecuteNonQuery();
           
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return "ok";
        }

        public String EDITA_PER_TRA(String NOM, String dni, String funcion, Int32 CODTRANSPORTE)
        {
            String msje = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("EDITAR_PERS_TRANSP", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom", NOM);
                cmd.Parameters.AddWithValue("d_lic", dni);
                cmd.Parameters.AddWithValue("func", funcion);
                cmd.Parameters.AddWithValue("transporte", CODTRANSPORTE);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return "ok";
        }
    }
}
