using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Db
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCount { get; set; }
        private List<T> ListDb;


        public LocalDb()
        {
            IdCount = 1;
            ListDb = new List<T>();
        }

        public List<T> GetAll()
        {
            return ListDb;
        }

        public T GetById(int id)
        {
            return ListDb.FirstOrDefault(getId => getId.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            ListDb.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void Remove(int id)
        {
            T item = ListDb.FirstOrDefault(rId => rId.Id == id);
            if (item == null)
            {
                Console.WriteLine("Item was not found by that id!");
                return;
            }
            ListDb.Remove(item);
            Console.WriteLine("Item was removed!");
        }

        public void Update(T entity)
        {
            T item = ListDb.FirstOrDefault(getId => getId.Id == entity.Id);
            item = entity;
        }
    }
}
