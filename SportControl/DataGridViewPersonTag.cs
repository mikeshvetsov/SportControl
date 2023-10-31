/*
 * DataGridViewPersonTag - таблица отображающая метки в поле антены.
 * Строки типа RowTagForDataGridView
 * 
 * Все метки так или иначе отображаютс в таблицах. Поэтому любая метка это строка (Row) в таблице.
 * Для понимани нахождения метки в поле антены каждая строка соответствующая метке имет таймер, который следует
 * обновлять при каждом прилете нового тага. Класс RowTagForDataGridView обеспечивает нужное поведение записи в таблице.
 * При обновлении тага в строке, сбрасывается таймер с определенным интервалом и строка считается активной. Если обновления
 * не произошло, строка по таймеру становится не активной.
 * 
 * Удаление строк происходит вызовом метода RemoveOldRecords таймером из контекста формы, где таблица отображается.
 * Самостоятельное удаление не получается пока, тк не могу правильно деллигировать это другому контексту и получаю ошибку:
 * 
 * An exception of type 'System.InvalidOperationException' occurred in System.Windows.Forms.dll but was not handled in user code
 * Недопустимая операция в нескольких потоках: попытка доступа к элементу управления 'dgvPerson' не из того потока, в котором он был создан.
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridViewPersonTag : DataGridView
    {

        Dictionary<(String,String), RowTagForDataGridView> dicRowsPersonTID;

        public DataGridViewPersonTag():base()
        {
            dicRowsPersonTID = new Dictionary<(string, string), RowTagForDataGridView>();
        }

        public void RemoveOldRecords()
        {

            List<(string, string)> removals = new List<(string, string)>();

            lock (dicRowsPersonTID)
            {
                foreach (KeyValuePair<(string, string), RowTagForDataGridView> entry in dicRowsPersonTID)
                    if (!entry.Value.active)
                        removals.Add(entry.Key);

                foreach ((string, string) key in removals)
                {
                    Rows.Remove(dicRowsPersonTID[key]);
                    dicRowsPersonTID.Remove(key);   
                }
            }
        }

        public void ClearData()
        {
            lock (dicRowsPersonTID)
            {
                dicRowsPersonTID.Clear();
                Rows.Clear();
            }
        }

        public void UpdateTag(TagDT tagdt)
        {

            RowTagForDataGridView row = SearchRowByTID(tagdt.tag.TID);

            if (row != null)
            {
                row.UpdateTag(tagdt);
            } 
            else
            {
                lock (dicRowsPersonTID)
                {
                    Program.command.CommandText = $"SELECT * FROM Person WHERE tid1 = '{tagdt.tag.TID}' OR tid2 = '{tagdt.tag.TID}'";
                    DataTable data = new DataTable();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(Program.command);
                    adapter.Fill(data);

                    row = new RowTagForDataGridView(this, tagdt);
                    (string, string) key = ("", "");

                    if (data.Rows.Count == 0)
                    {
                        row.CreateCells(this, new object[] { tagdt.tag.TID });
                        key.Item1 = tagdt.tag.TID;
                    }
                    else
                    {
                        DataRow rowDB = data.Rows[0];
                        row.CreateCells(this, new object[] {
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

                        key.Item1 = rowDB.Field<string>("tid1");
                        key.Item2 = rowDB.Field<string>("tid2");
                    }


                    Rows.Add(row);
                    dicRowsPersonTID.Add(key, row);
                }
            }
        }

        private RowTagForDataGridView SearchRowByTID(string searchValue)
        {

            RowTagForDataGridView row = null;

            foreach (KeyValuePair<(string, string), RowTagForDataGridView> entry in dicRowsPersonTID)
            {
                if(entry.Key.Item1 == searchValue || entry.Key.Item2 == searchValue)
                {
                    row = entry.Value;
                }
            }

            return row;
        }
    }
}
