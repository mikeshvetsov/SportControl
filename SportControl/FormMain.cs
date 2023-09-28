using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{
    public partial class FormMain : Form
    {

        public RFIDReaderHF340 hf340;
        public RFIDReaderHF340Simulator hf340Sim;
        
        const double INTERVAL_REMOVE_OLD_RECORDS = 1000;
       // internal System.Timers.Timer timerRemoveOldRecords;

        public FormMain()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
            hf340Sim = new RFIDReaderHF340Simulator(TagHandler: TagHandler);

           // timerRemoveOldRecords = new System.Timers.Timer(INTERVAL_REMOVE_OLD_RECORDS);
           // timerRemoveOldRecords.Elapsed += RemoveOldRecords;
           // timerRemoveOldRecords.Start();
        }


        delegate bool AddTag(TagDT tagdt);
        private bool TagHandler(TagDT tagdt)
        {

            if (this.InvokeRequired)
            {
                this.BeginInvoke(new AddTag(TagHandler), tagdt);
                return false;
            }


            /*  Program.command.CommandText = $"SELECT * FROM Person WHERE tid1 = '{key}' OR tid2 = '{key}'";
              DataTable data = new DataTable();
              SQLiteDataAdapter adapter = new SQLiteDataAdapter(Program.command);
              adapter.Fill(data);
              Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");
              foreach (DataRow row in data.Rows)
              {
                  Console.WriteLine($"id = {row.Field<long>("id")} name = {row.Field<string>("name")} family = {row.Field<string>("family")}");
              }
            */
            dgvPerson.UpdateTag(tagdt);

            /*DataGridViewRowRacer dgvr = null;
            
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

                    dgvr = new DataGridViewRowRacer(dataGridView_Racers, tagdt, activeColor, LogText);
                    dic_Rows_Racers.Add(key, dgvr);
                    dataGridView_Racers.Rows.Add(dgvr);

                }
            }
            */

            return true;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            // Подключение к считывателю
            Button thisBtn = sender as Button;
            Boolean res;

            if (checkBox_Simulator.Checked)
            {
                res = hf340Sim.Connect();
            }
            else
            {
                string ip = maskedTextBox_reader_ip.Text.Trim() + ":" + numericUpDown_reader_port.Value.ToString();

                Int32 antNUM = 0;
                eAntennaNo antNo = eAntennaNo._1;
                #region Get antenna number & single reading/cyclic reading
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

                thisBtn.BackColor = Color.Yellow;
                
                res = hf340.Connect(ip, antNUM, antNo);
            }

            if (res)
            {
                thisBtn.BackColor = Color.Green;
                thisBtn.Text = "Подключено";
                thisBtn.Enabled = false;
            }
            else
            {
                thisBtn.BackColor = Color.Transparent;
            }

        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if (checkBox_Simulator.Checked)
            {
                hf340Sim.Disconnect();
            }
            else
            {
                hf340.Disconnect();
            }

            button_connect.Enabled = true;
            button_connect.Text = "Подключить";
            button_connect.BackColor = Color.Transparent;

        }

        private void timerRemoveOldRecords_Tick(object sender, EventArgs e)
        {
            dgvPerson.RemoveOldRecords();
        }
    }
}
