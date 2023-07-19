using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System;

namespace SportControl
{
    struct CycleTime
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
    class DataGridViewRowRacer : DataGridViewRowTag
    {
        string DisplayedTime;
        public bool Racing = false;
        public bool Started = false;
        public bool Finished = false;
        public bool TimeOut = false;
        public int BestCycle = 0;
        public Color ColorActive;
        public List<CycleTime> ListCycles = new List <CycleTime>();

        public DataGridViewRowRacer(DataGridView dataGridView, TagDT tagdt, Color ColorActive) : base(dataGridView, tagdt)
        {
            this.ColorActive = ColorActive;
            DisplayedTime = MaxRSSI_StrDT;
            //TODO: нужно уйти от создания ячеек по индексу. Те перестановка столбцов в таблице
            // требует перестановки данных тут. Ниже нерабочая попытка это сделать
            this.CreateCells(dataGridView, new object[] {
                 tagdt.tag.TID,
                 tagdt.tag.EPC,
                 ListCycles.Count,
                 0,
                 MaxRSSI_StrDT,
                 0,
                 0,
                 MaxRSSI,
                 MaxRSSI_StrDT
             });
            
            /*this.CreateCells(dataGridView);
            this.Cells["TID"].Value = tagdt.tag.TID;
            this.Cells["EPC"].Value = tagdt.tag.EPC;
            this.Cells["Count"].Value = ListCycles.Count;
            this.Cells["CycleTime"].Value = 0;
            this.Cells["TimePoint"].Value = MaxRSSI_StrDT;
            this.Cells["BestCycle"].Value = 0;
            this.Cells["BestCycleTime"].Value = 0;
            this.Cells["MaxRSSI"].Value = MaxRSSI;
            this.Cells["MaxRSSI_StrDT"].Value = MaxRSSI_StrDT;
            */
        }

        public override void SetOld(object sender, ElapsedEventArgs e)
        {
            DisplayedTime = MaxRSSI_StrDT;

            if (Racing && Started && !Finished && !TimeOut)
            {
                ListCycles.Add(new CycleTime(
                    MaxRSSI_DT,
                    ListCycles.Count > 0 ? MaxRSSI_DT - ListCycles[ListCycles.Count - 1].DT : TimeSpan.Zero
                ));

                if (ListCycles.Count == 2)
                    BestCycle = 1;

                if (ListCycles.Count > 1 && ListCycles[ListCycles.Count - 1].DeltaDT < ListCycles[BestCycle].DeltaDT)
                    BestCycle = ListCycles.Count - 1;
            }

            MaxRSSI = 0;
            base.SetOld(sender, e);
            UpdateView();
        }

        public void Deactivate()
        {
            active = false;
            timer.Stop();
            UpdateView();
        }
        public void UpdateInfo(TagDT tagdt)
        {
            if(!Finished)
                UpdateTag(tagdt);
            UpdateView();
        }

        public void UpdateView()
        {
            if (ListCycles.Count > 0)
            {
                this.Cells["Count"].Value = ListCycles.Count - 1;
                // отображаем данные последнего круга
                this.Cells["TimePoint"].Value = ListCycles[ListCycles.Count - 1].StrDT;
                this.Cells["CycleTime"].Value = ListCycles[ListCycles.Count - 1].StrDeltaDT;
                this.Cells["BestCycle"].Value = BestCycle.ToString();
                this.Cells["BestCycleTime"].Value = ListCycles[BestCycle].StrDeltaDT;
            }

            this.Cells["MAX_RSSI"].Value = MaxRSSI;
            this.Cells["DT_MAX_RSSI"].Value = MaxRSSI_StrDT;

            if (Finished)
                this.DefaultCellStyle.BackColor = Color.LightGray;
            else if (active)
                this.DefaultCellStyle.BackColor = ColorActive;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }


    }
}
