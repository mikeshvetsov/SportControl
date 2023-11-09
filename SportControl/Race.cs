using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SportControl
{
    public class Race
    {

        // 1 список участников загружается по смене комбобокса заездов

        public bool Started = false;

        public CycleTime TimeStartRace = new CycleTime(DateTime.Now, TimeSpan.Zero);

        public List<Racer> Racers = new List<Racer>();

        public Race()
        {
            
        }

        public void SetNewRacersList(DataTable data)
        {
            if (Started)
                return;

            Racers.Clear();

            foreach (DataRow row in data.Rows)
            {
                Racers.Add(new Racer(row));
            }
        }

        public Racer TagHandler(TagDT tagdt)
        {
            Racer res = null;

            if (!Started)
                return null;

            foreach (Racer mRacer in Racers)
            {
                if (mRacer.TagHandler(tagdt))
                {
                    res = mRacer;
                    break;
                }
            }

            return res;
        }

        public void Start()
        {
            Started = true;
            TimeStartRace.DT = DateTime.Now;           
        }

        public void Stop()
        {
            Started = false;
        }

    }
}
