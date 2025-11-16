using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
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
        public Race mRace;
        
        const double INTERVAL_REMOVE_OLD_RECORDS = 1000;
        // internal System.Timers.Timer timerRemoveOldRecords;
        private bool isModifiedCelldgvPerson = false;

        public FormMain()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
            hf340Sim = new RFIDReaderHF340Simulator(TagHandler: TagHandler);
            mRace = new Race(AddLog);

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

            dgvPersonActive.UpdateTag(tagdt);
 
            Racer mRacer = mRace.TagHandler(tagdt);
            if (checkBox_FullLog.Checked)
            {
                if(mRacer == null){
                    AddLog($"Неизвестный: {tagdt.tag.TID} RSSI:{tagdt.tag.RSSI}", false); 
                } else
                {
                    AddLog($"{mRacer.Number}: {mRacer.Name} RSSI:{tagdt.tag.RSSI}", false);
                }
            }

            return true;
        }

        delegate bool LogText(string msg, bool MainWindow);
        public bool AddLog(string msg, bool MainWindow = true)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new LogText(AddLog), msg, MainWindow);
                return false;
            }

            TextBox tb = MainWindow ? textBox_log : textBox_log2;
            tb.Text = tb.Text.Insert(0, $"{DateTime.Now}:\t{msg}" + System.Environment.NewLine);

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
            dgvPersonActive.RemoveOldRecords();
        }

        private void LoadRacersFromDB(string where="")
        {
            dgvPerson.ClearData();


            Program.command.CommandText = $"SELECT * FROM Person "+ where;
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

            isModifiedCelldgvPerson = false;
        }
        private void clearAllRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.command.CommandText = "UPDATE Person SET race1=0, race2=0, race3=0, race4=0, race5=0";
            Program.command.ExecuteNonQuery();
            LoadRacersFromDB();
        }

        private void dgvPerson_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void toolStripComboBox_SelectRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = toolStripComboBox_SelectRace.SelectedIndex;

            string where = i > 0 ? $"WHERE race{i}=1" : "";

            LoadRacersFromDB(where);
  
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (mRace.Started)
            {
                MessageBox.Show("Операция не может быть выполнена. Гонка не завершена!");
                return;
            }

            ComboBox cb = sender as ComboBox;
            int i = cb.SelectedIndex + 1;
            AddLog($"Установка: {cb.Text}");

            string where = i > 0 ? $"WHERE race{i}=1" : "";

            Program.command.CommandText = $"SELECT * FROM Person " + where;
            DataTable data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(Program.command);
            adapter.Fill(data);

            mRace.SetNewRacersList(data);
            dgvRace.Rows.Clear();
        }

        private void timerUpdateRaceView_Tick(object sender, EventArgs e)
        {

            if (mRace.Started) {
                mRace.TimeStartRace.DeltaDT = DateTime.Now - mRace.TimeStartRace.DT;
                label_TimeRace.Text = mRace.TimeStartRace.StrDeltaDT;
            }
                 
            foreach( Racer mRacer in mRace.Racers)
            {

                String searchValue = mRacer.id;
                int rowIndex = -1;
                foreach (DataGridViewRow row in dgvRace.Rows)
                {
                    if (row.Cells["dgvRaceCellID"].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;

                        row.Cells["dgvRaceCellCycle"].Value = mRacer.ListCycles.Count - 1;
                        row.Cells["dgvRaceCellCycleTime"].Value = mRacer.LastCycleTime;
                        row.Cells["dgvRaceCellBestTime"].Value = mRacer.BestCycleTime;

                        if (mRacer.active)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else
                            row.DefaultCellStyle.BackColor = Color.White;

                        break;
                    }
                }

                if (rowIndex == -1)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvRace, new object[] {
                        mRacer.id,
                        mRacer.Number,
                        mRacer.Name,
                        mRacer.ListCycles.Count
                    });
                    dgvRace.Rows.Add(row);
                }
            }
        }

        private void button_RaceStart_Click(object sender, EventArgs e)
        {
            mRace.Start();
            label_TimeStart.Text = mRace.TimeStartRace.StrDT;
            AddLog("Старт!");
        }

        private void button_RaceStop_Click(object sender, EventArgs e)
        {
            mRace.Stop();
            AddLog("Стоп!");
        }

        private void dgvRace_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            DataGridViewRow dgvr;
            string id = (sender as DataGridView).Rows[e.RowIndex].Cells["dgvRaceCellID"].Value.ToString();

            Racer mRacer = mRace.Racers.Find(x => x.id == id);

            dgvRacerData.Rows.Clear();

            foreach (var x in mRacer.ListCycles)
            {
                dgvr = new DataGridViewRow();
                dgvr.CreateCells(dgvRacerData, new object[] { i, x.StrDeltaDT, x.StrDT });
                if (i == mRacer.BestCycle)
                    dgvr.DefaultCellStyle.BackColor = Color.LightSeaGreen;
                dgvRacerData.Rows.Add(dgvr);

                i++;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string FileName = $@"C:\temp\{comboBoxRace.SelectedItem}.txt";
            List<String> lines = new List<string>();

            lines.Add("Общая таблица:");
            lines.Add("Номер\t\tИмя                 \tКругов\tЛучшее время\tID");
            foreach (DataGridViewRow row in dgvRace.Rows)
            {
                lines.Add(
                    row.Cells["dgvRaceCellNuber"].Value.ToString() + "\t\t\t" +
                    row.Cells["dgvRaceCellName"].Value.ToString().PadRight(20) + "\t"+
                    row.Cells["dgvRaceCellCycle"].Value.ToString() + "\t\t" +
                    row.Cells["dgvRaceCellBestTime"].Value.ToString()+ "\t\t" +
                    row.Cells["dgvRaceCellID"].Value.ToString() 
                );
            }

            System.IO.File.WriteAllLines(FileName, lines);

            lines.Clear();
            lines.Add("Круги по каждому участнику:");
            foreach (Racer mRacer in mRace.Racers)
            {
                lines.Add($"№{mRacer.Number}\t{mRacer.Name.PadRight(20)}\tКругов: {mRacer.ListCycles.Count - 1}\tЛучшее время: {mRacer.BestCycleTime} Лучший круг: {mRacer.BestCycle}\t\tID: {mRacer.id}");
                int j = 0;
                foreach (var i in mRacer.ListCycles)
                {
                    if (j > 0)
                        lines.Add(string.Format("{0}\t{1}", j, i.StrDeltaDT.PadRight(13)));
                    j++;
                }
                

                lines.Add("--------------------------------------------------------");
            }

            File.AppendAllLines(FileName, lines);

            AddLog("Запись в файл");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; // Защита от клика по заголовкам

            DataGridViewCell cell = dgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewCheckBoxCell)
            {
                // Для чекбокса: переключаем значение
                // Получаем текущую ячейку
                DataGridViewCheckBoxCell cellCB = (DataGridViewCheckBoxCell)dgvPerson.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Переключаем значение чекбокса
                if (cellCB.Value == null || cellCB.Value == DBNull.Value)
                {
                    cellCB.Value = true; // Если значение не задано, ставим true
                }
                else
                {
                    // Переключаем текущее значение
                    cellCB.Value = !(bool)cell.Value;
                }

                saveRowToDB(dgvPerson.Rows[e.RowIndex]);
            }

            // Обязательный вызов для обновления отображения
            dgvPerson.NotifyCurrentCellDirty(true);
        }

        private string getCellVal(DataGridViewRow row, string name)
        {
            object value = row.Cells[name].Value;
            return (value == null || value == DBNull.Value) ? string.Empty : value.ToString();
        }

        private int saveRowToDB(DataGridViewRow row)
        {
            /* Сохраняем все в БД.
                редактирование:
                https://ru.stackoverflow.com/questions/932351/Модифицировать-или-добавить-запись-если-она-существует
            */

            string idString = getCellVal(row, "ID");

            if (idString.Length > 0)
            {
                // запись в бд существует, обновляем
                Program.command.CommandText = "UPDATE Person SET name=:name, family=:family, number=:number, tid1=:tid1, tid2=:tid2, age=:age, " +
                    "race1=:race1, race2=:race2, race3=:race3, race4=:race4, race5=:race5, date_time=datetime('now') WHERE ID=:id";
                Program.command.Parameters.AddWithValue("id", idString);

                Console.WriteLine($"save to db. ID {idString}");
            }
            else
            {
                Program.command.CommandText = "INSERT INTO Person (name, family, number, tid1, tid2, age, race1, race2, race3, race4, race5, date_time) VALUES (:name, :family, :number, :tid1, :tid2, :age, " +
                    ":race1, :race2, :race3, :race4, :race5, datetime('now'))";

                Console.WriteLine($"save to db new string.");
            }

            Program.command.Parameters.AddWithValue("name", getCellVal(row, "FirstName"));
            Program.command.Parameters.AddWithValue("family", getCellVal(row, "SecondName"));
            Program.command.Parameters.AddWithValue("number", getCellVal(row, "RacingNumber"));
            Program.command.Parameters.AddWithValue("tid1", getCellVal(row, "TID1"));
            Program.command.Parameters.AddWithValue("tid2", getCellVal(row, "TID2"));
            Program.command.Parameters.AddWithValue("age", getCellVal(row, "Age"));
            Program.command.Parameters.AddWithValue("race1", Convert.ToBoolean(row.Cells["Race1"].Value) ? 1 : 0);
            Program.command.Parameters.AddWithValue("race2", Convert.ToBoolean(row.Cells["Race2"].Value) ? 1 : 0);
            Program.command.Parameters.AddWithValue("race3", Convert.ToBoolean(row.Cells["Race3"].Value) ? 1 : 0);
            Program.command.Parameters.AddWithValue("race4", Convert.ToBoolean(row.Cells["Race4"].Value) ? 1 : 0);
            Program.command.Parameters.AddWithValue("race5", Convert.ToBoolean(row.Cells["Race5"].Value) ? 1 : 0);
            Program.command.ExecuteNonQuery();

            isModifiedCelldgvPerson = false;
            return 0;
        }

        private void dgvPerson_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isModifiedCelldgvPerson)
                saveRowToDB(dgvPerson.Rows[e.RowIndex]);
        }

        private void dgvPerson_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isModifiedCelldgvPerson = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Устанавливаем разделитель в середину при загрузке формы
            splitContainer1.SplitterDistance = this.ClientSize.Height / 2;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            LoadRacersFromDB();
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            hf340.Read_EPCTID();
        }
    }
}
