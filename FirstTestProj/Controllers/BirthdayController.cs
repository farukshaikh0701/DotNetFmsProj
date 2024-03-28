using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using DotNetFmsProj.Model;
using DotNetFmsProj.IRepository;

namespace DotNetFmsProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DayController : Controller
    {
        public IDayRepository _dayRepository;

        public DayController(IDayRepository dayRepository)
        {
            _dayRepository = dayRepository;
        }

        [HttpGet]
        [Route("GetDayList")]
        public JsonResult GetDayList(long userId, string? searchText=null, string? month=null, string? dayType=null, bool isToday=false, bool isTomorrow=false, bool isYesterday=false)
        {
            DataTable dt = _dayRepository.GetDayList(userId, searchText, month, dayType, isToday , isTomorrow , isYesterday );
            return new JsonResult(dt);
        }

        [HttpGet]
        [Route("GetDayDetails")]
        public JsonResult GetDayDetails(long userId,long dayId)
        {
            DataTable dt = _dayRepository.GetDayDetails(userId, dayId); 
            return new JsonResult(dt);
        }

        [HttpGet]
        [Route("DeleteDay")]
        public JsonResult DeleteDay(long userId, long dayId)
        {
            DataTable dt = _dayRepository.DeleteDay(userId, dayId);
            return new JsonResult(dt);
        }

        [HttpPost]
        [Route("AddDay")]
        public JsonResult AddDay(long userId,Day day)
        {
            long dayId = _dayRepository.AddDay(userId,day);
            return new JsonResult(dayId);
        }

        [HttpPost]
        [Route("UpdateDay")]
        public JsonResult UpdateDay(long userId,Day day)
        {
            DataTable dt= _dayRepository.UpdateDay(userId, day);
            return new JsonResult(dt);
        }


    }
}