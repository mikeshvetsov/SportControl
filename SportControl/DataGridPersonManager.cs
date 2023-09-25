using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridPersonManager
    {
        Dictionary<String, DataGridViewRowTag> dicRowsPersonTID1;
        Dictionary<String, DataGridViewRowTag> dicRowsPersonTID2;
        DataGridView dgv;

        public DataGridPersonManager(DataGridView dgv)
        {
            dicRowsPersonTID1 = new Dictionary<string, DataGridViewRowTag>();
            dicRowsPersonTID2 = new Dictionary<string, DataGridViewRowTag>();
            this.dgv = dgv;
        }

        public DataGridViewRowTag UpdateTag(TagDT tagdt)
        {

            String key = tagdt.tag.TID;
            DataGridViewRowTag Row = null;

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
                            Row = new DataGridViewRowTag(dgv, tagdt);
                            dicRowsPersonTID1.Add(key, Row);

                            Row.CreateCells(dgv, new object[] {tagdt.tag.TID});
                            dgv.Rows.Add(Row);
                        }
                    }
                }
            }

            return null;
        }
    }
}
