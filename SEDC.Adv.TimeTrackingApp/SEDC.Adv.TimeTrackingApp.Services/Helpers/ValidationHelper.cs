using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Services.Helpers
{
    public static class ValidationHelper
    {
        public static string ValidateFullName(string str)
        {
            if (str.Length < 2)
            {
                return null;
            }

            foreach (char ch in str.ToCharArray())
            {
                if (char.IsDigit(ch))
                {
                    return null;
                }
            }
            return str;
        }

        public static string ValidateUsername(string userName)
        {
            if (userName.Length < 5)
            {
                return null;
            }
            return userName;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 6)
            {
                return null;
            }

            foreach (char ch in password.ToCharArray())
            {
                if (char.IsUpper(ch) && char.IsDigit(ch))
                {
                    return password;
                }
            }
            return null;
        }

        public static int ValidateAge(int age)
        {
            if (age < 18 || age > 120)
            {
                return -1;
            }
            return age;
        }
    }
}
