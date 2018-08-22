using System;
using System.Collections.Generic;

namespace DailyHome.App.Models
{
    public class Task : IPID
    {
        /// <summary>
        /// TID
        /// </summary>
        /// <returns></returns>
        public string PID{get;set;}

        public string TaskName{get;set;}

        public DateTime StartDate{get;set;}

        public DateTime EndDate{get;set;}

        public string Description{get;set;}

        /// <summary>
        /// 檔案清單
        /// </summary>
        /// <returns></returns>
        public List<Media> MediaList{get;set;}

        /// <summary>
        /// 花費清單 
        /// </summary>
        /// <returns></returns>
       public List<Consumption> SpendList{get;set;}

       

    }
}