using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportControl
{
    public struct CycleTime
    {
        public DateTime DT;
        public TimeSpan DeltaDT;

        public CycleTime(DateTime dt, TimeSpan deltaDT)
        {
            DT = dt;
            DeltaDT = deltaDT;
        }

        public string StrDT
        {
            get
            {
                return string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", DT.Hour, DT.Minute, DT.Second, DT.Millisecond);
            }
        }

        public string StrDeltaDT
        {
            get
            {
                return string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", DeltaDT.Hours, DeltaDT.Minutes, DeltaDT.Seconds, DeltaDT.Milliseconds);
            }
        }
    }
}
