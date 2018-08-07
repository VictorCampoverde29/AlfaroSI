using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA
{
  public  class CLSDV
    {
        public Int32 DEVOLVER_NUMERO()
        {
            Int32 NMRO;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("NUMERO_DV", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NUMERO", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                NMRO =Convert.ToInt32(cmd.Parameters["NUMERO"].Value);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return NMRO;
            Conexionbd.Desconectar();

        }
    }
}
