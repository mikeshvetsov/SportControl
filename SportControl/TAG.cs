using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SportControl
{
    public class TAG
    {
        const double LIVE_INTERVAL = 2000; // 2 секунды
        byte MaxRSSI;
        protected DateTime MaxRSSI_DT;
  
        internal System.Timers.Timer TimerLive;
        public Boolean active;

        public TAG()
        {
            TimerLive = new System.Timers.Timer(LIVE_INTERVAL);
            TimerLive.Elapsed += SetDead;
            active = false;
        }

        public virtual void SetDead(object sender, ElapsedEventArgs e)
        {
            active = false;
            MaxRSSI = 0;
            TimerLive.Stop();

        }

        public void Update(byte RSSI, DateTime dt)
        {
            if (MaxRSSI < RSSI)
            {
                MaxRSSI = RSSI;
                MaxRSSI_DT = dt;
            }
            active = true;
            TimerLive.Stop();
            TimerLive.Start();
        }
    }
}
