
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
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimePoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestCycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAX_RSSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_MAX_RSSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Racing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_TimeFormOpen = new System.Windows.Forms.Button();
            this.button_StartRace = new System.Windows.Forms.Button();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.label_TimeRace = new System.Windows.Forms.Label();
            this.button_StopRace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.button_OnStart = new System.Windows.Forms.Button();
            this.dataGridView_RacerData = new System.Windows.Forms.DataGridView();
            this.CycleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleDeltaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_race = new System.Windows.Forms.Timer(this.components);
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Finished = new System.Windows.Forms.Button();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.checkBox_Simulator = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Racers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RacerData)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(6, 745);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_reader_ip.TabIndex = 0;
            this.maskedTextBox_reader_ip.Text = "192.168.1.116";
            this.maskedTextBox_reader_ip.TextChanged += new System.EventHandler(this.text_ip_TextChanged);
            this.maskedTextBox_reader_ip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_ip_KeyPress);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(161, 745);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 23);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(100, 745);
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
            this.label_connection_status.Location = new System.Drawing.Point(12, 3);
            this.label_connection_status.Name = "label_connection_status";
            this.label_connection_status.Size = new System.Drawing.Size(57, 13);
            this.label_connection_status.TabIndex = 4;
            this.label_connection_status.Text = "Отключен";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(340, 745);
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
            this.groupBox_ant.Location = new System.Drawing.Point(6, 774);
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
            this.button_Read.Location = new System.Drawing.Point(250, 745);
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
            this.CycleTime,
            this.TimePoint,
            this.BestCycleTime,
            this.BestCycle,
            this.MAX_RSSI,
            this.DT_MAX_RSSI,
            this.Racing});
            this.dataGridView_Racers.Location = new System.Drawing.Point(11, 27);
            this.dataGridView_Racers.Name = "dataGridView_Racers";
            this.dataGridView_Racers.ReadOnly = true;
            this.dataGridView_Racers.RowHeadersWidth = 25;
            this.dataGridView_Racers.Size = new System.Drawing.Size(834, 692);
            this.dataGridView_Racers.TabIndex = 8;
            this.dataGridView_Racers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Racers_CellContentClick);
            this.dataGridView_Racers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Racers_RowEnter);
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.ReadOnly = true;
            this.TID.Width = 250;
            // 
            // EPC
            // 
            this.EPC.HeaderText = "Номер (EPC)";
            this.EPC.Name = "EPC";
            this.EPC.ReadOnly = true;
            this.EPC.Width = 150;
            // 
            // Count
            // 
            this.Count.HeaderText = "Круг";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 50;
            // 
            // CycleTime
            // 
            this.CycleTime.HeaderText = "Время круга";
            this.CycleTime.Name = "CycleTime";
            this.CycleTime.ReadOnly = true;
            // 
            // TimePoint
            // 
            this.TimePoint.HeaderText = "Время";
            this.TimePoint.Name = "TimePoint";
            this.TimePoint.ReadOnly = true;
            // 
            // BestCycleTime
            // 
            this.BestCycleTime.HeaderText = "Лучшее время";
            this.BestCycleTime.Name = "BestCycleTime";
            this.BestCycleTime.ReadOnly = true;
            // 
            // BestCycle
            // 
            this.BestCycle.HeaderText = "Лучший круг";
            this.BestCycle.Name = "BestCycle";
            this.BestCycle.ReadOnly = true;
            this.BestCycle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MAX_RSSI
            // 
            this.MAX_RSSI.HeaderText = "MAX_RSSI";
            this.MAX_RSSI.Name = "MAX_RSSI";
            this.MAX_RSSI.ReadOnly = true;
            this.MAX_RSSI.Visible = false;
            // 
            // DT_MAX_RSSI
            // 
            this.DT_MAX_RSSI.HeaderText = "DT_MAX_RSSI";
            this.DT_MAX_RSSI.Name = "DT_MAX_RSSI";
            this.DT_MAX_RSSI.ReadOnly = true;
            this.DT_MAX_RSSI.Visible = false;
            // 
            // Racing
            // 
            this.Racing.HeaderText = "Учтен";
            this.Racing.Name = "Racing";
            this.Racing.ReadOnly = true;
            this.Racing.Width = 40;
            // 
            // button_TimeFormOpen
            // 
            this.button_TimeFormOpen.Location = new System.Drawing.Point(1219, 745);
            this.button_TimeFormOpen.Name = "button_TimeFormOpen";
            this.button_TimeFormOpen.Size = new System.Drawing.Size(75, 23);
            this.button_TimeFormOpen.TabIndex = 12;
            this.button_TimeFormOpen.Text = "Экран";
            this.button_TimeFormOpen.UseVisualStyleBackColor = true;
            this.button_TimeFormOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_StartRace
            // 
            this.button_StartRace.Location = new System.Drawing.Point(849, 745);
            this.button_StartRace.Name = "button_StartRace";
            this.button_StartRace.Size = new System.Drawing.Size(80, 23);
            this.button_StartRace.TabIndex = 13;
            this.button_StartRace.Text = "Старт Гонка";
            this.button_StartRace.UseVisualStyleBackColor = true;
            this.button_StartRace.Click += new System.EventHandler(this.button_StartRace_Click);
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Location = new System.Drawing.Point(180, 4);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(31, 13);
            this.label_TimeStart.TabIndex = 14;
            this.label_TimeStart.Text = "0000";
            // 
            // label_TimeRace
            // 
            this.label_TimeRace.AutoSize = true;
            this.label_TimeRace.Location = new System.Drawing.Point(423, 4);
            this.label_TimeRace.Name = "label_TimeRace";
            this.label_TimeRace.Size = new System.Drawing.Size(31, 13);
            this.label_TimeRace.TabIndex = 15;
            this.label_TimeRace.Text = "0000";
            // 
            // button_StopRace
            // 
            this.button_StopRace.Location = new System.Drawing.Point(935, 745);
            this.button_StopRace.Name = "button_StopRace";
            this.button_StopRace.Size = new System.Drawing.Size(75, 23);
            this.button_StopRace.TabIndex = 16;
            this.button_StopRace.Text = "Стоп Гонка";
            this.button_StopRace.UseVisualStyleBackColor = true;
            this.button_StopRace.Click += new System.EventHandler(this.button_StopRace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Время гонки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 4);
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
            this.button_OnStart.Location = new System.Drawing.Point(526, 745);
            this.button_OnStart.Name = "button_OnStart";
            this.button_OnStart.Size = new System.Drawing.Size(149, 23);
            this.button_OnStart.TabIndex = 18;
            this.button_OnStart.Text = "Участников На Старт!";
            this.button_OnStart.UseVisualStyleBackColor = true;
            this.button_OnStart.Click += new System.EventHandler(this.button_OnStart_Click);
            // 
            // dataGridView_RacerData
            // 
            this.dataGridView_RacerData.AllowUserToAddRows = false;
            this.dataGridView_RacerData.AllowUserToDeleteRows = false;
            this.dataGridView_RacerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RacerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CycleNum,
            this.CycleDeltaDT,
            this.CycleDT});
            this.dataGridView_RacerData.Location = new System.Drawing.Point(849, 27);
            this.dataGridView_RacerData.Name = "dataGridView_RacerData";
            this.dataGridView_RacerData.ReadOnly = true;
            this.dataGridView_RacerData.RowHeadersWidth = 25;
            this.dataGridView_RacerData.Size = new System.Drawing.Size(284, 692);
            this.dataGridView_RacerData.TabIndex = 20;
            // 
            // CycleNum
            // 
            this.CycleNum.HeaderText = "Номер";
            this.CycleNum.Name = "CycleNum";
            this.CycleNum.ReadOnly = true;
            this.CycleNum.Width = 50;
            // 
            // CycleDeltaDT
            // 
            this.CycleDeltaDT.HeaderText = "Время цикла";
            this.CycleDeltaDT.Name = "CycleDeltaDT";
            this.CycleDeltaDT.ReadOnly = true;
            // 
            // CycleDT
            // 
            this.CycleDT.HeaderText = "Время";
            this.CycleDT.Name = "CycleDT";
            this.CycleDT.ReadOnly = true;
            // 
            // timer_race
            // 
            this.timer_race.Tick += new System.EventHandler(this.timer_race_Tick);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(1138, 745);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 21;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Finished
            // 
            this.button_Finished.Location = new System.Drawing.Point(681, 745);
            this.button_Finished.Name = "button_Finished";
            this.button_Finished.Size = new System.Drawing.Size(108, 23);
            this.button_Finished.TabIndex = 22;
            this.button_Finished.Text = "Финишировал";
            this.button_Finished.UseVisualStyleBackColor = true;
            this.button_Finished.Click += new System.EventHandler(this.button_Finished_Click);
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(1138, 27);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(363, 692);
            this.textBox_Log.TabIndex = 23;
            // 
            // checkBox_Simulator
            // 
            this.checkBox_Simulator.AutoSize = true;
            this.checkBox_Simulator.Location = new System.Drawing.Point(6, 725);
            this.checkBox_Simulator.Name = "checkBox_Simulator";
            this.checkBox_Simulator.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Simulator.TabIndex = 24;
            this.checkBox_Simulator.Text = "Симулятор";
            this.checkBox_Simulator.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 861);
            this.Controls.Add(this.checkBox_Simulator);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.button_Finished);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.dataGridView_RacerData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TimeRace);
            this.Controls.Add(this.button_OnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TimeStart);
            this.Controls.Add(this.button_StartRace);
            this.Controls.Add(this.button_StopRace);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Racers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RacerData)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Button button_OnStart;
        private System.Windows.Forms.DataGridView dataGridView_RacerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleDeltaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleDT;
        private System.Windows.Forms.Timer timer_race;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Finished;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimePoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestCycleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAX_RSSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_MAX_RSSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Racing;
        private System.Windows.Forms.CheckBox checkBox_Simulator;
    }
}

