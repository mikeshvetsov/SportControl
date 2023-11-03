using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SportControl
{
    public class RFIDReaderHF340Simulator
    {
        List<string> TIDList = new List<string>() { "T12", "T13", "T17", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9" };

        Func<TagDT, bool> TagHandler;
        public Boolean isConnected = false;

        const double INTERVAL_MSG = 500;
        internal System.Timers.Timer timer;

        public RFIDReaderHF340Simulator(Func<TagDT, bool> TagHandler)
        {
            this.TagHandler = TagHandler;

            timer = new System.Timers.Timer(INTERVAL_MSG);
            timer.Elapsed += OutPutTags;
        }

        public Boolean Connect()
        {
            timer.Start();
            isConnected = true;
            return true;
        }

        public void Disconnect()
        {
            timer.Stop();
            isConnected = false;
        }


        // Tag CallBack
        public virtual void OutPutTags(object sender, ElapsedEventArgs e)
        {
            RFIDReaderAPI.Models.Tag_Model tag = new RFIDReaderAPI.Models.Tag_Model();

            Random rnd = new Random();
            int randIndex = rnd.Next(TIDList.Count);

            tag.TID = TIDList[randIndex];
            tag.EPC = "E321";
            tag.RSSI = 10;

            TagDT tagdt = new TagDT(tag, DateTime.Now);
            TagHandler(tagdt);

        }

    

        ~RFIDReaderHF340Simulator() { }
    }

}
