/*
 * DataGridViewPersonTag - таблица отображающая метки в поле антены.
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridViewPersonTag : DataGridView
    {
        /* 
         * У каждого частника может быть две метки. Поэтому два словаря, каждый привязывает строку к одной метке.
         * Один словарь связывает строку с меткой1, второй с меткой2.
         * 
         */
        Dictionary<String, RowTagForDataGridView> dicRowsPersonTID1;
        Dictionary<String, RowTagForDataGridView> dicRowsPersonTID2;

        public DataGridViewPersonTag():base()
        {
            dicRowsPersonTID1 = new Dictionary<string, RowTagForDataGridView>();
            dicRowsPersonTID2 = new Dictionary<string, RowTagForDataGridView>();
        }

        public void RemoveOldRecords()
        {

            List<RowTagForDataGridView> removals = new List<RowTagForDataGridView>();
            String key1, key2;

            foreach (RowTagForDataGridView row in Rows)
            {
                if (!row.active)
                {
                    removals.Add(row);
                }
            }

            foreach (RowTagForDataGridView row in removals)
            {
                key1 = row.Cells["TID1"].Value?.ToString();
                key2 = row.Cells["TID2"].Value?.ToString();
                Rows.Remove(row);

                lock (dicRowsPersonTID1)
                {
                    if (key1 != null && dicRowsPersonTID1.ContainsKey(key1))
                    {
                        dicRowsPersonTID1.Remove(key1);
                    }
                }

                lock (dicRowsPersonTID2)
                {
                    if (key2 != null && dicRowsPersonTID2.ContainsKey(key2))
                    {
                        dicRowsPersonTID2.Remove(key2);
                    }
                }
            }

        }

        public void UpdateTag(TagDT tagdt)
        {

            String key = tagdt.tag.TID;
            RowTagForDataGridView Row = null;

            lock (dicRowsPersonTID2)
            {
                if (dicRowsPersonTID2.ContainsKey(key))
                {
                    Row = dicRowsPersonTID2[key];
                    Row.UpdateTag(tagdt);
                }
                else
                {
                    lock (dicRowsPersonTID1)
                    {
                        if (dicRowsPersonTID1.ContainsKey(key))
                        {
                            Row = dicRowsPersonTID1[key];
                            Row.UpdateTag(tagdt);
                        }
                        else
                        {
                            Row = new RowTagForDataGridView(this, tagdt);
                            dicRowsPersonTID1.Add(key, Row);

                            Row.CreateCells(this, new object[] { tagdt.tag.TID });
                            Rows.Add(Row);
                        }
                    }
                }
            }
        }
    }
}
