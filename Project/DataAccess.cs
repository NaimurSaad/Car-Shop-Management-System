using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DataAccess
    {
        public static SqlConnection con = new SqlConnection("Data Source=laptop-t7igi99q;Initial Catalog=ProjectCopy;Integrated Security=True;TrustServerCertificate=True");

        public static DataTable GetQueryData(string query)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            con.Close();

            return dt;
        } 

        public static void ExecuteNonResultQuery(string query)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
