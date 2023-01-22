using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportControl
{
    public partial class Form1 : Form
    {
        public RFIDReaderHF340 hf340;
        public List<Person> Racers;
        Form2 FormTimeRacing = new Form2();

        TimeRecord timeStartRace;

        public Form1()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
        }

        private TimeRecord getDateTimeNow()
        {
            TimeRecord tr = new TimeRecord();

            tr.dt = DateTime.Now;
            tr.str_dt = string.Format("{0:d2}:{1:d2}:{2:d2}.{3}", tr.dt.Hour, tr.dt.Minute, tr.dt.Second, tr.dt.Millisecond);

            return tr;
        }

        private void text_ip_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public bool isStringIP(string str)
        {
            var rx = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (rx.IsMatch(str))
                return true;

            return false;
        }

        private void text_ip_TextChanged(object sender, EventArgs e)
        {

            MaskedTextBox text_ipObj = (MaskedTextBox)sender;

            if (!isStringIP(text_ipObj.Text))
            {
                text_ipObj.ForeColor = Color.Red;
                text_ipObj.Tag = false;
               
            }
            else
            {
                text_ipObj.ForeColor = Color.Black;
                text_ipObj.Tag = true;
            }

        }

        class DataGridViewRowPerson: DataGridViewRow
        {

            public Person Racer;

            public DataGridViewRowPerson(DataGridView dataGridView, TagDT tagdt)
            {
                this.CreateCells(dataGridView, new object[] { tagdt.tag.TID, tagdt.tag.EPC, 0 });
                Racer = new Person(tagdt);
            }
        }

        delegate bool AddTag(TagDT tagdt);
        Dictionary<String, DataGridViewRowPerson> dic_Rows = new Dictionary<string, DataGridViewRowPerson>();
        private bool TagHandler(TagDT tagdt)
        {

            var sw = new Stopwatch();
            sw.Start();
            if (this.dataGridView_tag.InvokeRequired)
            {
                this.dataGridView_tag.BeginInvoke(new AddTag(TagHandler), tagdt);
                return false;
            }

            /*
            if (Racers is null)
            {
                Racers = new List<Person> { new Person(tagdt) };
            }
            else
            {
                var person = Racers.SingleOrDefault(p => p.TID == tagdt.tag.TID);
                if (person is null)
                    Racers.Add(new Person(tagdt));
                else
                    person.MailTag(tagdt);
            }
            */



            string key = tagdt.tag.EPC + "|" + tagdt.tag.TID;
            DataGridViewRowPerson dgvr = null;
            lock (dic_Rows)
            {

                if (dic_Rows.ContainsKey(key))
                {
                    dgvr = dic_Rows[key];
                    Int64 newStr = Convert.ToInt64(dgvr.Cells["Count"].Value) + 1;
                    dgvr.Cells["Count"].Value = newStr;
                }
                else
                {
                    dgvr = new DataGridViewRowPerson(dataGridView_tag, tagdt);
                    dic_Rows.Add(key, dgvr);
                    dataGridView_tag.Rows.Add(dgvr);
                }

            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            /*
            if (Racers is null)
            {
                if (InvokeRequired)
                {
                    Racers = new List<Person> {new Person(tagdt)};
                    this.Invoke(new Action(() => {
                        //dataGridView_tag.DataSource = Racers;
                    }));
                }
            }
            else
            {
                if (InvokeRequired)
                    this.Invoke(new Action(() => {
                        var person = Racers.SingleOrDefault(p => p.TID == tagdt.tag.TID);
                        if (person is null)
                            Racers.Add(new Person(tagdt));
                        else
                            person.MailTag(tagdt);
                    })) ;
            }

            if (Racers.Count == 1)
                if (InvokeRequired)
                    this.Invoke(new Action(() => { 
                        //dataGridView_tag.DataSource = Racers; 
                    
                    }));

            */
            return true;
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            Boolean res;
            string ip = maskedTextBox_reader_ip.Text.Trim() + ":" + numericUpDown_reader_port.Value.ToString();
            #region Get antenna number & single reading/cyclic reading
            Int32 antNUM = 0;
            eAntennaNo antNo = eAntennaNo._1;
            int count = 0;

            foreach (var item in groupBox_ant.Controls)
            {
                CheckBox control = item as CheckBox;
                if (control != null && control.Checked)
                {
                    antNUM += Int32.Parse(control.Tag.ToString());
                    if (count == 0)
                        antNo = (eAntennaNo)Int32.Parse(control.Tag.ToString());
                    else
                        antNo = antNo | (eAntennaNo)Int32.Parse(control.Tag.ToString());
                    count++;
                    
                }
            }

            #endregion


            label_connection_status.Text = "Подключение ...";
            res = hf340.Connect(ip, antNUM, antNo);

            if (res)
               label_connection_status.Text = "Подключен";
            else
                label_connection_status.Text = "Отключен";
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            hf340.Disconnect();
            label_connection_status.Text = "Отключен";
            timer_ListUpdate.Stop();
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            hf340.Read_EPCTID();
            timer_ListUpdate.Start();
        }

        private void button_ClearGreed_Click(object sender, EventArgs e)
        {
           
        }

        private void button_calcDt_Click(object sender, EventArgs e)
        {

            List<long> costs = new List<long>();

            //Iterate through each row in the grid
            foreach (DataGridViewRow row in dataGridView_tag.Rows)
            {
                if (null != row && null != row.Cells["unix_t"].Value && (row.Cells["EPC"].Value as string) != "")
                {
                    costs.Add((long)row.Cells["unix_t"].Value);
                }
            }

            long min_t = costs.Min();
            long max_t = costs.Max();
            label_dt.Text = (max_t - min_t).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTimeRacing.Show();
        }

        private void button_StartRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timeStartRace = getDateTimeNow();
            label_TimeStart.Text = timeStartRace.str_dt;
            FormTimeRacing.label_TimeStart.Text = label_TimeStart.Text;
        }

        private void button_StopRace_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeRecord tNow = getDateTimeNow();
            TimeSpan deltaTime = tNow.dt - timeStartRace.dt;

            label_TimeRace.Text = string.Format("{0:d2}:{1:d2}:{2:d2}.{3}", deltaTime.Hours, deltaTime.Minutes, deltaTime.Seconds, deltaTime.Milliseconds);
            FormTimeRacing.label_TimeRace.Text = label_TimeRace.Text;

            label_unixTimeNow.Text = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }

        private void timer_ListUpdate_Tick(object sender, EventArgs e)
        {

            if (Racers == null || Racers.Count == 0)
                return;

            foreach (var item in Racers.ToArray())
                if (item.old) Racers.Remove(item);

            
        }

    }

}
