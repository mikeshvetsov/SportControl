
namespace SportControl
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_Edit = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_TID1 = new System.Windows.Forms.TextBox();
            this.textBox_TID2 = new System.Windows.Forms.TextBox();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.textBox_SecondName = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button_SavePerson = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_Race1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Race2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Race3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Race4 = new System.Windows.Forms.CheckBox();
            this.checkBox_Race5 = new System.Windows.Forms.CheckBox();
            this.dgvPerson = new SportControl.DataGridViewPersonTag();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox_ant = new System.Windows.Forms.GroupBox();
            this.checkBox_ant4 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant3 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant2 = new System.Windows.Forms.CheckBox();
            this.checkBox_ant1 = new System.Windows.Forms.CheckBox();
            this.button_Read = new System.Windows.Forms.Button();
            this.maskedTextBox_reader_ip = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_Simulator = new System.Windows.Forms.CheckBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.numericUpDown_reader_port = new System.Windows.Forms.NumericUpDown();
            this.timerRemoveOldRecords = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sourceForDGVPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_PersonDataSource = new System.Windows.Forms.ToolStripComboBox();
            this.TID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Race1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Race2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Race3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Race4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Race5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_SelectRace = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel_Edit);
            this.tabPage1.Controls.Add(this.dgvPerson);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Edit
            // 
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_TID1);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_TID2);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_Num);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_SecondName);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_Name);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_Age);
            this.flowLayoutPanel_Edit.Controls.Add(this.textBox_ID);
            this.flowLayoutPanel_Edit.Controls.Add(this.button_SavePerson);
            this.flowLayoutPanel_Edit.Controls.Add(this.button_Clear);
            this.flowLayoutPanel_Edit.Controls.Add(this.label1);
            this.flowLayoutPanel_Edit.Controls.Add(this.checkBox_Race1);
            this.flowLayoutPanel_Edit.Controls.Add(this.checkBox_Race2);
            this.flowLayoutPanel_Edit.Controls.Add(this.checkBox_Race3);
            this.flowLayoutPanel_Edit.Controls.Add(this.checkBox_Race4);
            this.flowLayoutPanel_Edit.Controls.Add(this.checkBox_Race5);
            this.flowLayoutPanel_Edit.Location = new System.Drawing.Point(8, 555);
            this.flowLayoutPanel_Edit.Name = "flowLayoutPanel_Edit";
            this.flowLayoutPanel_Edit.Size = new System.Drawing.Size(1256, 61);
            this.flowLayoutPanel_Edit.TabIndex = 42;
            // 
            // textBox_TID1
            // 
            this.textBox_TID1.Location = new System.Drawing.Point(3, 3);
            this.textBox_TID1.Name = "textBox_TID1";
            this.textBox_TID1.Size = new System.Drawing.Size(254, 20);
            this.textBox_TID1.TabIndex = 33;
            // 
            // textBox_TID2
            // 
            this.textBox_TID2.Location = new System.Drawing.Point(263, 3);
            this.textBox_TID2.Name = "textBox_TID2";
            this.textBox_TID2.Size = new System.Drawing.Size(264, 20);
            this.textBox_TID2.TabIndex = 34;
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(533, 3);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.Size = new System.Drawing.Size(71, 20);
            this.textBox_Num.TabIndex = 35;
            // 
            // textBox_SecondName
            // 
            this.textBox_SecondName.Location = new System.Drawing.Point(610, 3);
            this.textBox_SecondName.Name = "textBox_SecondName";
            this.textBox_SecondName.Size = new System.Drawing.Size(181, 20);
            this.textBox_SecondName.TabIndex = 36;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(797, 3);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(182, 20);
            this.textBox_Name.TabIndex = 37;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(985, 3);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(37, 20);
            this.textBox_Age.TabIndex = 40;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(1028, 3);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(58, 20);
            this.textBox_ID.TabIndex = 39;
            // 
            // button_SavePerson
            // 
            this.button_SavePerson.Location = new System.Drawing.Point(1092, 3);
            this.button_SavePerson.Name = "button_SavePerson";
            this.button_SavePerson.Size = new System.Drawing.Size(75, 23);
            this.button_SavePerson.TabIndex = 38;
            this.button_SavePerson.Text = "Сохранить";
            this.button_SavePerson.UseVisualStyleBackColor = true;
            this.button_SavePerson.Click += new System.EventHandler(this.button_SavePerson_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(1173, 3);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 41;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Заезд";
            // 
            // checkBox_Race1
            // 
            this.checkBox_Race1.AutoSize = true;
            this.checkBox_Race1.Location = new System.Drawing.Point(47, 32);
            this.checkBox_Race1.Name = "checkBox_Race1";
            this.checkBox_Race1.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Race1.TabIndex = 42;
            this.checkBox_Race1.Text = "1";
            this.checkBox_Race1.UseVisualStyleBackColor = true;
            // 
            // checkBox_Race2
            // 
            this.checkBox_Race2.AutoSize = true;
            this.checkBox_Race2.Location = new System.Drawing.Point(85, 32);
            this.checkBox_Race2.Name = "checkBox_Race2";
            this.checkBox_Race2.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Race2.TabIndex = 43;
            this.checkBox_Race2.Text = "2";
            this.checkBox_Race2.UseVisualStyleBackColor = true;
            // 
            // checkBox_Race3
            // 
            this.checkBox_Race3.AutoSize = true;
            this.checkBox_Race3.Location = new System.Drawing.Point(123, 32);
            this.checkBox_Race3.Name = "checkBox_Race3";
            this.checkBox_Race3.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Race3.TabIndex = 44;
            this.checkBox_Race3.Text = "3";
            this.checkBox_Race3.UseVisualStyleBackColor = true;
            // 
            // checkBox_Race4
            // 
            this.checkBox_Race4.AutoSize = true;
            this.checkBox_Race4.Location = new System.Drawing.Point(161, 32);
            this.checkBox_Race4.Name = "checkBox_Race4";
            this.checkBox_Race4.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Race4.TabIndex = 45;
            this.checkBox_Race4.Text = "4";
            this.checkBox_Race4.UseVisualStyleBackColor = true;
            // 
            // checkBox_Race5
            // 
            this.checkBox_Race5.AutoSize = true;
            this.checkBox_Race5.Location = new System.Drawing.Point(199, 32);
            this.checkBox_Race5.Name = "checkBox_Race5";
            this.checkBox_Race5.Size = new System.Drawing.Size(32, 17);
            this.checkBox_Race5.TabIndex = 46;
            this.checkBox_Race5.Text = "5";
            this.checkBox_Race5.UseVisualStyleBackColor = true;
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TID1,
            this.TID2,
            this.RacingNumber,
            this.SecondName,
            this.FirstName,
            this.Age,
            this.ID,
            this.Race1,
            this.Race2,
            this.Race3,
            this.Race4,
            this.Race5,
            this.DT});
            this.dgvPerson.Location = new System.Drawing.Point(3, 30);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.ReadOnly = true;
            this.dgvPerson.RowHeadersWidth = 25;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(1333, 519);
            this.dgvPerson.TabIndex = 32;
            this.dgvPerson.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPerson_CellMouseDoubleClick);
            this.dgvPerson.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPerson_RowPostPaint);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox_ant);
            this.tabPage3.Controls.Add(this.button_Read);
            this.tabPage3.Controls.Add(this.maskedTextBox_reader_ip);
            this.tabPage3.Controls.Add(this.checkBox_Simulator);
            this.tabPage3.Controls.Add(this.button_disconnect);
            this.tabPage3.Controls.Add(this.button_connect);
            this.tabPage3.Controls.Add(this.numericUpDown_reader_port);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1342, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox_ant
            // 
            this.groupBox_ant.Controls.Add(this.checkBox_ant4);
            this.groupBox_ant.Controls.Add(this.checkBox_ant3);
            this.groupBox_ant.Controls.Add(this.checkBox_ant2);
            this.groupBox_ant.Controls.Add(this.checkBox_ant1);
            this.groupBox_ant.Location = new System.Drawing.Point(11, 38);
            this.groupBox_ant.Name = "groupBox_ant";
            this.groupBox_ant.Size = new System.Drawing.Size(228, 48);
            this.groupBox_ant.TabIndex = 30;
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
            this.button_Read.Location = new System.Drawing.Point(587, 51);
            this.button_Read.Margin = new System.Windows.Forms.Padding(1);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(86, 23);
            this.button_Read.TabIndex = 31;
            this.button_Read.Text = "Читать";
            this.button_Read.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(256, 55);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(88, 20);
            this.maskedTextBox_reader_ip.TabIndex = 27;
            this.maskedTextBox_reader_ip.Text = "192.168.1.116";
            // 
            // checkBox_Simulator
            // 
            this.checkBox_Simulator.AutoSize = true;
            this.checkBox_Simulator.Location = new System.Drawing.Point(411, 57);
            this.checkBox_Simulator.Name = "checkBox_Simulator";
            this.checkBox_Simulator.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Simulator.TabIndex = 26;
            this.checkBox_Simulator.Text = "Симулятор";
            this.checkBox_Simulator.UseVisualStyleBackColor = true;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(677, 51);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(85, 23);
            this.button_disconnect.TabIndex = 29;
            this.button_disconnect.Text = "Отключить";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(498, 51);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(85, 23);
            this.button_connect.TabIndex = 25;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(350, 56);
            this.numericUpDown_reader_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_reader_port.Name = "numericUpDown_reader_port";
            this.numericUpDown_reader_port.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_reader_port.TabIndex = 28;
            this.numericUpDown_reader_port.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
            // 
            // timerRemoveOldRecords
            // 
            this.timerRemoveOldRecords.Enabled = true;
            this.timerRemoveOldRecords.Interval = 1000;
            this.timerRemoveOldRecords.Tick += new System.EventHandler(this.timerRemoveOldRecords_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceForDGVPersonToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllRacesToolStripMenuItem,
            this.toolStripSeparator1,
            this.SelectRaceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Участники";
            // 
            // clearAllRacesToolStripMenuItem
            // 
            this.clearAllRacesToolStripMenuItem.Name = "clearAllRacesToolStripMenuItem";
            this.clearAllRacesToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.clearAllRacesToolStripMenuItem.Text = "Очистить заезды всех в базе";
            this.clearAllRacesToolStripMenuItem.Click += new System.EventHandler(this.clearAllRacesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // sourceForDGVPersonToolStripMenuItem
            // 
            this.sourceForDGVPersonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_PersonDataSource});
            this.sourceForDGVPersonToolStripMenuItem.Name = "sourceForDGVPersonToolStripMenuItem";
            this.sourceForDGVPersonToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.sourceForDGVPersonToolStripMenuItem.Text = "Источник данных";
            // 
            // toolStripComboBox_PersonDataSource
            // 
            this.toolStripComboBox_PersonDataSource.Items.AddRange(new object[] {
            "Файл",
            "Считыватель"});
            this.toolStripComboBox_PersonDataSource.Name = "toolStripComboBox_PersonDataSource";
            this.toolStripComboBox_PersonDataSource.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_PersonDataSource.SelectedIndexChanged += new System.EventHandler(this.comboBox_PersonDataSource_SelectedValueChanged);
            // 
            // TID1
            // 
            this.TID1.HeaderText = "TID1";
            this.TID1.Name = "TID1";
            this.TID1.ReadOnly = true;
            this.TID1.Width = 250;
            // 
            // TID2
            // 
            this.TID2.HeaderText = "TID2";
            this.TID2.Name = "TID2";
            this.TID2.ReadOnly = true;
            this.TID2.Width = 250;
            // 
            // RacingNumber
            // 
            this.RacingNumber.HeaderText = "Номер";
            this.RacingNumber.Name = "RacingNumber";
            this.RacingNumber.ReadOnly = true;
            this.RacingNumber.Width = 50;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Фамилия";
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 200;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Age.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Race1
            // 
            this.Race1.HeaderText = "1";
            this.Race1.Name = "Race1";
            this.Race1.ReadOnly = true;
            this.Race1.Width = 20;
            // 
            // Race2
            // 
            this.Race2.HeaderText = "2";
            this.Race2.Name = "Race2";
            this.Race2.ReadOnly = true;
            this.Race2.Width = 20;
            // 
            // Race3
            // 
            this.Race3.HeaderText = "3";
            this.Race3.Name = "Race3";
            this.Race3.ReadOnly = true;
            this.Race3.Width = 20;
            // 
            // Race4
            // 
            this.Race4.HeaderText = "4";
            this.Race4.Name = "Race4";
            this.Race4.ReadOnly = true;
            this.Race4.Width = 20;
            // 
            // Race5
            // 
            this.Race5.HeaderText = "5";
            this.Race5.Name = "Race5";
            this.Race5.ReadOnly = true;
            this.Race5.Width = 20;
            // 
            // DT
            // 
            this.DT.HeaderText = "Дата";
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            this.DT.Width = 130;
            // 
            // SelectRaceToolStripMenuItem
            // 
            this.SelectRaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_SelectRace});
            this.SelectRaceToolStripMenuItem.Name = "SelectRaceToolStripMenuItem";
            this.SelectRaceToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.SelectRaceToolStripMenuItem.Text = "Выбрать заезд";
            // 
            // toolStripComboBox_SelectRace
            // 
            this.toolStripComboBox_SelectRace.Items.AddRange(new object[] {
            "Все",
            "Заезд 1",
            "Заезд 2",
            "Заезд 3",
            "Заезд 4",
            "Заезд 5"});
            this.toolStripComboBox_SelectRace.Name = "toolStripComboBox_SelectRace";
            this.toolStripComboBox_SelectRace.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox_SelectRace.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectRace_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel_Edit.ResumeLayout(false);
            this.flowLayoutPanel_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox_Simulator;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.GroupBox groupBox_ant;
        private System.Windows.Forms.CheckBox checkBox_ant4;
        private System.Windows.Forms.CheckBox checkBox_ant3;
        private System.Windows.Forms.CheckBox checkBox_ant2;
        private System.Windows.Forms.CheckBox checkBox_ant1;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.NumericUpDown numericUpDown_reader_port;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_reader_ip;
        private DataGridViewPersonTag dgvPerson;
        private System.Windows.Forms.Timer timerRemoveOldRecords;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SecondName;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.TextBox textBox_TID2;
        private System.Windows.Forms.TextBox textBox_TID1;
        private System.Windows.Forms.Button button_SavePerson;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Edit;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Race1;
        private System.Windows.Forms.CheckBox checkBox_Race2;
        private System.Windows.Forms.CheckBox checkBox_Race3;
        private System.Windows.Forms.CheckBox checkBox_Race4;
        private System.Windows.Forms.CheckBox checkBox_Race5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sourceForDGVPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_PersonDataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Race1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Race2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Race3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Race4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Race5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT;
        private System.Windows.Forms.ToolStripMenuItem SelectRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SelectRace;
    }
}