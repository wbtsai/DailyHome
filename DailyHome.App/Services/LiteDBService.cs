using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyHome.App.Data;
using DailyHome.App.Models;
using LiteDB;

namespace DailyHome.App.Services
{
    public class LiteDBService<T> where T:IPID
    {
        public LiteCollection<T> DataList { get; set; }
        private string Table = typeof(T).ToString();

        public LiteDBService()
        {
            LiteDBHelper.Open(db =>
            {
                DataList = db.GetCollection<T>(Table);
            });
        }

        public LiteDBService(string connString)
        {
            LiteDBHelper.Open(connString,db =>
            {
                DataList = db.GetCollection<T>(Table);
            });
        }

        public void InitIndex()
        {
            DataList.EnsureIndex(x => x.PID);
        }

        public void NewPlan(T t)
        {
            DataList.Insert(t);
        }

        public void ModifyPlan(T t)
        {
            DataList.Update(t);
        }

        public void DeletePlan(string id)
        {
            DataList.Delete(id);
           
        }

        public List<T> Find(Func<LiteCollection<T>, List<T>> listAction)
        {
            List<T> list = new List<T>();
            list = listAction(DataList);

            return list;
        }
    }
}
