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
        public string EPC { get; set; }
        public string TID { get; set; }
        public int Count { get; set; }
        public string strDT { get; set; }
        public byte RSSI { get; set; }
        public byte MinRSSI { get; set; }
        public byte MaxRSSI { get; set; }

        public Boolean old;
        DateTime DT;
        Timer timer;

        const double INTERVAL_OLD = 2000;
        public Person(TagDT tagdt)
        {
            EPC = tagdt.tag.EPC;
            TID = tagdt.tag.TID;
            RSSI = tagdt.tag.RSSI;
            MinRSSI = tagdt.tag.RSSI;
            MaxRSSI = tagdt.tag.RSSI;
            Count = 0;
            updateDT(tagdt.dt);
            old = false;
            timer = new Timer(INTERVAL_OLD);
            timer.Elapsed += SetOld;
            timer.Start();
        }

        private void SetOld(Object source, ElapsedEventArgs e)
        {
            old = true;
        }

        public void MailTag(TagDT tagdt)
        {
            RSSI = tagdt.tag.RSSI;
            MinRSSI = MinRSSI > tagdt.tag.RSSI ? tagdt.tag.RSSI : MinRSSI;

            if (MaxRSSI < tagdt.tag.RSSI)
            {
                MaxRSSI = tagdt.tag.RSSI;
            }
            Count += 1;
            updateDT(tagdt.dt);

            old = false;
            timer.Stop();
            timer.Start();
        }

        private void updateDT(DateTime dt)
        {
            DT = dt;
            strDT = string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }
    }
}
