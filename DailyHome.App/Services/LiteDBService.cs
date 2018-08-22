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
        private LiteCollection<T> LitedbCollection { get; set; }
        private string Table = typeof(T).ToString();

        public LiteDBService()
        {
            LiteDBHelper.Open(db =>
            {
                LitedbCollection = db.GetCollection<T>(Table);
            });
        }

        public void InitIndex()
        {
            LitedbCollection.EnsureIndex(x => x.PID);
            //LiteDBHelper.Open(db =>
            //{
            //    var plans = db.GetCollection<T>(Table);
            //    plans.EnsureIndex(x => x.PID);
            //});
        }

        public void NewPlan(T t)
        {
            LitedbCollection.Insert(t);
            //LiteDBHelper.Open(db =>
            //{
            //    var plans = db.GetCollection<T>(Table);
            //    plans.Insert(t);
            //});
        }

        public void ModifyPlan(T t)
        {
            LitedbCollection.Update(t);
            //LiteDBHelper.Open(db =>
            //{
            //    var plans = db.GetCollection<T>(Table);
            //    plans.Update(t);
            //});
        }

        public void DeletePlan(string id)
        {
            LitedbCollection.Delete(id);
            //LiteDBHelper.Open(db =>
            //{
            //    var plans = db.GetCollection<Plan>(Table);
            //    plans.Delete(id);
            //});
        }

        public List<T> Find(Func<LiteCollection<T>, List<T>> listAction)
        {
            List<T> list = new List<T>();
            list = listAction(LitedbCollection);

            //LiteDBHelper.Open(db =>
            //{
            //    var dbList = db.GetCollection<T>(Table);

            //    list = listAction(dbList);
            //});

            return list;
        }
    }
}
