using DotNetFmsProj.IRepository;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DotNetFmsProj.Repository
{
    public abstract class BaseDatabase : IDatabase
    {
        #region Declarations

        public virtual string connString { get; }

        #endregion

        #region Private/Protected Methods

        protected SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;

        }

        private async Task<SqlConnection> CreateConnectionAsync()
        {
            SqlConnection conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
            {
                await conn.OpenAsync();
            }
            return conn;
        }

        #endregion

        #region Public Methods

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connString);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public SqlCommand GetStoredProcCommand(string spName)
        {
            SqlCommand cmd = new SqlCommand(spName);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public void AddInParameter(SqlCommand dbCommand, string parameterName, object value)
        {
            parameterName = ValidateParameterName(parameterName);
            dbCommand.Parameters.AddWithValue(parameterName, value == null ? DBNull.Value : value);
        }

        public void AddInParameter(SqlCommand dbCommand, string parameterName, DbType type, object value)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = new SqlParameter(parameterName, type);
            param.Direction = ParameterDirection.Input;
            param.Value = value == null ? DBNull.Value : value;
            dbCommand.Parameters.Add(param);
        }

        public void AddInParameter(SqlCommand dbCommand, string parameterName, SqlDbType type, object value)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = new SqlParameter(parameterName, type);
            param.Direction = ParameterDirection.Input;
            param.Value = value == null ? DBNull.Value : value;
            dbCommand.Parameters.Add(param);
        }

        public void AddOutParameter(SqlCommand dbCommand, string parameterName, int size)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = new SqlParameter();
            param.ParameterName = parameterName;
            param.Direction = ParameterDirection.Output;
            param.Size = size;
            dbCommand.Parameters.Add(param);
        }

        public void AddOutParameter(SqlCommand dbCommand, string parameterName, DbType type, int size)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = new SqlParameter(parameterName, type);
            param.Direction = ParameterDirection.Output;
            param.Size = size;
            dbCommand.Parameters.Add(param);
        }

        public void AddOutParameter(SqlCommand dbCommand, string parameterName, SqlDbType type, int size)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = new SqlParameter(parameterName, type);
            param.Direction = ParameterDirection.Output;
            param.Size = size;
            dbCommand.Parameters.Add(param);
        }

        public object GetParameterValue(SqlCommand dbCommand, string parameterName)
        {
            parameterName = ValidateParameterName(parameterName);
            SqlParameter param = dbCommand.Parameters[parameterName] as SqlParameter;
            return param.Value;
        }

        public int ExecuteNonQuery(SqlCommand dbCommand)
        {
            using (var conn = CreateConnection())
            {
                dbCommand.Connection = conn;
                return dbCommand.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(SqlCommand dbCommand)
        {
            using (var conn = CreateConnection())
            {
                dbCommand.Connection = conn;
                return dbCommand.ExecuteScalar();
            }
        }

        public SqlDataReader ExecuteReader(SqlCommand dbCommand)
        {
            var conn = CreateConnection();
            dbCommand.Connection = conn;
            return dbCommand.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public string ValidateParameterName(string parameterName)
        {
            if (!string.IsNullOrEmpty(parameterName))
            {
                if (!parameterName.Substring(0, 1).Equals("@"))
                {
                    parameterName = "@" + parameterName;
                }
            }
            return parameterName;
        }

        public async Task<SqlDataReader> ExecuteReaderAsync(SqlCommand dbCommand)
        {
            var conn = await CreateConnectionAsync();
            dbCommand.Connection = conn;
            return await dbCommand.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }

        public async Task<SqlDataReader> ExecuteReaderAsyncWithtimeOut(SqlCommand dbCommand)
        {
            var conn = await CreateConnectionAsync();
            dbCommand.Connection = conn;
            dbCommand.CommandTimeout = 500;
            return await dbCommand.ExecuteReaderAsync();
        }

        public async Task<int> ExecuteNonQueryAsync(SqlCommand dbCommand)
        {
            using (var conn = await CreateConnectionAsync())
            {
                dbCommand.Connection = conn;
                return await dbCommand.ExecuteNonQueryAsync();
            }
        }

        public async Task<object> ExecuteScalarAsyncWithTimeout(SqlCommand dbCommand)
        {
            using (var conn = await CreateConnectionAsync())
            {
                dbCommand.Connection = conn;
                dbCommand.CommandTimeout = 500;
                object result = await dbCommand.ExecuteScalarAsync();
                if (result == null || result.Equals(DBNull.Value))
                    return null;
                else
                    return result;
            }
        }

        public async Task<object> ExecuteScalarAsync(SqlCommand dbCommand)
        {
            using (var conn = await CreateConnectionAsync())
            {
                dbCommand.Connection = conn;
                object result = await dbCommand.ExecuteScalarAsync();
                if (result == null || result.Equals(DBNull.Value))
                    return null;
                else
                    return result;
            }
        }

        //public async Task<int> ExecuteNonQueryWithTransAsync(SqlCommand dbCommand)
        //{
        //    SqlTransaction transaction = null;
        //    int i = 0;
        //    using (var conn = await CreateConnectionAsync())
        //    {
        //        try
        //        {
        //            transaction = conn.BeginTransaction();
        //            dbCommand.Connection = conn;
        //            i = await dbCommand.ExecuteNonQueryAsync();
        //            transaction.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            if (transaction != null)
        //                transaction.Rollback();
        //            throw ex;
        //        }
        //        finally
        //        {
        //            if (transaction != null)
        //                transaction.Commit();
        //        }
        //    }
        //    return i;
        //}

        public DataTable ExecuteDataTable(SqlCommand dbCommand)
        {
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var conn = CreateConnection())
                {
                    dbCommand.Connection = conn;
                    dataAdapter = new SqlDataAdapter(dbCommand);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch
            {

            }
            return dataTable;

        }

        public async Task<DataTable> ExecuteDataTableAsync(SqlCommand dbCommand)
        {
            SqlDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var conn = await CreateConnectionAsync())
                {
                    dbCommand.Connection = conn;
                    dataAdapter = new SqlDataAdapter(dbCommand);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch
            {

            }
            return dataTable;
        }

        public DataSet ExecuteDataSet(SqlCommand dbCommand)
        {
            SqlDataAdapter dataAdapter = null;
            DataSet dataSet = new DataSet();
            try
            {
                using (var conn = CreateConnection())
                {
                    dbCommand.Connection = conn;
                    dataAdapter = new SqlDataAdapter(dbCommand);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch
            {

            }
            return dataSet;

        }

        public async Task<DataSet> ExecuteDataSetAsync(SqlCommand dbCommand)
        {
            SqlDataAdapter dataAdapter = null;
            DataSet dataSet = new DataSet();
            try
            {
                using (var conn = await CreateConnectionAsync())
                {
                    dbCommand.Connection = conn;
                    dataAdapter = new SqlDataAdapter(dbCommand);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {

            }
            return dataSet;
        }

        #endregion

        #region With Transaction

        public async Task<int> ExecuteNonQueryWithTransAsync(SqlCommand dbCommand)
        {
            return await dbCommand.ExecuteNonQueryAsync();
        }

        public async Task<object> ExecuteScalarWithTransAsync(SqlCommand dbCommand)
        {
            object result = await dbCommand.ExecuteScalarAsync();
            if (result == null || result.Equals(DBNull.Value))
                return null;
            else
                return result;
        }

        #endregion
    }
}
