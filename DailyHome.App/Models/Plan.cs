using System;
using System.Collections.Generic;

namespace DailyHome.App.Models
{
    /// <summary>
    /// 計劃清單
    /// </summary>
    public class Plan:IPID
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


    
}