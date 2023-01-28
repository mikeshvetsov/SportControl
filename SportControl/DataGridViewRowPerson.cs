using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridViewRowPerson : DataGridViewRow
    {
        const double INTERVAL_OLD = 2000;
        string DisplayedTime;
        public Person Racer;
        System.Timers.Timer timer;
        public Boolean active;
        public DataGridViewRowPerson(DataGridView dataGridView, TagDT tagdt)
        {
            Racer = new Person(tagdt);
            DisplayedTime = Racer.StrDT;
            this.CreateCells(dataGridView, new object[] { Racer.TID, Racer.EPC, Racer.Count, Racer.StrDT});
            timer = new System.Timers.Timer(INTERVAL_OLD);
            timer.Elapsed += SetOld;
            timer.Start();
            active = true;
        }

        private void SetOld(object sender, ElapsedEventArgs e)
        {
            active = false;
            Racer.AddCount();
            DisplayedTime = Racer.StrDT;
            timer.Stop();
            UpdateView();
        }
       
        public void UpdateTag(TagDT tagdt)
        {
            Racer.MailTag(tagdt);

            active = true;
            timer.Stop();
            timer.Start();

            UpdateView();
        }

        private void UpdateView()
        {
            this.Cells["Count"].Value = Racer.Count;
            this.Cells["TimePoint"].Value = DisplayedTime;
            if (active)
                this.DefaultCellStyle.BackColor = Color.LightGreen;
            else
                this.DefaultCellStyle.BackColor = Color.White;
        }
    }
}
