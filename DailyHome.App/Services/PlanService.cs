using System;
using NCrontab;
using System.Linq;
using System.Collections.Generic;
using DailyHome.App.Data;
using DailyHome.App.Models;
using LiteDB;

namespace DailyHome.App.Services
{
    public class PlanService
    {
        public List<DateTime> GenScheduler(string crontab,DateTime start,DateTime end)
        {
            var s = CrontabSchedule.Parse(crontab);
            var occurrences = s.GetNextOccurrences(start, end);
            
            return occurrences.ToList();

        }

        public void InitIndex()
        {
            LiteDBHelper.Open(db=>
            {
                 var plans = db.GetCollection<Plan>("Plan");
                 plans.EnsureIndex(x => x.PID);
            });
        }

        public void NewPlan(Plan plan)
        {
            LiteDBHelper.Open(db=>
            {
                 var plans = db.GetCollection<Plan>("Plan");
                 plans.Insert(plan);
            });
        }

        public void ModifyPlan(Plan plan)
        {
            LiteDBHelper.Open(db=>
            {
                 var plans = db.GetCollection<Plan>("Plan");
                 plans.Update(plan);
            });
        }

        public void DeletePlan(string id)
        {
            LiteDBHelper.Open(db=>
            {
                 var plans = db.GetCollection<Plan>("Plan");
                 plans.Delete(id);
            });
        }

        public List<Plan> Find(Func<LiteCollection<Plan>,List<Plan>> listAction)
        {
            List<Plan> list=new List<Plan>();

            LiteDBHelper.Open(db=>
            {
                 var plans = db.GetCollection<Plan>("Plan");
                 
                 list= listAction(plans);
            });

            return list;    
        } 
    }
}