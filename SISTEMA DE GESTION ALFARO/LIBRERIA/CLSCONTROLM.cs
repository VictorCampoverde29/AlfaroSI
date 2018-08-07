using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
   public class CLSCONTROLM
    {
        public String REGISTRAR_MENU(DateTime fec,String descri,int cant,int provedor)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Registra_control", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("fec", fec);
                cmd.Parameters.AddWithValue("descri", descri);
                cmd.Parameters.AddWithValue("cant", cant);
                cmd.Parameters.AddWithValue("provedor", provedor);
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

        public String MODIFICAR_MENU(String descri, int cant, int provedor,int id)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("MODIFICA_MENU", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("control_menu",id);
                cmd.Parameters.AddWithValue("descri", descri);
                cmd.Parameters.AddWithValue("PROV",provedor);
                cmd.Parameters.AddWithValue("CANT", cant);
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
