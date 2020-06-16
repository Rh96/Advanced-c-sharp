using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Interfaces
{
    public interface ITrainerUser
    {
        bool ChangeSchedule(ILiveTraining liveTraining);
    }
}
