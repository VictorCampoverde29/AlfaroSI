using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace LIBRERIA
{
   public class Conexionbd
    {
        public static MySqlConnection con = new MySqlConnection("server=132.147.180.13;database=gestion_caja;uid=sistemas;pwd=sistemas");

        public static void Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
    }
}

