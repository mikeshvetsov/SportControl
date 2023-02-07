using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SportControl
{
    public partial class Form1 : Form
    {

        Color TAG_NORMAL_ACTIVE_COLOR = Color.LightGreen;
        Color TAG_ALARM_ACTIVE_COLOR = Color.Red;
        public RFIDReaderHF340 hf340;
        Form2 FormTimeRacing = new Form2();
        Dictionary<String, DataGridViewRowRacer> dic_Rows_Racers = new Dictionary<string, DataGridViewRowRacer>();
        TimeRecord timeStartRace;
        bool OnStart = false;

        public Form1()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
           
        }

        delegate bool AddTag(TagDT tagdt);
        private bool TagHandler(TagDT tagdt)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new AddTag(TagHandler), tagdt);
                return false;
            }

            string key = tagdt.tag.EPC + "|" + tagdt.tag.TID;
            DataGridViewRowRacer dgvr = null;

            lock (dic_Rows_Racers)
            {
                if (dic_Rows_Racers.ContainsKey(key))
                {
                    dgvr = dic_Rows_Racers[key];
                    dgvr.UpdateInfo(tagdt);
                }
                else
                {
                    Color activeColor = OnStart ? TAG_ALARM_ACTIVE_COLOR : TAG_NORMAL_ACTIVE_COLOR;
                    
                    dgvr = new DataGridViewRowRacer(dataGridView_Racers, tagdt, activeColor);
                    dic_Rows_Racers.Add(key, dgvr);
                    dataGridView_Racers.Rows.Add(dgvr);

                }
            }


            return true;
        }

        private void Timer1SHandler(object sender, EventArgs e)
        {
            lock (dic_Rows_Racers)
            {
                List<string> removals = new List<string>();
                foreach (var i in dic_Rows_Racers)
                    if (!i.Value.Racing&&!i.Value.active)
                        removals.Add(i.Key);
                foreach (string key in removals)
                {
                    dataGridView_Racers.Rows.Remove(dic_Rows_Racers[key]);
                    dic_Rows_Racers.Remove(key);
                }
            }
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
            timer_1s.Stop();

            foreach(var i in dic_Rows_Racers)
                i.Value.Deactivate();
            
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            hf340.Read_EPCTID();
            timer_1s.Start();
        }

        private void button_ClearGreed_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTimeRacing.Show();
        }

        private void button_StartRace_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            timeStartRace = getDateTimeNow();
            label_TimeStart.Text = timeStartRace.str_dt;
            FormTimeRacing.label_TimeStart.Text = label_TimeStart.Text;
        }

        private void button_StopRace_Click(object sender, EventArgs e)
        {
           // timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeRecord tNow = getDateTimeNow();
            TimeSpan deltaTime = tNow.dt - timeStartRace.dt;

            label_TimeRace.Text = string.Format("{0:d2}:{1:d2}:{2:d2}.{3}", deltaTime.Hours, deltaTime.Minutes, deltaTime.Seconds, deltaTime.Milliseconds);
            FormTimeRacing.label_TimeRace.Text = label_TimeRace.Text;

            label_unixTimeNow.Text = DateTimeOffset.Now.ToUnixTimeMilliseconds().ToString();
        }

        private void button_OnStart_Click(object sender, EventArgs e)
        {
            OnStart = true;

            lock (dic_Rows_Racers)
            {
                foreach(var i in dic_Rows_Racers)
                {
                    i.Value.Racing = true;
                }
            }
        }

        private void dataGridView_Racers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            DataGridViewRow dgvr = null;
            DataGridViewRowRacer dgvr_Racers = dic_Rows_Racers.Single(x => x.Value.Index == e.RowIndex).Value;

            dataGridView_RacerData.Rows.Clear();

            foreach(var x in dgvr_Racers.ListCycles)
            {
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dataGridView_RacerData, new object[] { i, x.StrDeltaDT, x.StrDT });
                dataGridView_RacerData.Rows.Add(dgvr);
                i++;
            }
            
        }
    }

}
