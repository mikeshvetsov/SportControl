
namespace SportControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maskedTextBox_reader_ip = new System.Windows.Forms.MaskedTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.numericUpDown_reader_port = new System.Windows.Forms.NumericUpDown();
            this.label_connection_status = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.groupBox_ant = new System.Windows.Forms.GroupBox();
            this.checkBox_ant4 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant1 = new System.Windows.Forms.CheckBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.dataGridView_Racers = new System.Windows.Forms.DataGridView();
            this.button_TimeFormOpen = new System.Windows.Forms.Button();
            this.button_StartRace = new System.Windows.Forms.Button();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label_TimeRace = new System.Windows.Forms.Label();
            this.button_StopRace = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_unixTimeNow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.button_OnStart = new System.Windows.Forms.Button();
            this.dataGridView_Tags = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX_RSSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_MAX_RSSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Racers)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tags)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(12, 12);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_reader_ip.TabIndex = 0;
            this.maskedTextBox_reader_ip.Text = "192.168.1.116";
            this.maskedTextBox_reader_ip.TextChanged += new System.EventHandler(this.text_ip_TextChanged);
            this.maskedTextBox_reader_ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_ip_KeyPress);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(167, 12);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(106, 12);
            this.numericUpDown_reader_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_reader_port.Name = "numericUpDown_reader_port";
            this.numericUpDown_reader_port.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_reader_port.TabIndex = 3;
            this.numericUpDown_reader_port.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // label_connection_status
            // 
            this.label_connection_status.AutoSize = true;
            this.label_connection_status.Location = new System.Drawing.Point(12, 47);
            this.label_connection_status.Name = "label_connection_status";
            this.label_connection_status.Size = new System.Drawing.Size(57, 13);
            this.label_connection_status.TabIndex = 4;
            this.label_connection_status.Text = "Отключен";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(346, 12);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(85, 23);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "Отключить";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // groupBox_ant
            // 
            this.groupBox_ant.Controls.Add(this.checkBox_ant4);
            this.groupBox_ant.Controls.Add(this.checkBox_ant3);
            this.groupBox_ant.Controls.Add(this.checkBox_ant2);
            this.groupBox_ant.Controls.Add(this.checkBox_ant1);
            this.groupBox_ant.Location = new System.Drawing.Point(456, 1);
            this.groupBox_ant.Name = "groupBox_ant";
            this.groupBox_ant.Size = new System.Drawing.Size(228, 48);
            this.groupBox_ant.TabIndex = 6;
            this.groupBox_ant.TabStop = false;
            this.groupBox_ant.Text = "Антены";
            // 
            // checkBox_ant4
            // 
            this.checkBox_ant4.AutoSize = true;
            this.checkBox_ant4.Location = new System.Drawing.Point(174, 19);
            this.checkBox_ant4.Name = "checkBox_ant4";
            this.checkBox_ant4.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant4.TabIndex = 3;
            this.checkBox_ant4.Tag = "8";
            this.checkBox_ant4.Text = "Ант4";
            this.checkBox_ant4.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant3
            // 
            this.checkBox_ant3.AutoSize = true;
            this.checkBox_ant3.Location = new System.Drawing.Point(118, 19);
            this.checkBox_ant3.Name = "checkBox_ant3";
            this.checkBox_ant3.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant3.TabIndex = 2;
            this.checkBox_ant3.Tag = "4";
            this.checkBox_ant3.Text = "Ант3";
            this.checkBox_ant3.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant2
            // 
            this.checkBox_ant2.AutoSize = true;
            this.checkBox_ant2.Location = new System.Drawing.Point(62, 19);
            this.checkBox_ant2.Name = "checkBox_ant2";
            this.checkBox_ant2.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant2.TabIndex = 1;
            this.checkBox_ant2.Tag = "2";
            this.checkBox_ant2.Text = "Ант2";
            this.checkBox_ant2.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant1
            // 
            this.checkBox_ant1.AutoSize = true;
            this.checkBox_ant1.Checked = true;
            this.checkBox_ant1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ant1.Location = new System.Drawing.Point(6, 19);
            this.checkBox_ant1.Name = "checkBox_ant1";
            this.checkBox_ant1.Size = new System.Drawing.Size(50, 17);
            this.checkBox_ant1.TabIndex = 0;
            this.checkBox_ant1.Tag = "1";
            this.checkBox_ant1.Text = "Ант1";
            this.checkBox_ant1.UseVisualStyleBackColor = true;
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(256, 12);
            this.button_Read.Margin = new System.Windows.Forms.Padding(1);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(86, 23);
            this.button_Read.TabIndex = 7;
            this.button_Read.Text = "Читать";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // dataGridView_Racers
            // 
            this.dataGridView_Racers.AllowUserToAddRows = false;
            this.dataGridView_Racers.AllowUserToDeleteRows = false;
            this.dataGridView_Racers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Racers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID,
            this.EPC,
            this.Count,
            this.TimePoint,
            this.MAX_RSSI,
            this.DT_MAX_RSSI});
            this.dataGridView_Racers.Location = new System.Drawing.Point(15, 77);
            this.dataGridView_Racers.Name = "dataGridView_Racers";
            this.dataGridView_Racers.ReadOnly = true;
            this.dataGridView_Racers.RowHeadersWidth = 25;
            this.dataGridView_Racers.Size = new System.Drawing.Size(714, 371);
            this.dataGridView_Racers.TabIndex = 8;
            // 
            // button_TimeFormOpen
            // 
            this.button_TimeFormOpen.Location = new System.Drawing.Point(976, 20);
            this.button_TimeFormOpen.Name = "button_TimeFormOpen";
            this.button_TimeFormOpen.Size = new System.Drawing.Size(75, 23);
            this.button_TimeFormOpen.TabIndex = 12;
            this.button_TimeFormOpen.Text = "Экран";
            this.button_TimeFormOpen.UseVisualStyleBackColor = true;
            this.button_TimeFormOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_StartRace
            // 
            this.button_StartRace.Location = new System.Drawing.Point(6, 19);
            this.button_StartRace.Name = "button_StartRace";
            this.button_StartRace.Size = new System.Drawing.Size(80, 23);
            this.button_StartRace.TabIndex = 13;
            this.button_StartRace.Text = "Старт";
            this.button_StartRace.UseVisualStyleBackColor = true;
            this.button_StartRace.Click += new System.EventHandler(this.button_StartRace_Click);
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Location = new System.Drawing.Point(92, 56);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(31, 13);
            this.label_TimeStart.TabIndex = 14;
            this.label_TimeStart.Text = "0000";
            // 
            // label_TimeRace
            // 
            this.label_TimeRace.AutoSize = true;
            this.label_TimeRace.Location = new System.Drawing.Point(92, 75);
            this.label_TimeRace.Name = "label_TimeRace";
            this.label_TimeRace.Size = new System.Drawing.Size(31, 13);
            this.label_TimeRace.TabIndex = 15;
            this.label_TimeRace.Text = "0000";
            // 
            // button_StopRace
            // 
            this.button_StopRace.Location = new System.Drawing.Point(95, 19);
            this.button_StopRace.Name = "button_StopRace";
            this.button_StopRace.Size = new System.Drawing.Size(75, 23);
            this.button_StopRace.TabIndex = 16;
            this.button_StopRace.Text = "Стоп";
            this.button_StopRace.UseVisualStyleBackColor = true;
            this.button_StopRace.Click += new System.EventHandler(this.button_StopRace_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_unixTimeNow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_StartRace);
            this.groupBox1.Controls.Add(this.label_TimeRace);
            this.groupBox1.Controls.Add(this.button_StopRace);
            this.groupBox1.Controls.Add(this.label_TimeStart);
            this.groupBox1.Location = new System.Drawing.Point(1074, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 133);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гонка";
            // 
            // label_unixTimeNow
            // 
            this.label_unixTimeNow.AutoSize = true;
            this.label_unixTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_unixTimeNow.Location = new System.Drawing.Point(3, 104);
            this.label_unixTimeNow.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label_unixTimeNow.Name = "label_unixTimeNow";
            this.label_unixTimeNow.Size = new System.Drawing.Size(70, 26);
            this.label_unixTimeNow.TabIndex = 19;
            this.label_unixTimeNow.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Время гонки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Время старта:";
            // 
            // timer_1s
            // 
            this.timer_1s.Interval = 1000;
            this.timer_1s.Tick += new System.EventHandler(this.Timer1SHandler);
            // 
            // button_OnStart
            // 
            this.button_OnStart.Location = new System.Drawing.Point(895, 20);
            this.button_OnStart.Name = "button_OnStart";
            this.button_OnStart.Size = new System.Drawing.Size(75, 23);
            this.button_OnStart.TabIndex = 18;
            this.button_OnStart.Text = "На Старт!";
            this.button_OnStart.UseVisualStyleBackColor = true;
            this.button_OnStart.Click += new System.EventHandler(this.button_OnStart_Click);
            // 
            // dataGridView_Tags
            // 
            this.dataGridView_Tags.AllowUserToAddRows = false;
            this.dataGridView_Tags.AllowUserToDeleteRows = false;
            this.dataGridView_Tags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_Tags.Location = new System.Drawing.Point(759, 77);
            this.dataGridView_Tags.Name = "dataGridView_Tags";
            this.dataGridView_Tags.ReadOnly = true;
            this.dataGridView_Tags.RowHeadersWidth = 25;
            this.dataGridView_Tags.Size = new System.Drawing.Size(481, 371);
            this.dataGridView_Tags.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "EPC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Width = 150;
            // 
            // EPC
            // 
            this.EPC.HeaderText = "EPC";
            this.EPC.Name = "EPC";
            this.EPC.ReadOnly = true;
            this.EPC.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 50;
            // 
            // TimePoint
            // 
            this.TimePoint.HeaderText = "Время круга";
            this.TimePoint.Name = "TimePoint";
            this.TimePoint.ReadOnly = true;
            // 
            // MAX_RSSI
            // 
            this.MAX_RSSI.HeaderText = "MAX_RSSI";
            this.MAX_RSSI.Name = "MAX_RSSI";
            this.MAX_RSSI.ReadOnly = true;
            // 
            // DT_MAX_RSSI
            // 
            this.DT_MAX_RSSI.HeaderText = "DT_MAX_RSSI";
            this.DT_MAX_RSSI.Name = "DT_MAX_RSSI";
            this.DT_MAX_RSSI.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 881);
            this.Controls.Add(this.dataGridView_Tags);
            this.Controls.Add(this.button_OnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_TimeFormOpen);
            this.Controls.Add(this.dataGridView_Racers);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.groupBox_ant);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.label_connection_status);
            this.Controls.Add(this.numericUpDown_reader_port);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.maskedTextBox_reader_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Racers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_reader_ip;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.NumericUpDown numericUpDown_reader_port;
        private System.Windows.Forms.Label label_connection_status;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.GroupBox groupBox_ant;
        private System.Windows.Forms.CheckBox checkBox_ant4;
        private System.Windows.Forms.CheckBox checkBox_ant3;
        private System.Windows.Forms.CheckBox checkBox_ant2;
        private System.Windows.Forms.CheckBox checkBox_ant1;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.DataGridView dataGridView_Racers;
        private System.Windows.Forms.Button button_TimeFormOpen;
        private System.Windows.Forms.Button button_StartRace;
        private System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label_TimeRace;
        private System.Windows.Forms.Button button_StopRace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_unixTimeNow;
        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Button button_OnStart;
        private System.Windows.Forms.DataGridView dataGridView_Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_RSSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_MAX_RSSI;
    }
}

