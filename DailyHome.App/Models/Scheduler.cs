using System;
namespace DailyHome.App.Models
{
    /// <summary>
    /// https://www.nuget.org/packages/ncrontab/
    /// </summary>
    public class Scheduler : IPID
    {
        public string PID{get;set;}

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