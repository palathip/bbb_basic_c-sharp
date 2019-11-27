using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BAPI.Model
{
    public class Database
    {
        private string connectionString = "datasource=203.154.58.128;" +
                                          "port=3306;" +
                                          "username=trainCSharp;" +
                                          "password=ogs@Cpass;" +
                                          "database=traingCSharp";

        public DataTable QueryDB(string queryString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(queryString, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                dataTable.Load(dataReader);
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

            return dataTable;
        }

        public void ExecuteDB(string queryString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }


}

