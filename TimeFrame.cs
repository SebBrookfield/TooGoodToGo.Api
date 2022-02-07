using System;

namespace TGTG.Api.Core
{
    public class TimeFrame
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        protected internal TimeFrame()
        {
        }
    }
}