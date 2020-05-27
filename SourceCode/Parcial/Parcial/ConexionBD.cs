using System.Data;
using Npgsql;

namespace Parcial
{
    public class ConexionBD
    {
        public static string CadenaConexion =
            "Server=localhost;Port=5432;User Id=postgres;Password=np300f;Database=parcial;";
        
        //-----------------------EJECTUTANDO CONSULTA TIPO SELECT---------------------------------
        public static DataTable realizarConsulta(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion);
            DataSet ds = new DataSet();
            
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }
        //-------------------CONSULTA QUE NO SEA SELECT --------------------------------------
        //-----------------------EJECUTAR NONQUERY--------------------------------
        public static void realizarAccion(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CadenaConexion); 
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }   
    }
}