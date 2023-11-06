using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SportControl
{
    public class Racer : TAG
    {
        public string id;
        public string Name;
        public string Number;
        public int BestCycle = 0;
        public List<CycleTime> ListCycles = new List<CycleTime>();
        public string LastCycleTime {
            get
            {
                if (ListCycles.Count > 0)
                    return ListCycles.Last().StrDeltaDT;
                else
                    return new CycleTime(new DateTime(0), new TimeSpan(0)).StrDeltaDT;
            }
        }

        public string BestCycleTime
        {
            get
            {
                if (ListCycles.Count > 0)
                    return ListCycles[BestCycle].StrDeltaDT;
                else
                    return new CycleTime(new DateTime(0), new TimeSpan(0)).StrDeltaDT;
            }
        }
        string TID1;
        string TID2;

        public Racer(DataRow data)
        {
            id = data.Field<long>("id").ToString();
            Name = data.Field<string>("family") + " " + data.Field<string>("name");
            TID1 = data.Field<string>("tid1");
            TID2 = data.Field<string>("tid2");
            Number = data.IsNull("number") ? "" : data.Field<long>("number").ToString();
        }

        public override void SetDead(object sender, ElapsedEventArgs e)
        {
            base.SetDead(sender, e);

            ListCycles.Add(new CycleTime(MaxRSSI_DT, ListCycles.Count > 0 ? MaxRSSI_DT - ListCycles[ListCycles.Count - 1].DT : TimeSpan.Zero));

            if (ListCycles.Count == 2)
                BestCycle = 1;

            if (ListCycles.Count > 1 && ListCycles[ListCycles.Count - 1].DeltaDT < ListCycles[BestCycle].DeltaDT)
                BestCycle = ListCycles.Count - 1;

        }
        public bool TagHandler(TagDT tagdt)
        {
            if (tagdt.tag.TID == TID1 || tagdt.tag.TID == TID2)
            {
                Update(tagdt.tag.RSSI, tagdt.dt);
                return true;
            } else
            {
                return false;
            }
        }

        

    }
}
