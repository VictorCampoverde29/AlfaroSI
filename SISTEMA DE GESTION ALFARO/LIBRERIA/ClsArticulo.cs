using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
  public class ClsArticulo
    {
        public DataTable datos;
        public String Devuelve_Datos_Por_Cod(char tipo,String busq)
        {
            String msj = "no hay";
            MySqlDataReader reader;
            try
            {
                Conexionbd.Conectar();
                MySqlCommand cmd = new MySqlCommand("DEVUELVE_PRODUCTO", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TIPOBUSQ",tipo);
                cmd.Parameters.AddWithValue("DATOBUS",busq);
                reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        msj = reader.GetValue(0).ToString() + '|' + reader.GetValue(1).ToString();
                    }
                Conexionbd.Desconectar();
                return msj;
               
            }
            catch (Exception ex)
            {
                 throw ex;
            }
           
        }

        public DataTable Devuelve_Datos_Por_Nombre(char tipo, String busq)
        {
            DataTable dt = new DataTable();
            try
            {
                Conexionbd.Conectar();
                MySqlDataAdapter cmd = new MySqlDataAdapter("DEVUELVE_PRODUCTO", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("TIPOBUSQ", tipo);
                cmd.SelectCommand.Parameters.AddWithValue("DATOBUS", busq);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(dt);
                Conexionbd.Desconectar();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
