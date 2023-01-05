using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportControl
{
    public class Person
    {
        public string EPC { get; set; }
        public string TID { get; set; }
      //  public long time { get; set; }

        public int count { get; set; }

        public long unix_t { get; set; }
        public DateTime dt { get; set; }
        //public int H { get; set; }
        //public int M { get; set; }
        //public int S { get; set; }
        //public int MS { get; set; }
        public byte RSSI { get; set; }
        public byte minRSSI { get; set; }
        public byte maxRSSI { get; set; }

    }
}
