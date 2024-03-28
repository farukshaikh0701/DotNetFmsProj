using DotNetFmsProj.IRepository;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using DotNetFmsProj.Repository;
using Microsoft.AspNetCore.Mvc;
using DotNetFmsProj.Model;

namespace DotNetFmsProj.Repository
{
    public class DayRepository : IDayRepository
    {
        public IConfiguration _configuration;
        public DayRepository(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        public DataTable GetDayList(long userId, string searchText, string month, string dayType, bool isToday, bool isTomorrow, bool isYesterday)
        {
            string query = "BirthdayRecords_Get";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myConn))
                {
                    myCommand.Parameters.AddWithValue("@in_UserId", userId);
                    myCommand.Parameters.AddWithValue("@in_Months", month);
                    myCommand.Parameters.AddWithValue("@in_dayType", dayType);
                    myCommand.Parameters.AddWithValue("@in_IsToday", isToday);
                    myCommand.Parameters.AddWithValue("@in_IsTomorrow", isTomorrow);
                    myCommand.Parameters.AddWithValue("@in_IsYesterday", isYesterday);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return dt;
        }

        public DataTable GetDayDetails(long userId, long dayId)
        {
            string sp = "BirthdayInfo_Get";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.Parameters.AddWithValue("@in_BirthdayId", dayId);
                    myCommand.Parameters.AddWithValue("@in_UserId", userId);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return dt;
        }

        public DataTable DeleteDay(long userId, long dayId)
        {
            string sp = "BirthdayInfo_Delete";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            SqlDataReader myReader;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.Parameters.AddWithValue("@in_BirthdayId", dayId);
                    myCommand.Parameters.AddWithValue("@in_UserId", userId);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    dt.Load(myReader);
                    myReader.Close();
                    myConn.Close();
                }
            }
            return dt;
        }


        public long AddDay(long userId, Day day)
        {
            string sp = "BirthdayInfo_Add";
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            long dayId = 0;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_BirthDate", day.Birthdate);
                    myCommand.Parameters.AddWithValue("@in_PersonName", day.PersonName);
                    myCommand.Parameters.AddWithValue("@in_Address", day.Address);
                    myCommand.Parameters.AddWithValue("@In_RelationId", day.RelationId);
                    myCommand.Parameters.AddWithValue("@In_ContactNumber", day.ContactNumber);
                    myCommand.Parameters.AddWithValue("@In_MobileNUmber", day.MobileNumber);
                    myCommand.Parameters.AddWithValue("@in_EmailId", day.EmailId);
                    myCommand.Parameters.AddWithValue("@In_DayTypeId", day.DayTypeId);
                    myCommand.Parameters.AddWithValue("@in_assetId", day.AssetId);
                    myCommand.Parameters.AddWithValue("@in_UserId", userId);

                    SqlParameter outputParameter = new SqlParameter();
                    outputParameter.Direction = ParameterDirection.Output;
                    outputParameter.Size = -1;
                    outputParameter.ParameterName = "@Out_BirthdayId";
                    myCommand.Parameters.Add(outputParameter);
                    myCommand.ExecuteNonQuery();
                    dayId = Convert.ToInt16(outputParameter.Value);
                    myConn.Close();
                }
            }
            return dayId;
        }

        public DataTable UpdateDay(long userId,Day day)
        {
            string sp = "BirthdayInfo_Update";
            DataTable dt = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("FMSConnectionString");
            object DayId = 0;
            using (SqlConnection myConn = new SqlConnection(sqlDatasource))
            {
                myConn.Open();
                using (SqlCommand myCommand = new SqlCommand(sp, myConn))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@in_BirthdayId", day.DayId);
                    myCommand.Parameters.AddWithValue("@in_BirthDate", day.Birthdate);
                    myCommand.Parameters.AddWithValue("@in_PersonName", day.PersonName);
                    myCommand.Parameters.AddWithValue("@in_Address", day.Address);
                    myCommand.Parameters.AddWithValue("@In_RelationId", day.RelationId);
                    myCommand.Parameters.AddWithValue("@In_ContactNumber", day.ContactNumber);
                    myCommand.Parameters.AddWithValue("@In_MobileNumber", day.MobileNumber);
                    myCommand.Parameters.AddWithValue("@in_EmailId", day.EmailId);
                    myCommand.Parameters.AddWithValue("@In_DayTypeId", day.DayTypeId);
                    myCommand.Parameters.AddWithValue("@in_assetId", day.AssetId);
                    myCommand.Parameters.AddWithValue("@in_UserId", userId);

                    DayId = myCommand.ExecuteScalar();
                    myConn.Close();
                }
            }
            return dt;
        }

    }
}
