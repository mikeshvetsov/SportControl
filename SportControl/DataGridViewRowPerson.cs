using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportControl
{
    class DataGridViewRowPerson : DataGridViewRow
    {

        public Person Racer;

        public DataGridViewRowPerson(DataGridView dataGridView, TagDT tagdt)
        {
            this.CreateCells(dataGridView, new object[] { tagdt.tag.TID, tagdt.tag.EPC, 0 });
            Racer = new Person(tagdt);
        }
    }
}
