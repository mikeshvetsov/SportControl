using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{

    class RowTagForDataGridView : DataGridViewRow
    {
        const double INTERVAL_OLD = 2000;
        internal System.Timers.Timer timer;
        public Boolean active;
        public TagDT tagdt;

        public byte MaxRSSI;
        public DateTime MaxRSSI_DT;
        public string MaxRSSI_StrDT { 
            get { 
                return string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", MaxRSSI_DT.Hour, MaxRSSI_DT.Minute, MaxRSSI_DT.Second, MaxRSSI_DT.Millisecond); 
            } 
        }
        
        public RowTagForDataGridView(DataGridView dataGridView, TagDT tagdt)
        {
            this.tagdt = tagdt;
            MaxRSSI = tagdt.tag.RSSI;
            MaxRSSI_DT = tagdt.dt;

            timer = new System.Timers.Timer(INTERVAL_OLD);
            timer.Elapsed += SetOld;
            timer.Start();
            active = true;
            UpdateView();
        }

        public virtual void SetOld(object sender, ElapsedEventArgs e)
        {
            active = false;
            timer.Stop();
            UpdateView();
        }
       
        internal void UpdateTag(TagDT tagdt)
        {
            active = true;
            this.tagdt = tagdt;
            UpdateMaxRSSI();
            timer.Stop();
            timer.Start();
            UpdateView();
        }

        void UpdateMaxRSSI()
        {
            if (MaxRSSI < tagdt.tag.RSSI)
            {
                MaxRSSI = tagdt.tag.RSSI;
                MaxRSSI_DT = tagdt.dt;
            }
        }

        public void UpdateView()
        {
            if (active)
                this.DefaultCellStyle.BackColor = Color.LightGreen;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }

    }
}
