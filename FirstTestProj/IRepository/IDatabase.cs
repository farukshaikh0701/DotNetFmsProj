using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DotNetFmsProj.IRepository
{
    public interface IDatabase
    {
        string connString { get; }
        SqlConnection GetConnection();
        void AddInParameter(SqlCommand dbCommand, string parameterName, object value);
        void AddInParameter(SqlCommand dbCommand, string parameterName, SqlDbType type, object value);
        void AddInParameter(SqlCommand dbCommand, string parameterName, DbType type, object value);
        void AddOutParameter(SqlCommand dbCommand, string parameterName, int size);
        void AddOutParameter(SqlCommand dbCommand, string parameterName, SqlDbType type, int size);
        void AddOutParameter(SqlCommand dbCommand, string parameterName, DbType type, int size);
        int ExecuteNonQuery(SqlCommand dbCommand);
        Task<int> ExecuteNonQueryAsync(SqlCommand dbCommand);
        Task<DataSet> ExecuteDataSetAsync(SqlCommand dbCommand);
        SqlDataReader ExecuteReader(SqlCommand dbCommand);
        Task<SqlDataReader> ExecuteReaderAsync(SqlCommand dbCommand);
        Task<SqlDataReader> ExecuteReaderAsyncWithtimeOut(SqlCommand dbCommand);
        object ExecuteScalar(SqlCommand dbCommand);
        Task<object> ExecuteScalarAsyncWithTimeout(SqlCommand dbCommand);
        Task<object> ExecuteScalarAsync(SqlCommand dbCommand);
        object GetParameterValue(SqlCommand dbCommand, string parameterName);
        SqlCommand GetStoredProcCommand(string spName);
        string ValidateParameterName(string parameterName);
        DataTable ExecuteDataTable(SqlCommand dbCommand);
        Task<DataTable> ExecuteDataTableAsync(SqlCommand dbCommand);


        Task<int> ExecuteNonQueryWithTransAsync(SqlCommand dbCommand);
        Task<object> ExecuteScalarWithTransAsync(SqlCommand dbCommand);
    }
}