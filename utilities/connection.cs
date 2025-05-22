using System.Data;
using System.Data.SqlClient;

namespace utilities
{
    static public class connection  //install package : "System.Data.SqlClient"
    {
        static string databaseName = "databaseName";
        static string serverName = "serverName";
        static string userName = "userName";
        static string Password = "Password";

        static public string constring = $"Data Source={serverName};Initial Catalog ={databaseName}; User ID ={userName}; Password={Password}";
        static SqlConnection PrivateCon;
        static SqlCommand q;
        static SqlDataAdapter adapter;
        static DataTable dt;
        static string sqlCommand = "";

        static connection()
        {
            PrivateCon = new SqlConnection(constring);
            PrivateCon.Open();
        }

        static public void sqlStatment(string sqlCommand)
        {
            q = new SqlCommand(sqlCommand, PrivateCon);
            q.ExecuteNonQuery();
        }

        static public void update(string table, string coulum, string value, int id)
        {
            sqlCommand = "update " + table + " set " + coulum + " = '" + value + "' where ID = " + id;
            q = new SqlCommand(sqlCommand, PrivateCon);
            q.ExecuteNonQuery();
        }

        static public void delete(string table, string IDColumn, int ID)
        {
            sqlCommand = "delete from " + table + " where " + IDColumn + " = " + ID;
            q = new SqlCommand(sqlCommand, PrivateCon);
            q.ExecuteNonQuery();
        }

        static public string sqlReturnValue(string sqlStatment)
        {
            q = new SqlCommand(sqlStatment, PrivateCon);
            string value = Convert.ToString(q.ExecuteScalar());
            return value;
        }

        static public DataTable sqlReturnTable(string sqlStatment)
        {
            dt = new DataTable();
            adapter = new SqlDataAdapter(sqlStatment, PrivateCon);
            adapter.Fill(dt);

            return dt;
        }

        static public string search(string table, string searchItem)
        {
            sqlCommand = "";
            q = new SqlCommand(sqlCommand, PrivateCon);
            string value = Convert.ToString(q.ExecuteScalar());
            return value;
        }
    }
}
