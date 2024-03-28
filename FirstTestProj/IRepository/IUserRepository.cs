using DotNetFmsProj.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DotNetFmsProj.IRepository
{
    public interface IUserRepository
    {
        public DataTable GetUserList();
        public DataTable GetUserDetails(long userId);

        public bool ValidateUser(string userName, string password);
        public DataTable GetUser(string userName, string password);
        public DataTable CreateUser(User user); 
        public DataTable VerifyUser(string firstName, string userName, string mobileNumber); 
        public DataTable UpdatePassword(string userName, string password); 

    }
}
