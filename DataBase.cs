using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace course_work
{
    class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=WIN-NJ0D8O83EBV\SQLEXPRESS07;Initial Catalog=course_work;Integrated Security=True");

        public void openConnection() { 
            if(sqlConnection.State == System.Data.ConnectionState.Closed) {
                sqlConnection.Open();
            }
        }

        public void closeConnection() {
            if(sqlConnection.State == System.Data.ConnectionState.Open) {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection() {
            return sqlConnection;
        }
    }
}
