using MySql.Data.MySqlClient;
using System;

using System.Data;


namespace LIBRERIA
{
    public class ClsInspeccion
    {
        public DataTable VER_INSPECCION_X_CATEG(String TIPO ,DateTime F1 , DateTime F2)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_INSPECCION_X_CATEG", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("TIPO", TIPO);
                cmd.SelectCommand.Parameters.AddWithValue("F1", F1);
                cmd.SelectCommand.Parameters.AddWithValue("F2", F2);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable FILTRADO_PRODUCTOS(String DESCRI,String cat)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("FILTRADO_INSPEC", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("DESCRI", DESCRI);
                cmd.SelectCommand.Parameters.AddWithValue("CAT", cat);

                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public DataTable VER_REPORTE_X_INSPECCION(int COD)
        {
            DataTable DT = new DataTable();
            Conexionbd.Conectar();
            try
            {
                MySqlDataAdapter cmd = new MySqlDataAdapter("VER_REPORTE_X_INSPECCION", Conexionbd.con);
                cmd.SelectCommand.CommandType = CommandType.StoredProcedure;
                cmd.SelectCommand.Parameters.AddWithValue("COD", COD);
                cmd.SelectCommand.ExecuteNonQuery();
                cmd.Fill(DT);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return DT;
        }

        public String EDITAR_INSPECCION(int COD , 
        DateTime F_CHA ,String PRODUCTO ,int CANT ,String F_PRESENTACION , String FACTURA ,
   String GUIA , String PROVEEDOR, String CONCENTRACION , String LOTE ,
   DateTime VCTO , String REG_SANITARIO ,int CANTIDAD , int CANTIDAD_SOLI ,   int CANT_MUESTREADA, 
   String CONDAL,String CONDALREC, String OBS)
        {
            String msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("EDITAR_INSP", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("COD", COD);
                cmd.Parameters.AddWithValue("F_CHA", F_CHA);
                cmd.Parameters.AddWithValue("PRODUCTO", PRODUCTO);
                cmd.Parameters.AddWithValue("CANT", CANT);
                cmd.Parameters.AddWithValue("F_PRESENTACION", F_PRESENTACION);
                cmd.Parameters.AddWithValue("FACTURA", FACTURA);
                cmd.Parameters.AddWithValue("GUIA", GUIA);
                cmd.Parameters.AddWithValue("PROVEEDOR", PROVEEDOR);
                cmd.Parameters.AddWithValue("CONCENTRACION", CONCENTRACION);
                cmd.Parameters.AddWithValue("LOTE", LOTE);
                cmd.Parameters.AddWithValue("VCTO", VCTO);
                cmd.Parameters.AddWithValue("REG_SANITARIO", REG_SANITARIO);
                cmd.Parameters.AddWithValue("CANTIDAD", CANTIDAD);
                cmd.Parameters.AddWithValue("CANTIDAD_SOLI", CANTIDAD_SOLI);
                cmd.Parameters.AddWithValue("CANT_MUESTREADA", CANT_MUESTREADA);
                cmd.Parameters.AddWithValue("CONDAL", CONDAL);
                cmd.Parameters.AddWithValue("CONDAL_REC", CONDALREC);
                cmd.Parameters.AddWithValue("OBS", OBS);
                cmd.Parameters.Add("MSJE", MySqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje =cmd.Parameters["MSJE"].Value.ToString();
                Conexionbd.Desconectar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;

        }

        public Int32 REGISTRAR_NUEVA_INSPECCION(String nombre_pro ,int cant ,String forma ,String factura ,
String guia,String provee, String concen , String lte ,DateTime vcto , String reg_san ,int cant_muest,int cant_solic,
String TIP,DateTime FECH,String CONDAL,String CONDAL_REC, String OBS)
        {
            int msje;
            Conexionbd.Conectar();
            try
            {
                MySqlCommand cmd = new MySqlCommand("REGISTRAR_NUEVA_INSPECCION", Conexionbd.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nombre_pro", nombre_pro);
                cmd.Parameters.AddWithValue("cant", cant);
                cmd.Parameters.AddWithValue("forma", forma);
                cmd.Parameters.AddWithValue("factura", factura);
                cmd.Parameters.AddWithValue("guia", guia);
                cmd.Parameters.AddWithValue("provee", provee);
                cmd.Parameters.AddWithValue("concen", concen);
                cmd.Parameters.AddWithValue("lte", lte);
                cmd.Parameters.AddWithValue("vcto", vcto);
                cmd.Parameters.AddWithValue("reg_san", reg_san);
                cmd.Parameters.AddWithValue("cant_solic", cant_solic);
                cmd.Parameters.AddWithValue("cant_muest", cant_muest);
                cmd.Parameters.AddWithValue("TIP", TIP);
                cmd.Parameters.AddWithValue("FECH", FECH);
                cmd.Parameters.AddWithValue("CONDAL", CONDAL);
                cmd.Parameters.AddWithValue("CONDAL_REC", CONDAL_REC);
                cmd.Parameters.AddWithValue("OBSE", OBS);
                cmd.Parameters.Add("CODULTI", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                msje =Convert.ToInt32( cmd.Parameters["CODULTI"].Value);
                Conexionbd.Desconectar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return msje;
           
        }
    }
}
