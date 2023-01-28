using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SportControl
{
    public class Person
    {
        public string EPC;
        public string TID;
        public int Count;
        public string StrDT;
        public byte MaxRSSI;
        DateTime DT;
  
        public Person(TagDT tagdt)
        {
            EPC = tagdt.tag.EPC;
            TID = tagdt.tag.TID;
            MaxRSSI = tagdt.tag.RSSI;
            Count = 0;
            updateDT(tagdt.dt);
        }

        public void AddCount()
        {
            MaxRSSI = 0;
            Count += 1;
        }
        public void MailTag(TagDT tagdt)
        {
            if (MaxRSSI < tagdt.tag.RSSI)
            {
                MaxRSSI = tagdt.tag.RSSI;
                updateDT(tagdt.dt);
            }
        }

        private void updateDT(DateTime dt)
        {
            DT = dt;
            StrDT = string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }
    }
}
