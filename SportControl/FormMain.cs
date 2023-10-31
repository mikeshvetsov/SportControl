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

        Boolean ReaderSelectedAsSource = false;
        public RFIDReaderHF340 hf340;
        public RFIDReaderHF340Simulator hf340Sim;
        
        const double INTERVAL_REMOVE_OLD_RECORDS = 1000;
       // internal System.Timers.Timer timerRemoveOldRecords;

        public FormMain()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
            hf340Sim = new RFIDReaderHF340Simulator(TagHandler: TagHandler);
            comboBox_PersonDataSource.SelectedIndex = 0;

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

            if (ReaderSelectedAsSource)
            {
                dgvPerson.UpdateTag(tagdt);
            }

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

            if (e.RowIndex < 0)
                return;

            DataGridViewRow dgvr = dgvPerson.Rows[e.RowIndex];
  
            if (dgvr.Cells["ID"].Value != null)
            {
                textBox_ID.Text = dgvr.Cells["ID"].Value.ToString();
                textBox_TID1.Text = dgvr.Cells["TID1"].Value.ToString();
                textBox_TID2.Text = dgvr.Cells["TID2"].Value.ToString();
                textBox_Num.Text = dgvr.Cells["RacingNumber"].Value.ToString();
                textBox_SecondName.Text = dgvr.Cells["SecondName"].Value.ToString();
                textBox_Name.Text = dgvr.Cells["FirstName"].Value.ToString();
                textBox_Age.Text = dgvr.Cells["age"].Value.ToString();
                checkBox_Race1.Checked = (bool)dgvr.Cells["Race1"].Value;
                checkBox_Race2.Checked = (bool)dgvr.Cells["Race2"].Value;
                checkBox_Race3.Checked = (bool)dgvr.Cells["Race3"].Value;
                checkBox_Race4.Checked = (bool)dgvr.Cells["Race4"].Value;
                checkBox_Race5.Checked = (bool)dgvr.Cells["Race5"].Value;
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

            /*

            редактирование:
            https://ru.stackoverflow.com/questions/932351/Модифицировать-или-добавить-запись-если-она-существует

          */

            if (textBox_ID.Text.Length > 0)
            {
                // запись в бд существует, обновляем
                Program.command.CommandText = "UPDATE Person SET name=:name, family=:family, number=:number, tid1=:tid1, tid2=:tid2, age=:age, " +
                    "race1=:race1, race2=:race2, race3=:race3, race4=:race4, race5=:race5, date_time=datetime('now') WHERE ID=:id";
                Program.command.Parameters.AddWithValue("id", textBox_ID.Text);
            } 
            else
            {
                Program.command.CommandText = "INSERT INTO Person (name, family, number, tid1, tid2, age, race1, race2, race3, race4, race5, date_time) VALUES (:name, :family, :number, :tid1, :tid2, :age, " +
                    ":race1, :race2, :race3, :race4, :race5, datetime('now'))";
            }
            Program.command.Parameters.AddWithValue("name", textBox_Name.Text);
            Program.command.Parameters.AddWithValue("family", textBox_SecondName.Text);
            Program.command.Parameters.AddWithValue("number", textBox_Num.Text);
            Program.command.Parameters.AddWithValue("tid1", textBox_TID1.Text);
            Program.command.Parameters.AddWithValue("tid2", textBox_TID2.Text);
            Program.command.Parameters.AddWithValue("age", textBox_Age.Text);
            Program.command.Parameters.AddWithValue("race1", checkBox_Race1.Checked ? 1 : 0);
            Program.command.Parameters.AddWithValue("race2", checkBox_Race2.Checked ? 1 : 0);
            Program.command.Parameters.AddWithValue("race3", checkBox_Race3.Checked ? 1 : 0);
            Program.command.Parameters.AddWithValue("race4", checkBox_Race4.Checked ? 1 : 0);
            Program.command.Parameters.AddWithValue("race5", checkBox_Race5.Checked ? 1 : 0);
            Program.command.ExecuteNonQuery();

            LoadRacersFromDB();
            if (textBox_ID.Text.Length > 0)
            {
                SelectDGVRowByDBID(textBox_ID.Text);
            } else
            {
                Program.command.CommandText = @"select last_insert_rowid()";
                SelectDGVRowByDBID(Program.command.ExecuteScalar().ToString());
            }

        }

        private void SelectDGVRowByDBID(string DBRowID)
        {
            int rowIndex = -1;
            DataGridViewRow row = dgvPerson.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["ID"].Value.ToString().Equals(DBRowID)).First();
            rowIndex = row.Index;
            dgvPerson.Rows[rowIndex].Selected = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in flowLayoutPanel_Edit.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }

            foreach (CheckBox ChkBox in flowLayoutPanel_Edit.Controls.OfType<CheckBox>())
            {
                ChkBox.Checked = false;
            }
        }

        private void comboBox_PersonDataSource_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadRacersFromDB();
            ReaderSelectedAsSource = comboBox_PersonDataSource.SelectedIndex == 1;
            
        }

        private void LoadRacersFromDB()
        {
            dgvPerson.ClearData();

            if (comboBox_PersonDataSource.SelectedIndex == 0)
            {
                Program.command.CommandText = $"SELECT * FROM Person";
                DataTable data = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(Program.command);
                adapter.Fill(data);

                foreach (DataRow rowDB in data.Rows)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvPerson, new object[] {
                        rowDB.Field<string>("tid1"),
                        rowDB.Field<string>("tid2"),
                        rowDB.IsNull("number")?"": rowDB.Field<long>("number").ToString(),
                        rowDB.Field<string>("family"),
                        rowDB.Field<string>("name"),
                        rowDB.IsNull("age")?"":rowDB.Field<long>("age").ToString(),
                        rowDB.IsNull("id")?"":rowDB.Field<long>("id").ToString(),
                        rowDB.IsNull("race1")?false:rowDB.Field<long>("race1") > 0,
                        rowDB.IsNull("race2")?false:rowDB.Field<long>("race2") > 0,
                        rowDB.IsNull("race3")?false:rowDB.Field<long>("race3") > 0,
                        rowDB.IsNull("race4")?false:rowDB.Field<long>("race4") > 0,
                        rowDB.IsNull("race5")?false:rowDB.Field<long>("race5") > 0,
                        rowDB.Field<string>("date_time")

                    });

                    dgvPerson.Rows.Add(row);
                }

            }
        }
        private void clearAllRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.command.CommandText = "UPDATE Person SET race1=0, race2=0, race3=0, race4=0, race5=0";
            Program.command.ExecuteNonQuery();
            LoadRacersFromDB();
        }
    }
}
