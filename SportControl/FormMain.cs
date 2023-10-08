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

            dgvPerson.UpdateTag(tagdt);

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

        private void dgvPerson_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* Двойной клик по строке имеет два смысла:
             * Если клик по строке, которая ек содержит ID, значит значение TID1 следует
             * перенести в своботодное поле редактирования TID1 или TID2.
             * 
             * Если клик по строке с заполненным ID, значит есть намерение редактирования этой
             * строки всей - все переносим в поля редактирования
             */

            int i = 0;
            DataGridViewRow dgvr = dgvPerson.Rows[e.RowIndex];
  
            if (dgvr.Cells["ID"].Value != null)
            {
                textBox_ID.Text = dgvr.Cells["ID"].Value.ToString();
                textBox_TID1.Text = dgvr.Cells["TID1"].Value.ToString();
                textBox_TID2.Text = dgvr.Cells["TID2"].Value.ToString();
                textBox_Num.Text = dgvr.Cells["RacingNumber"].Value.ToString();
                textBox_SecondName.Text = dgvr.Cells["SecondName"].Value.ToString();
                textBox_Name.Text = dgvr.Cells["FirstName"].Value.ToString();
            } else
            {
                if (textBox_TID1.Text.Length == 0)
                    textBox_TID1.Text = dgvr.Cells["TID1"].Value.ToString();
                else if (textBox_TID2.Text.Length == 0)
                    textBox_TID2.Text = dgvr.Cells["TID1"].Value.ToString();
            }

        }

        private void button_SavePerson_Click(object sender, EventArgs e)
        {
            /* Сохраняем все в БД.
             */

            /*  Program.command.CommandText = $"SELECT * FROM Person WHERE tid1 = '{key}' OR tid2 = '{key}'";
            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(Program.command);
            adapter.Fill(data);
            Console.WriteLine($"Прочитано {data.Rows.Count} записей из таблицы БД");
            foreach (DataRow row in data.Rows)
            {
                Console.WriteLine($"id = {row.Field<long>("id")} name = {row.Field<string>("name")} family = {row.Field<string>("family")}");
            }


            command.CommandText = "INSERT INTO Person (name, family, age) VALUES (\"Иванов\",\"Иван\", 25)";
            command.ExecuteNonQuery();

            проверка на существование:
            cmd.CommandText = "SELECT count(*) FROM wordlist WHERE word='word'"; 
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if(count == 0)
            {
                cmd.CommandText = "INSERT INTO wordlist(word) VALUES ('word')"; 
                cmd.ExecuteNonQuery();
            }

            редактирование:
            https://ru.stackoverflow.com/questions/932351/Модифицировать-или-добавить-запись-если-она-существует

          */

            if (textBox_ID.Text.Length > 0)
            {
                // запись в бд существует, обновляем
                Program.command.CommandText = "UPDATE Person SET name=:name, family=:family, number=:number, tid1=:tid1, tid2=:tid2 WHERE ID=:id";
                Program.command.Parameters.AddWithValue("name", textBox_Name.Text);
                Program.command.Parameters.AddWithValue("family", textBox_SecondName.Text);
                Program.command.Parameters.AddWithValue("number", textBox_Num.Text);
                Program.command.Parameters.AddWithValue("tid1", textBox_TID1.Text);
                Program.command.Parameters.AddWithValue("tid2", textBox_TID2.Text);
                Program.command.Parameters.AddWithValue("id", textBox_ID.Text);
                Program.command.ExecuteNonQuery();
            } 
            else
            {
                Program.command.CommandText = "INSERT INTO Person (name, family, number, tid1, tid2) VALUES (:name, :family, :number, :tid1, :tid2)";
                Program.command.Parameters.AddWithValue("name", textBox_Name.Text);
                Program.command.Parameters.AddWithValue("family", textBox_SecondName.Text);
                Program.command.Parameters.AddWithValue("number", textBox_Num.Text);
                Program.command.Parameters.AddWithValue("tid1", textBox_TID1.Text);
                Program.command.Parameters.AddWithValue("tid2", textBox_TID2.Text);
                Program.command.ExecuteNonQuery();
            }


        }
    }
}
