using DotNetFmsProj.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DotNetFmsProj.IRepository
{
    public interface IDayRepository
    {

        public DataTable GetDayList(long userId, string searchText, string month, string dayType, bool isToday , bool isTomorrow , bool isYesterday);
        public DataTable GetDayDetails(long userId, long dayId);
        public long AddDay(long userId, Day day);
        public DataTable DeleteDay(long userId, long dayId);
        public DataTable UpdateDay(long userId, Day day);


    }
}
