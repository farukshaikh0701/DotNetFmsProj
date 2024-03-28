using DotNetFmsProj.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using DotNetFmsProj.Model;
using System.Data.Common;
using System.Windows.Input;
using System;
using DotNetFmsProj.Shared;

namespace DotNetFmsProj.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly IDefaultDatabase _database;
        IConfiguration _configuration;
        public UserRepository(IConfiguration configuration, IDefaultDatabase database)
        {
            _database = database;
            _configuration = configuration;
        }

        public DataTable GetUserList()
        {
            string query = " Select * from [users] WHERE IsDeleted = 0 ";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("sqlConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();

                }
            }
            return dt;
        }

        public DataTable GetUserDetails(long userId)
        {
            string query = " Select * from [Users] WHERE UserId = @userId ";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("sqlConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@userId", userId);
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();

                }
            }
            return dt;
        }

        public bool ValidateUser(string userName, string password)
        {
            string query = " Select * from [Users] WHERE UserName = @UserName AND Password = @Password";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("sqlConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@UserName", userName);
                    myCommand.Parameters.AddWithValue("@Password", password);
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();

                }
            }
            return true;
        }
        public DataTable GetUser(string userName, string password)
        {
            string sp = "User_Get";// Select * from [Users] WHERE UserName = @UserName AND Password = @Password";
            DataTable ds = new DataTable();
            SqlDataReader myReader;
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_UserName", userName);
                    myCommand.Parameters.AddWithValue("@in_Password", password);
                    //myCommand.ExecuteNonQuery();
                    myReader = myCommand.ExecuteReader();
                    ds.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return ds;
        }


        public DataTable CreateUser(User user)
        {
            string sp = "User_Add";// Select * from [Users] WHERE UserName = @UserName AND Password = @Password";
            DataTable ds = new DataTable();
            SqlDataReader myReader;
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_FirstName", user.FirstName);
                    myCommand.Parameters.AddWithValue("@in_LastName", user.LastName);
                    myCommand.Parameters.AddWithValue("@in_MobileNumber", user.MobileNumber);
                    myCommand.Parameters.AddWithValue("@in_Email", user.Email);
                    myCommand.Parameters.AddWithValue("@in_Address", user.Address);
                    myReader = myCommand.ExecuteReader();
                    ds.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return ds;
        }

        public DataTable VerifyUser(string firstName, string userName, string mobileNumber)
        {
            string sp = "User_Verify";
            DataTable ds = new DataTable();
            SqlDataReader myReader;
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_FirstName", firstName);
                    myCommand.Parameters.AddWithValue("@in_UserName", userName);
                    myCommand.Parameters.AddWithValue("@in_MobileNumber", mobileNumber);
                    myReader = myCommand.ExecuteReader();
                    ds.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return ds;
        }

        public DataTable UpdatePassword(string userName, string password)
        {
            string sp = "UpdatePassword";
            DataTable ds = new DataTable();
            SqlDataReader myReader;
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_UserName", userName);
                    myCommand.Parameters.AddWithValue("@in_Password", password);
                    myReader = myCommand.ExecuteReader();
                    ds.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return ds;
        }

    }
    //public async Task<long> CreateUser(User user)
    //{

    //    var dbCommand = _database.GetStoredProcCommand("User_Add");
    //    _database.AddInParameter(dbCommand, "@in_FirstName", user.FirstName);
    //    _database.AddInParameter(dbCommand, "@in_LastName", user.LastName);
    //    _database.AddInParameter(dbCommand, "@in_MobileNumber", user.MobileNumber);
    //    _database.AddInParameter(dbCommand, "@in_Email", user.Email);
    //    _database.AddInParameter(dbCommand, "@in_Address", user.Address);
    //    _database.AddOutParameter(dbCommand, "@out_UserId", OUTPARAMETER_SIZE);
    //    await _database.ExecuteNonQueryAsync(dbCommand);
    //    object result = _database.GetParameterValue(dbCommand, "@out_UserId");
    //    long expenseId = (result != null) ? Convert.ToInt32(result) : 0;
    //    return expenseId;
}
