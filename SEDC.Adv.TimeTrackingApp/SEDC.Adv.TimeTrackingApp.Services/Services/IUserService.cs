using SEDC.Adv.TimeTrackingApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Services.Services
{
    public interface IUserService<T> where T : User
    {
        // Change first and last name
        // Change password
        // Deactivate acc
        void ChangeFirstAndLastName(int id, string firstName, string lastName);
        void ChangePassword(int id, string oldPassword, string newPassword);
        void DeactivateAcc(int id);
    }
}
