using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportControl
{
    public class TagDT
    {
        public RFIDReaderAPI.Models.Tag_Model tag;
        public DateTime dt;

        public TagDT(RFIDReaderAPI.Models.Tag_Model tag, DateTime dt)
        {
            this.tag = tag;
            this.dt = dt;
        }
    }
}
