using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class TrainerUser : User, ITrainerUser
    {
        public int YearsExperience { get; set; }

        public TrainerUser()
        {
            Role = UserRole.Trainer;
        }

        public bool ChangeSchedule(ILiveTraining liveTraining)
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
