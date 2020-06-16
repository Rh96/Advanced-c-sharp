using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isParsed = int.TryParse(number, out num);

            if (!isParsed)
            {
                return -1;
            }
            if(num <= 0 || num > range)
            {
                return -1;
            }
            return num;
        }

        public static string ValidateString(string str)
        {
            return str.Length < 2 ? null : str;
        }

        public static string ValidateUsername(string username)
        {
            return username.Length < 6 ? null : username;
        }

        public static string ValidatePassword(string password)
        {
            if(password.Length < 6)
            {
                return null;
            }

            // bool hasOneNumber = false;
            foreach (char c in password.ToCharArray())
            {
                //if(int.TryParse(c.ToString(), out int num))
                //{
                //    hasOneNumber = true;
                //    break;
                //}

                if (char.IsNumber(c))
                {
                    // hasOneNumber = true;
                    return password;
                }
            }

            return null;
            //if (!hasOneNumber)
            //{
            //    return null;
            //}

            //return password;
        }
    }
}
