using Microsoft.Data.SqlClient;
namespace FirstMVCApp.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()// connection factory(method we create is factory)
        {
            var connString = @"server=200411LTP2745\SQLEXPRESS;database=testdb;
                                integrated security=true;Encrypt=false;";

            SqlConnection sqlcn=new SqlConnection(connString);
            return sqlcn;
        }
    }
}
