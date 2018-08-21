using System;
using System.Collections.Generic;

namespace DailyHome.App.Models
{
    public class Plan
    {
        public string PID{get;set;}
        public string Subject{get;set;}
        public DateTime BeginDate{get;set;}
        public DateTime EndDate{get;set;}

        /// <summary>
        /// 說明
        /// </summary>
        /// <returns></returns>
        public string Description{get;set;}

        public string Owners{get;set;}
        
        public List<Scheduler> Schedulers{get;set;}

        public string AttachFiles{get;set;}

        public string Status{get;set;}

    }


    /// <summary>
    /// https://www.nuget.org/packages/ncrontab/
    /// </summary>
    public class Scheduler
    {
        public string SID{get;set;}

        public string Belongto{get;set;}

        public string Name{get;set;}

        /// <summary>
        /// Crontab String
        /// </summary>
        /// <returns></returns>
        public string Crontab { get; set; }
        /// <summary>
        /// 是否已經產生活動
        /// </summary>
        /// <returns></returns>
        public string IsGen { get; set; }
    }
}