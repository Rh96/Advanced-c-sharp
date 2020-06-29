using SEDC.Adv.TimeTrackingApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Entities
{
    public class Reading
    {
        public int Pages { get; set; }
        public BookType BookType { get; set; }
    }
}
