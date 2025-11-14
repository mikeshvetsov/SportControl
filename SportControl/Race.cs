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
        Func<string, bool, bool> AddLog;

        public Race(Func<string, bool, bool> LogHandler)
        {
            AddLog = LogHandler;
        }

        public void SetNewRacersList(DataTable data)
        {
            if (Started)
                return;

            Racers.Clear();

            foreach (DataRow row in data.Rows)
            {
                Racers.Add(new Racer(row, AddLog));
            }
        }

        public Racer TagHandler(TagDT tagdt)
        {
            Racer res = null;

            if (!Started)
                return null;

            //TODO: может переделать эту секцию так, чтобы сначала найти гонщика и потом вызват обработчик его, а не у каждого вызывать.
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
