using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Entities
{
    public class OtherHobbies
    {
        public string NameOfHobby { get; set; }

        public void PrintHobbyName()
        {
            Console.WriteLine($"Name of hobby: {NameOfHobby}");
        }
    }
}
