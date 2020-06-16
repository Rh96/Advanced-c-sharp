using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime NextSession { get; set; }
        public TrainerUser Trainer { get; set; }

        public int HoursToNextSession()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
