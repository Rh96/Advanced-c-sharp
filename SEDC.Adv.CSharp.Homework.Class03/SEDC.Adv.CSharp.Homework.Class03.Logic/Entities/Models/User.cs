using SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.CSharp.Homework.Class03.Logic.Entities.Models
{
    public abstract class User:IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }


        public User(int id, string name, string userName, int pass)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = pass;
        }
        public abstract void PrintUser();
    }
}
