using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace HugoAppV2
{
    public static class Conection
    {
        //public static string CadenaConexion = 
        //    "Server=localhost;Port=5432;User Id=postgres;Password=root;Database=bddPedidos;";

        private static string ConnString = 
            "Server=localhost;Port=5432;User Id=postgres;Password=uca;Database=postgres";
        
        public static DataTable QueryDB(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConnString);
            DataSet ds = new DataSet();
            
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();
            
            return ds.Tables[0];
        }

        public static void DoAction(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConnString);
            
            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }
        
        
    }
}