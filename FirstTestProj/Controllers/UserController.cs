using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using DotNetFmsProj.IRepository;
using DotNetFmsProj.Shared;
using DotNetFmsProj.Model;
//using System.Security.Cryptography;

namespace DotNetFmsProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        public IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("GetUserList")]
        public JsonResult GetUserList()
        {
            DataTable dt = _userRepository.GetUserList();
            return new JsonResult(dt);
        }

        [HttpGet]
        [Route("GetUserDetails")]
        public JsonResult GetUserDetails(long userId)
        {
            DataTable dt = _userRepository.GetUserDetails(userId);
            return new JsonResult(dt);
        }

        [HttpGet]
        [Route("ValidateUser")]
        public JsonResult ValidateUser(string userName, string password)
        {
            bool dt = _userRepository.ValidateUser(userName, password);
            return new JsonResult(dt);
        }

        [HttpGet]
        [Route("GetUser")]
        public JsonResult GetUser(string username, string password)
        {
            HashAlgorithm hashAlgorithm = new HashAlgorithm();
            DataTable dt = _userRepository.GetUser(username, hashAlgorithm.GetHash(password));
            return new JsonResult(dt);
        }


        [HttpPost]
        [Route("CreateUser")]
        public  DataTable CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        [HttpGet]
        [Route("VerifyUser")]
        public DataTable VerifyUser(string firstName,string userName, string mobileNumber)
        {
            return _userRepository.VerifyUser(firstName, userName, mobileNumber);
        }
        [HttpGet]
        [Route("UpdatePassword")]
        public DataTable UpdatePassword(string userName, string password)
        {
            HashAlgorithm hashAlgorithm = new HashAlgorithm();
            return _userRepository.UpdatePassword(userName, hashAlgorithm.GetHash(password));
        }


    }
}
