using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDb<T> ListDb;
        public UserService()
        {
            ListDb = new LocalDb<T>();
        }

        public void ChangeInfo(int userId, string firstName, string lastName)
        {
            T userFound = ListDb.GetById(userId);
            if (userFound != null)
            {
                userFound.FirstName = firstName;
                userFound.LastName = lastName;
                ListDb.Update(userFound);
            }
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T userFound = ListDb.GetById(userId);

            if (userFound != null && userFound.Password == oldPassword)
            {
                userFound.Password = newPassword;
                ListDb.Update(userFound);
            }
        }

        public T LogIn(string username, string password)
        {
            T user = ListDb.GetAll().FirstOrDefault(user => user.Username == username && user.Password == password);
            if (user == null)
            {
                Console.WriteLine("Username or password are not match");
            }

            return user;
        }

        public T Register(T user)
        {
            int id = ListDb.Insert(user);
            return ListDb.GetById(id);
        }
    }
}
