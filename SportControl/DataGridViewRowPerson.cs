using System.Timers;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace SportControl
{
    class DataGridViewRowRacer : DataGridViewRowTag
    {
        string DisplayedTime;
        public bool Racing = false;
        Color ColorActive;
        public List<string> ListCycles = new List <string>();
        public DataGridViewRowRacer(DataGridView dataGridView, TagDT tagdt, Color ColorActive) : base(dataGridView, tagdt)
        {
            this.ColorActive = ColorActive;
            DisplayedTime = MaxRSSI_StrDT;
            this.CreateCells(dataGridView, new object[] {
                tagdt.tag.TID,
                tagdt.tag.EPC,
                ListCycles.Count,
                MaxRSSI_StrDT,
                MaxRSSI,
                MaxRSSI_StrDT
            });
        }

        public override void SetOld(object sender, ElapsedEventArgs e)
        {
            DisplayedTime = MaxRSSI_StrDT;
            ListCycles.Add(DisplayedTime);

            MaxRSSI = 0;
            base.SetOld(sender, e);
            UpdateView();
        }

        public void UpdateInfo(TagDT tagdt)
        {
            UpdateTag(tagdt);
            UpdateView();
        }
        public void UpdateView()
        {
            this.Cells["Count"].Value = ListCycles.Count;
            this.Cells["TimePoint"].Value = DisplayedTime;
            this.Cells["MAX_RSSI"].Value = MaxRSSI;
            this.Cells["DT_MAX_RSSI"].Value = MaxRSSI_StrDT;

            if (active)
                this.DefaultCellStyle.BackColor = ColorActive;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }
    }
}
