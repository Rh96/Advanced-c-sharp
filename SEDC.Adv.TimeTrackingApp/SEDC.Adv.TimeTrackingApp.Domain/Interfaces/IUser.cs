﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Interfaces
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
