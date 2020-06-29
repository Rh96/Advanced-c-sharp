using SEDC.Adv.TimeTrackingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Database
{
    public class Db<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> dataBase;
        public Db()
        {
            dataBase = new List<T>();
            IdCount = 1;
        }
        public T GetById(int id)
        {
            T getId = dataBase.FirstOrDefault(x => x.Id == id);
            return getId;
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            dataBase.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void Update(T entity)
        {
            T item = dataBase.FirstOrDefault(x => x.Id == entity.Id);
            item = entity;
        }
    }
}
