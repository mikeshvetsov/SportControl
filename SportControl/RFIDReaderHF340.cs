using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportControl
{
    public class RFIDReaderHF340 : RFIDReaderAPI.Interface.IAsynchronousMessage
    {
        public string ip;
        public Boolean isConnected = false;
        Int32 antNUM = 0;
        private eAntennaNo antNo;
        private eReadType readType = eReadType.Inventory;
        Func<TagDT, bool> TagHandler;

        public RFIDReaderHF340(Func<TagDT, bool> TagHandler)
        {
            this.TagHandler = TagHandler;
        }

        public Boolean Connect(string ip, Int32 antNUM, eAntennaNo antNo)
        {
            //ip = "COM4:115200";
            this.ip = ip;
            this.antNo = antNo;
            this.antNUM = antNUM;

            isConnected = RFIDReader.CreateTcpConn(ip, this);
            // isConnected = RFIDReader.CreateSerialConn(ip, this);
            if (isConnected && !RFIDReader.CheckConnect(ip))
            {
                RFIDReader.CloseConn(ip);
                isConnected = false;
            }

            return isConnected;
        }

        public void Disconnect()
        {
            RFIDReader._Tag6C.Stop(ip);
            RFIDReader.CloseConn(ip);
            isConnected = false;
        }

        public void Read_EPCTID()
        {

            if (!isConnected)
                return;

            RFIDReader._RFIDConfig.Stop(ip);
            RFIDReaderAPI.RFIDReader.DIC_CONNECT[ip].ClearTagData();

            int st = RFIDReader._Tag6C.GetEPC_TID(ip, antNo, readType);

            if (st != 0)
            {
                Console.WriteLine("Read_EPCTID: ERROR " + st.ToString());
                return;
            }
        }

        #region interface implement
        // Tag CallBack
        public void OutPutTags(RFIDReaderAPI.Models.Tag_Model tag)
        {
            if (tag == null || tag.Result != 0x00)
                return;

            TagDT tagdt = new TagDT(tag, DateTime.Now);
            TagHandler(tagdt);
        }
        public void WriteDebugMsg(string msg)
        {
            // Console.WriteLine("WriteDebugMsg: " + msg);
        }
        public void WriteLog(string msg)
        {
            Console.WriteLine("WriteLog!");
        }
        public void PortConneting(string connID)
        {
            Console.WriteLine("PortConneting!");
        }
        public void PortClosing(string connID)
        {
            Console.WriteLine("PortClosing!");
        }
        public void OutPutTagsOver()
        {
            Console.WriteLine("OutPutTagsOver!");
        }
        public void GPIControlMsg(RFIDReaderAPI.Models.GPI_Model gpiModel)
        {
            Console.WriteLine("GPIControlMsg!");
        }

        public void PortConnecting(string connID)
        {
            Console.WriteLine("PortConnecting!");
            throw new NotImplementedException();
        }

        public void EventUpload(RFIDReaderAPI.Models.CallBackEnum type, object param)
        {
            Console.WriteLine("EventUpload!");
            throw new NotImplementedException();
        }
        #endregion

        ~RFIDReaderHF340() { }
    }

}
