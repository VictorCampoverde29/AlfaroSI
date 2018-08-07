using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace LIBRERIA
{
   public class CLSER
    {
        public DataTable llenar_ARMADOR_CORD_PARA_RECLAMOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM CONEXIONES_ACTIVAS", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public DataTable VER_EQUIPOS()
        {
            DataTable dt = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Ver_Equipos_ER", Conexionbd.con);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt;
            Conexionbd.Desconectar();
        }

        public String Registro_Equipos(String nom,String servr,
        String usu ,String  pass ,String est)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Registrar_Equipos_ER", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomb",nom);
                cmd.Parameters.AddWithValue("servr",servr);
                cmd.Parameters.AddWithValue("usu",usu);
                cmd.Parameters.AddWithValue("pass",pass);
                cmd.Parameters.AddWithValue("est", est);
                cmd.Parameters.Add("msje", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["msje"].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return MSJE;
            Conexionbd.Desconectar();
        }

        public String Editar_Equipos(Int32 cod,String nom, String servr,
       String usu, String pass, String est)
        {
            String MSJE = "";
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("Editar_Equipos_ER", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("cod", cod);
                cmd.Parameters.AddWithValue("nomb", nom);
                cmd.Parameters.AddWithValue("servr", servr);
                cmd.Parameters.AddWithValue("usu", usu);
                cmd.Parameters.AddWithValue("pass", pass);
                cmd.Parameters.AddWithValue("est", est);
                cmd.Parameters.Add("msje", MySqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                MSJE = cmd.Parameters["msje"].Value.ToString();
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
