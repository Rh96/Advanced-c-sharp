using SEDC.Adv.TimeTrackingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Entities
{
    public class User : BaseEntity, IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string Info()
        {
            return $"{Id}) {FirstName} {LastName} - ({Age})";
        }
    }
}
