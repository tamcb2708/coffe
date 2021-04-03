using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_sinhvien
{
    class KN
    {
        public static string connecstring = @"Data Source=DESKTOP-ANKGFLN\SQLEXPRESS;Initial Catalog=QL_SINHVIEN1;Integrated Security=True";

        public static DataTable mytable(string str)
        {
            SqlConnection sqlConnection = new SqlConnection(connecstring);
            SqlCommand sqlCommand = new SqlCommand(str, sqlConnection);
            sqlCommand.CommandType = CommandType.Text;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            int i = sqlDataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }


        public static DataTable E_SQL(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecstring))
            {
                using (SqlDataAdapter dad = new SqlDataAdapter(sql, con))
                {
                    using (DataSet dts = new DataSet())
                    {
                        dad.Fill(dts);
                        return dts.Tables[0];
                    }
                }
            }
        }



        public static void ExecuteNonquery_Pro(string sql, params object[] pars)
        {
            using (SqlConnection con = new SqlConnection(connecstring))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    for (int i = 0; i < pars.Length; i += 2)
                    {
                        SqlParameter par = new SqlParameter(pars[i].ToString(), pars[i + 1]);
                        com.Parameters.Add(par);
                    }
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }


        public static void Nonquery(string sql)
        {
            using (SqlConnection con = new SqlConnection(connecstring))
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.ExecuteNonQuery();
                    com.Dispose();
                }
                con.Close();
                con.Dispose();
            }
        }
    }
}
