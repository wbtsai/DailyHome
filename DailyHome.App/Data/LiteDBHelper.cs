using System;
using LiteDB;
using System.Configuration;


namespace DailyHome.App.Data
{
    /// <summary>
    /// 這個是與DB做結合的資料
    /// </summary>
    public class LiteDBHelper
    {
        //private static string LiteDBConnString=ConfigurationManager.ConnectionStrings["LiteDB.Path"].ConnectionString;
        private static string LiteDBConnString="MyData.db";

        public static void Open(Action<LiteDatabase> connAction)
        {
               Open(LiteDBConnString,connAction);
        }

        public static void Open(string connString,Action<LiteDatabase> connAction)
        {
             using(var db = new LiteDatabase(connString))
            {
                connAction(db);
            }   
        }
    }
}