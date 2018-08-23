using System;
using NCrontab;
using System.Linq;
using System.Collections.Generic;
using DailyHome.App.Data;
using DailyHome.App.Models;
using LiteDB;

namespace DailyHome.App.Services
{
    public class PlanService:LiteDBService<Plan>
    {
        public PlanService():base()
        {

        }

        public PlanService(string connString):base(connString)
        {

        }

        private void Test()
        {
            
        }

        public List<DateTime> GenScheduler(string crontab,DateTime start,DateTime end)
        {
            var s = CrontabSchedule.Parse(crontab);
            var occurrences = s.GetNextOccurrences(start, end);
            
            return occurrences.ToList();
        }

         
    }
}