using SEDC.Adv.TimeTrackingApp.Domain.Database;
using SEDC.Adv.TimeTrackingApp.Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SEDC.Adv.TimeTrackingApp.Services.Helpers;

namespace SEDC.Adv.TimeTrackingApp.Services.Services
{
    public class UserService<T>: IUserService<T> where T : User
    {
        private IDb<T> UsersDb;
        public UserService()
        {
            UsersDb = new Db<T>();
        }

        public void ChangeFirstAndLastName(int id, string firstName, string lastName)
        {
            T user = UsersDb.GetById(id);
            if(
                ValidationHelper.ValidateFullName(firstName) == null
                || ValidationHelper.ValidateFullName(lastName) == null)
            {
                return;
            }
            user.FirstName = firstName;
            user.LastName = lastName;
            UsersDb.Update(user);
            Console.WriteLine("Successfuly changed first name and last name!");
        }

        public void ChangePassword(int id, string oldPassword, string newPassword)
        {
            T user = UsersDb.GetById(id);
            if (user.Password != oldPassword)
            {
                return;
            }
            if(ValidationHelper.ValidatePassword(newPassword) == null)
            {
                return;
            }
            user.Password = newPassword;
            UsersDb.Update(user);
            Console.WriteLine("Password successfuly changed!");
        }

        public void DeactivateAcc(int id)
        {
            throw new NotImplementedException();
        }
    }
}
