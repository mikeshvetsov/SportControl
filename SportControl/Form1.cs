using RFIDReaderAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportControl
{
    public partial class Form1 : Form
    {
        public RFIDReaderHF340 hf340;
        public BindingList<Person> Racers;

        public Form1()
        {
            InitializeComponent();
            hf340 = new RFIDReaderHF340(TagHandler: TagHandler);
        }


        private void text_ip_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public bool isStringIP(string str)
        {
            var rx = new Regex("^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (rx.IsMatch(str))
                return true;

            return false;
        }

        private void text_ip_TextChanged(object sender, EventArgs e)
        {

            MaskedTextBox text_ipObj = (MaskedTextBox)sender;

            if (!isStringIP(text_ipObj.Text))
            {
                text_ipObj.ForeColor = Color.Red;
                text_ipObj.Tag = false;
               
            }
            else
            {
                text_ipObj.ForeColor = Color.Black;
                text_ipObj.Tag = true;
            }

        }

        private bool TagHandler(string epc, string tid, long t)
        {
            Console.WriteLine("EPC:" + epc + " - TID:" + tid + " Time: " + t.ToString());

            if (Racers is null)
            {
                if (InvokeRequired)
                {
                    Racers = new BindingList<Person> { new Person() { EPC = epc, TID = tid, time = t, count = 0 } };
                    this.Invoke(new Action(() => dataGridView_tag.DataSource = Racers));

                }
            }
            else
            {
                if (InvokeRequired)
                    this.Invoke(new Action(() => {
    
                        var person = Racers.SingleOrDefault(p => p.TID == tid);
                        if (person is null)
                            Racers.Add(new Person() { EPC = epc, TID = tid, time = t, count = 0 });
                        else
                        {
                            person.count += 1;
                            dataGridView_tag.Update();
                            dataGridView_tag.Refresh();
                        }

                    })) ;
            }

            return true;
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            Boolean res;
            string ip = maskedTextBox_reader_ip.Text.Trim() + ":" + numericUpDown_reader_port.Value.ToString();
            #region Get antenna number & single reading/cyclic reading
            Int32 antNUM = 0;
            eAntennaNo antNo = eAntennaNo._1;
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


            label_connection_status.Text = "Подключение ...";
            res = hf340.Connect(ip, antNUM, antNo);

            if (res)
               label_connection_status.Text = "Подключен";
            else
                label_connection_status.Text = "Отключен";
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            hf340.Disconnect();
            label_connection_status.Text = "Отключен";
        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            hf340.Read_EPCTID();
        }

    }

    public class RFIDReaderHF340 : RFIDReaderAPI.Interface.IAsynchronousMessage
    {
        public string ip;
        public Boolean isConnected = false;
        Int32 antNUM = 0;
        private eAntennaNo antNo;
        private eReadType readType = eReadType.Inventory;
        Func<string, string, long, bool> TagHandler;

        public RFIDReaderHF340(Func<string, string, long, bool> TagHandler)
        {
            this.TagHandler = TagHandler;
        }

        public Boolean Connect(string ip, Int32 antNUM, eAntennaNo antNo)
        {
            this.ip = ip;
            this.antNo = antNo;
            this.antNUM = antNUM;

            isConnected = RFIDReader.CreateTcpConn(ip, this);
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

            if (st != 0) {
                Console.WriteLine("Read_EPCTID: ERROR " + st.ToString()); 
                return; 
            }
        }

        #region interface implement
        // Tag CallBack
        public void OutPutTags(RFIDReaderAPI.Models.Tag_Model tag)
        {
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            TagHandler(tag.EPC, tag.TID, milliseconds);
           // Console.WriteLine("EPC:" + tag.EPC + " - TID:" + tag.TID + " Time: " + milliseconds.ToString());
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
