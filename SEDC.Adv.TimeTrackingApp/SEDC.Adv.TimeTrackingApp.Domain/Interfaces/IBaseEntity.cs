using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TimeTrackingApp.Domain.Interfaces
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        string Info();
    }
}
