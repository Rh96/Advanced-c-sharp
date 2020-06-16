using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }
        public double Rating { get; set; }

        public string CheckRating()
        {
            throw new NotImplementedException();
        }

        public override string PrintInfo()
        {
            throw new NotImplementedException();
        }
    }
}
