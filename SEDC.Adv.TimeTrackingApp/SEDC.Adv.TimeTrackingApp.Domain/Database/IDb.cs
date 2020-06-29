using SEDC.Adv.TimeTrackingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Database
{
    public interface IDb<T> where T : BaseEntity
    {
        T GetById(int id);
        int Insert(T entity);
        void Update(T entity);
    }
}
