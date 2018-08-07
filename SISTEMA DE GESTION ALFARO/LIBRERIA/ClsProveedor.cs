using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
namespace LIBRERIA
{
    public class ClsProveedor
    {
        public DataTable llenar_prov()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_PROV_ACT", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
        public DataTable llenar_CAT()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM LLENAR_CAT_PROV", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }


        public DataTable llenar_pv_control_menu()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM llenar_prov_contorl_menu", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }
        public DataTable filtrar_prov(String VALOR)
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("FILTRADO_DE_PROVEDORES", Conexionbd.con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("VALOR", VALOR);
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

        public String REG_PROVEEDOR(string RZ,string RUC,String CTR)
        {
            String MSJE;    
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_PROVEDOR", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("RZ_SOCIAL", RZ);
                cmd.Parameters.AddWithValue("NRUC", RUC);
                cmd.Parameters.AddWithValue("CATE", CTR);
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
