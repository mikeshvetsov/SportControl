using System.Timers;
using System.Windows.Forms;
using System.Drawing;

namespace SportControl
{
    class DataGridViewRowRacer : DataGridViewRowTag
    {
        string DisplayedTime;
        public int Count;

        public DataGridViewRowRacer(DataGridView dataGridView, TagDT tagdt, Color ColorActive) : base(dataGridView, tagdt, ColorActive)
        {
            Count = 0;
            DisplayedTime = MaxRSSI_StrDT;
            this.CreateCells(dataGridView, new object[] {
                tagdt.tag.TID,
                tagdt.tag.EPC,
                Count,
                MaxRSSI_StrDT,
                MaxRSSI,
                MaxRSSI_StrDT
            });
        }

        public override void SetOld(object sender, ElapsedEventArgs e)
        {
            Count += 1;
            DisplayedTime = MaxRSSI_StrDT;
            MaxRSSI = 0;
            base.SetOld(sender, e);
        }

        public override void UpdateView()
        {
            this.Cells["Count"].Value = Count;
            this.Cells["TimePoint"].Value = DisplayedTime;
            this.Cells["MAX_RSSI"].Value = MaxRSSI;
            this.Cells["DT_MAX_RSSI"].Value = MaxRSSI_StrDT;
            base.UpdateView();
        }
    }
}
