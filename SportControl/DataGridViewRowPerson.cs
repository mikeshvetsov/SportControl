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
        Color ColorActive;
        public List<CycleTime> ListCycles = new List <CycleTime>();

        public DataGridViewRowRacer(DataGridView dataGridView, TagDT tagdt, Color ColorActive) : base(dataGridView, tagdt)
        {
            this.ColorActive = ColorActive;
            DisplayedTime = MaxRSSI_StrDT;
            this.CreateCells(dataGridView, new object[] {
                tagdt.tag.TID,
                tagdt.tag.EPC,
                ListCycles.Count,
                0,
                MaxRSSI_StrDT,
                MaxRSSI,
                MaxRSSI_StrDT
            });
        }

        public override void SetOld(object sender, ElapsedEventArgs e)
        {
            DisplayedTime = MaxRSSI_StrDT;

            if (Racing)
                ListCycles.Add(new CycleTime(
                    MaxRSSI_DT,
                    ListCycles.Count > 0 ? MaxRSSI_DT - ListCycles[ListCycles.Count - 1].DT : TimeSpan.Zero
                )); ;

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
            }
            this.Cells["MAX_RSSI"].Value = MaxRSSI;
            this.Cells["DT_MAX_RSSI"].Value = MaxRSSI_StrDT;

            if (active)
                this.DefaultCellStyle.BackColor = ColorActive;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }
    }
}
