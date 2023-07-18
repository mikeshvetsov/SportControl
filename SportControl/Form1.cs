using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
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
       // List<String> ListFinished = new List<string>();
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
            timer_race.Start();
            timeStartRace = getDateTimeNow();
            label_TimeStart.Text = timeStartRace.str_dt;
            FormTimeRacing.label_TimeStart.Text = label_TimeStart.Text;

            lock (dic_Rows_Racers)
            {
                foreach (var i in dic_Rows_Racers)
                    i.Value.Started = true;
            }

        }

        private void button_StopRace_Click(object sender, EventArgs e)
        {
            timer_race.Stop();

            lock (dic_Rows_Racers)
            {
                foreach (var i in dic_Rows_Racers)
                    i.Value.TimeOut = true;
            }

        }

        private void timer_race_Tick(object sender, EventArgs e)
        {
            TimeRecord tNow = getDateTimeNow();
            TimeSpan deltaTime = tNow.dt - timeStartRace.dt;

            label_TimeRace.Text = string.Format("{0:d2}:{1:d2}:{2:d2}.{3}", deltaTime.Hours, deltaTime.Minutes, deltaTime.Seconds, deltaTime.Milliseconds);
            FormTimeRacing.label_TimeRace.Text = label_TimeRace.Text;

        }

        private void button_OnStart_Click(object sender, EventArgs e)
        {
            OnStart = true;

            lock (dic_Rows_Racers)
            {
                foreach(var i in dic_Rows_Racers)
                {
                    i.Value.Racing = true;
                    i.Value.ColorActive = TAG_NORMAL_ACTIVE_COLOR;
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            List<String> lines = new List<string>();
            string format = "{0}\t{1}\t{2}\t{3}\t\t{4}";
            lines.Add("Общая таблица:");

            lines.Add(string.Format(format, "Номер   ", "Циклов", "Время последнего круга", "        Финиш        ", "ID"));
            foreach (DataGridViewRow row in dataGridView_Racers.Rows)
            {
                lines.Add(string.Format(format,
                    row.Cells[1].Value.ToString().PadLeft(8),
                    row.Cells[2].Value.ToString().PadLeft(4),
                    row.Cells[3].Value.ToString().PadLeft(22),
                    row.Cells[4].Value.ToString().PadLeft(16),
                    row.Cells[0].Value.ToString())
                );
            }

            System.IO.File.WriteAllLines(@"C:\temp\Race.txt", lines);

            lines.Clear();
            lines.Add("Круги по каждому участнику:");
            foreach (DataGridViewRow row in dataGridView_Racers.Rows)
            {
                lines.Add(string.Format("{0}\t{1}\t{2}\t\t{3}",
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[0].Value.ToString())
                );

                string key = row.Cells[1].Value + "|" + row.Cells[0].Value;
                if (dic_Rows_Racers.ContainsKey(key))
                {
                    int j = 0;
                    foreach (var i in dic_Rows_Racers[key].ListCycles)
                    {
                        lines.Add(string.Format("{0}\t{1}", j++, i.StrDeltaDT.PadLeft(13)));
                    }
                }

                lines.Add("--------------------------------------------------------");
            }

            System.IO.File.AppendAllLines(@"C:\temp\Race.txt", lines);

        }

        private void button_Finished_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView_Racers.CurrentCell.RowIndex;
            string epc = dataGridView_Racers.Rows[rowIndex].Cells["EPC"].Value.ToString();
            string tid = dataGridView_Racers.Rows[rowIndex].Cells["TID"].Value.ToString();
            string key = epc + "|" + tid;

            lock (dic_Rows_Racers)
            {
                if (dic_Rows_Racers.ContainsKey(key))
                {
                    DataGridViewRowRacer finishedRacer = dic_Rows_Racers[key];
                    finishedRacer.Finished = true;
                    finishedRacer.UpdateView();
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                Console.WriteLine("cpuInfo: " + cpuInfo);
                break;
            }
        }
    }

}
