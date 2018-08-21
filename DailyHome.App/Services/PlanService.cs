using System;
using NCrontab;
using System.Linq;

namespace DailyHome.App.Services
{
    public class PlanService
    {
        public void GenScheduler(string crontab,DateTime start,DateTime end)
        {
            var s = CrontabSchedule.Parse(crontab);
            IEnumerable<DateTime> occurrences = s.GetNextOccurrences(start, end);
            
        }
    }
}