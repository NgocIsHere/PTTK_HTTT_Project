using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_winform.DAO
{
    public class DataProvider
    {
        private static DataProvider _instance;
        
        public static DataProvider Instance
        {
            get { if (_instance == null) _instance = new DataProvider(); return DataProvider._instance; }
            private set { DataProvider._instance = value; }
        }
        private DataProvider() { }

        private string _connectionString = @$"DATA SOURCE = localhost:1521/XEPDB1; USER ID=" + "QLHSUT" + ";PASSWORD=" + "123456";

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();

            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        string[] listParam = query.Split(' ');
                        int i = 0;
                        foreach (string item in listParam)
                        {
                            if (item.Contains(':'))
                            {
                                command.Parameters.Add(new OracleParameter(item, parameters[i]));
                                i++;
                            }
                        }
                    }

                    try
                    {
                        connection.Open();
                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        adapter.Fill(data);
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions or log errors
                        Console.WriteLine($"Error executing query: {ex.Message}");
                    }
                }
            }

            return data;
        }
        public void ExecuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(_connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            string[] listParam = query.Split(' ');
                            int i = 0;
                            foreach (string item in listParam)
                            {
                                if (item.Contains(':'))
                                {
                                    command.Parameters.Add(new OracleParameter(item, parameter[i]));
                                    i++;
                                }
                            }
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query", ex);
            }
        }
    }
}
