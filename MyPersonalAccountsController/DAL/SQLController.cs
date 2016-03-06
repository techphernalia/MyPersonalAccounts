using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace com.techphernalia.MyPersonalAccounts.Controller.DAL
{
    public class SQLController
    {
        private static SQLController _instance { get; set; }
        private static object obj = "";

        private string _connectionString { get; set; }
        private SqlConnection _sqlConnection { get; set; }

        private SQLController()
        {
            _connectionString = System.Configuration.ConfigurationManager.AppSettings["SQLConnectionString"];
            _sqlConnection = new SqlConnection(this._connectionString);
            _sqlConnection.Open();
        }

        ~SQLController()
        {
            /*if(_sqlConnection.State != System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Dispose();
            }*/
            if(_sqlConnection != null)
            {
                _sqlConnection = null;
            }
        }

        public static SQLController GetInstance()
        {
            if (_instance == null)
            {
                lock (obj)
                {
                    if (_instance == null)
                    {
                        _instance = new SQLController();
                    }
                }
            }
            return _instance;
        }

        public DataSet ExecuteProcedure(string storedProcedure, SqlParameter[] parameters)
        {
            using (SqlCommand cmd = new SqlCommand(storedProcedure, _sqlConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    if (parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                }
                using (SqlDataAdapter DA = new SqlDataAdapter(cmd))
                {
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    return DS;
                }
            }
        }
    }
}
