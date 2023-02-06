using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridViewRowTag : DataGridViewRow
    {
        const double INTERVAL_OLD = 2000;
        System.Timers.Timer timer;
        public Boolean active;
        public TagDT tagdt;

        public byte MaxRSSI;
        DateTime MaxRSSI_DT;
        public string MaxRSSI_StrDT;
        Color ColorActive;

        public DataGridViewRowTag(DataGridView dataGridView, TagDT tagdt, Color ColorActive)
        {
            this.tagdt = tagdt;
            MaxRSSI = tagdt.tag.RSSI;
            updateMaxRSSI_DT(tagdt.dt);

            this.ColorActive = ColorActive;
            this.CreateCells(dataGridView, new object[] { tagdt.tag.TID, tagdt.tag.EPC });
            timer = new System.Timers.Timer(INTERVAL_OLD);
            timer.Elapsed += SetOld;
            timer.Start();
            active = true;


        }

        public virtual void SetOld(object sender, ElapsedEventArgs e)
        {
            active = false;
            timer.Stop();
            UpdateView();
        }
       
        public virtual void UpdateTag(TagDT tagdt)
        {
            active = true;
            this.tagdt = tagdt;
            UpdateMaxRSSI();
            timer.Stop();
            timer.Start();
            UpdateView();
        }

        public virtual void UpdateView()
        {
            if (active)
                this.DefaultCellStyle.BackColor = ColorActive;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }

        void UpdateMaxRSSI()
        {
            if (MaxRSSI < tagdt.tag.RSSI)
            {
                MaxRSSI = tagdt.tag.RSSI;
                updateMaxRSSI_DT(tagdt.dt);
            }
        }

        private void updateMaxRSSI_DT(DateTime dt)
        {
            MaxRSSI_DT = dt;
            MaxRSSI_StrDT = string.Format("{0:d2}:{1:d2}:{2:d2}:{3}", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }
    }
}
