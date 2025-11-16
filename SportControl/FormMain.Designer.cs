
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPerson = new SportControl.DataGridViewPersonTag();
            this.dgvPersonActive = new SportControl.DataGridViewPersonTag();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllRacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectRaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_SelectRace = new System.Windows.Forms.ToolStripComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_FullLog = new System.Windows.Forms.CheckBox();
            this.textBox_log2 = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TimeRace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TimeStart = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.dgvRacerData = new System.Windows.Forms.DataGridView();
            this.CycleNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleDeltaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CycleDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_RaceStop = new System.Windows.Forms.Button();
            this.button_RaceStart = new System.Windows.Forms.Button();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.dgvRace = new SportControl.DataGridViewPersonTag();
            this.dgvRaceCellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellNuber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellCycleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaceCellBestTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.timerUpdateRaceView = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonActive)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRace)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox_ant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1899, 1576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1879, 1518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Регистрация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(8, 62);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPerson);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvPersonActive);
            this.splitContainer1.Size = new System.Drawing.Size(1863, 1449);
            this.splitContainer1.SplitterDistance = 755;
            this.splitContainer1.TabIndex = 44;
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
            this.dgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPerson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPerson.Location = new System.Drawing.Point(0, 0);
            this.dgvPerson.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPerson.MultiSelect = false;
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersWidth = 25;
            this.dgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPerson.Size = new System.Drawing.Size(1863, 755);
            this.dgvPerson.TabIndex = 33;
            this.dgvPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellContentClick);
            this.dgvPerson.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellEndEdit);
            this.dgvPerson.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerson_CellValueChanged);
            // 
            // dgvPersonActive
            // 
            this.dgvPersonActive.AllowUserToAddRows = false;
            this.dgvPersonActive.AllowUserToDeleteRows = false;
            this.dgvPersonActive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonActive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.Note});
            this.dgvPersonActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonActive.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPersonActive.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonActive.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvPersonActive.MultiSelect = false;
            this.dgvPersonActive.Name = "dgvPersonActive";
            this.dgvPersonActive.RowHeadersWidth = 25;
            this.dgvPersonActive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPersonActive.Size = new System.Drawing.Size(1863, 690);
            this.dgvPersonActive.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(8, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1863, 55);
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 45);
            this.toolStripMenuItem1.Text = "Участники";
            // 
            // clearAllRacesToolStripMenuItem
            // 
            this.clearAllRacesToolStripMenuItem.Name = "clearAllRacesToolStripMenuItem";
            this.clearAllRacesToolStripMenuItem.Size = new System.Drawing.Size(574, 54);
            this.clearAllRacesToolStripMenuItem.Text = "Очистить заезды всех в базе";
            this.clearAllRacesToolStripMenuItem.Click += new System.EventHandler(this.clearAllRacesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(571, 6);
            // 
            // SelectRaceToolStripMenuItem
            // 
            this.SelectRaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_SelectRace});
            this.SelectRaceToolStripMenuItem.Name = "SelectRaceToolStripMenuItem";
            this.SelectRaceToolStripMenuItem.Size = new System.Drawing.Size(574, 54);
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
            this.toolStripComboBox_SelectRace.Size = new System.Drawing.Size(121, 49);
            this.toolStripComboBox_SelectRace.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectRace_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox_FullLog);
            this.tabPage2.Controls.Add(this.textBox_log2);
            this.tabPage2.Controls.Add(this.textBox_log);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label_TimeRace);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label_TimeStart);
            this.tabPage2.Controls.Add(this.button_Save);
            this.tabPage2.Controls.Add(this.dgvRacerData);
            this.tabPage2.Controls.Add(this.button_RaceStop);
            this.tabPage2.Controls.Add(this.button_RaceStart);
            this.tabPage2.Controls.Add(this.comboBoxRace);
            this.tabPage2.Controls.Add(this.dgvRace);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1879, 1518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заезд";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox_FullLog
            // 
            this.checkBox_FullLog.AutoSize = true;
            this.checkBox_FullLog.Location = new System.Drawing.Point(2411, 930);
            this.checkBox_FullLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_FullLog.Name = "checkBox_FullLog";
            this.checkBox_FullLog.Size = new System.Drawing.Size(378, 36);
            this.checkBox_FullLog.TabIndex = 48;
            this.checkBox_FullLog.Text = "Включить полный вывод";
            this.checkBox_FullLog.UseVisualStyleBackColor = true;
            // 
            // textBox_log2
            // 
            this.textBox_log2.Location = new System.Drawing.Point(2411, 985);
            this.textBox_log2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox_log2.Multiline = true;
            this.textBox_log2.Name = "textBox_log2";
            this.textBox_log2.ReadOnly = true;
            this.textBox_log2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log2.Size = new System.Drawing.Size(1145, 371);
            this.textBox_log2.TabIndex = 47;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(2411, 124);
            this.textBox_log.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(1145, 762);
            this.textBox_log.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 1369);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 42;
            this.label3.Text = "Время гонки:";
            // 
            // label_TimeRace
            // 
            this.label_TimeRace.AutoSize = true;
            this.label_TimeRace.Location = new System.Drawing.Point(664, 1369);
            this.label_TimeRace.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_TimeRace.Name = "label_TimeRace";
            this.label_TimeRace.Size = new System.Drawing.Size(79, 32);
            this.label_TimeRace.TabIndex = 41;
            this.label_TimeRace.Text = "0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 1369);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Время старта:";
            // 
            // label_TimeStart
            // 
            this.label_TimeStart.AutoSize = true;
            this.label_TimeStart.Location = new System.Drawing.Point(243, 1369);
            this.label_TimeStart.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_TimeStart.Name = "label_TimeStart";
            this.label_TimeStart.Size = new System.Drawing.Size(79, 32);
            this.label_TimeStart.TabIndex = 39;
            this.label_TimeStart.Text = "0000";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(811, 7);
            this.button_Save.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(200, 55);
            this.button_Save.TabIndex = 38;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // dgvRacerData
            // 
            this.dgvRacerData.AllowUserToAddRows = false;
            this.dgvRacerData.AllowUserToDeleteRows = false;
            this.dgvRacerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacerData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CycleNum,
            this.CycleDeltaDT,
            this.CycleDT});
            this.dgvRacerData.Location = new System.Drawing.Point(1637, 124);
            this.dgvRacerData.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvRacerData.Name = "dgvRacerData";
            this.dgvRacerData.ReadOnly = true;
            this.dgvRacerData.RowHeadersWidth = 25;
            this.dgvRacerData.Size = new System.Drawing.Size(757, 1238);
            this.dgvRacerData.TabIndex = 37;
            // 
            // CycleNum
            // 
            this.CycleNum.HeaderText = "Номер";
            this.CycleNum.MinimumWidth = 12;
            this.CycleNum.Name = "CycleNum";
            this.CycleNum.ReadOnly = true;
            this.CycleNum.Width = 50;
            // 
            // CycleDeltaDT
            // 
            this.CycleDeltaDT.HeaderText = "Время цикла";
            this.CycleDeltaDT.MinimumWidth = 12;
            this.CycleDeltaDT.Name = "CycleDeltaDT";
            this.CycleDeltaDT.ReadOnly = true;
            this.CycleDeltaDT.Width = 250;
            // 
            // CycleDT
            // 
            this.CycleDT.HeaderText = "Время";
            this.CycleDT.MinimumWidth = 12;
            this.CycleDT.Name = "CycleDT";
            this.CycleDT.ReadOnly = true;
            this.CycleDT.Width = 250;
            // 
            // button_RaceStop
            // 
            this.button_RaceStop.Location = new System.Drawing.Point(595, 7);
            this.button_RaceStop.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_RaceStop.Name = "button_RaceStop";
            this.button_RaceStop.Size = new System.Drawing.Size(200, 55);
            this.button_RaceStop.TabIndex = 36;
            this.button_RaceStop.Text = "Стоп";
            this.button_RaceStop.UseVisualStyleBackColor = true;
            this.button_RaceStop.Click += new System.EventHandler(this.button_RaceStop_Click);
            // 
            // button_RaceStart
            // 
            this.button_RaceStart.Location = new System.Drawing.Point(379, 7);
            this.button_RaceStart.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_RaceStart.Name = "button_RaceStart";
            this.button_RaceStart.Size = new System.Drawing.Size(200, 55);
            this.button_RaceStart.TabIndex = 35;
            this.button_RaceStart.Text = "Старт!";
            this.button_RaceStart.UseVisualStyleBackColor = true;
            this.button_RaceStart.Click += new System.EventHandler(this.button_RaceStart_Click);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Заезд 1",
            "Заезд 2",
            "Заезд 3",
            "Заезд 4",
            "Заезд 5"});
            this.comboBoxRace.Location = new System.Drawing.Point(13, 7);
            this.comboBoxRace.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(316, 39);
            this.comboBoxRace.TabIndex = 34;
            this.comboBoxRace.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // dgvRace
            // 
            this.dgvRace.AllowUserToAddRows = false;
            this.dgvRace.AllowUserToDeleteRows = false;
            this.dgvRace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRaceCellID,
            this.dgvRaceCellNuber,
            this.dgvRaceCellName,
            this.dgvRaceCellDT,
            this.dgvRaceCellCycle,
            this.dgvRaceCellCycleTime,
            this.dgvRaceCellBestTime});
            this.dgvRace.Location = new System.Drawing.Point(13, 124);
            this.dgvRace.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvRace.MultiSelect = false;
            this.dgvRace.Name = "dgvRace";
            this.dgvRace.ReadOnly = true;
            this.dgvRace.RowHeadersWidth = 25;
            this.dgvRace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRace.Size = new System.Drawing.Size(1616, 1238);
            this.dgvRace.TabIndex = 33;
            this.dgvRace.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRace_RowEnter);
            // 
            // dgvRaceCellID
            // 
            this.dgvRaceCellID.HeaderText = "ID";
            this.dgvRaceCellID.MinimumWidth = 12;
            this.dgvRaceCellID.Name = "dgvRaceCellID";
            this.dgvRaceCellID.ReadOnly = true;
            this.dgvRaceCellID.Visible = false;
            this.dgvRaceCellID.Width = 80;
            // 
            // dgvRaceCellNuber
            // 
            this.dgvRaceCellNuber.HeaderText = "Номер";
            this.dgvRaceCellNuber.MinimumWidth = 12;
            this.dgvRaceCellNuber.Name = "dgvRaceCellNuber";
            this.dgvRaceCellNuber.ReadOnly = true;
            this.dgvRaceCellNuber.Width = 50;
            // 
            // dgvRaceCellName
            // 
            this.dgvRaceCellName.HeaderText = "Участник";
            this.dgvRaceCellName.MinimumWidth = 12;
            this.dgvRaceCellName.Name = "dgvRaceCellName";
            this.dgvRaceCellName.ReadOnly = true;
            this.dgvRaceCellName.Width = 200;
            // 
            // dgvRaceCellDT
            // 
            this.dgvRaceCellDT.HeaderText = "Дата";
            this.dgvRaceCellDT.MinimumWidth = 12;
            this.dgvRaceCellDT.Name = "dgvRaceCellDT";
            this.dgvRaceCellDT.ReadOnly = true;
            this.dgvRaceCellDT.Visible = false;
            this.dgvRaceCellDT.Width = 130;
            // 
            // dgvRaceCellCycle
            // 
            this.dgvRaceCellCycle.HeaderText = "Круг";
            this.dgvRaceCellCycle.MinimumWidth = 12;
            this.dgvRaceCellCycle.Name = "dgvRaceCellCycle";
            this.dgvRaceCellCycle.ReadOnly = true;
            this.dgvRaceCellCycle.Width = 250;
            // 
            // dgvRaceCellCycleTime
            // 
            this.dgvRaceCellCycleTime.HeaderText = "Время круга";
            this.dgvRaceCellCycleTime.MinimumWidth = 12;
            this.dgvRaceCellCycleTime.Name = "dgvRaceCellCycleTime";
            this.dgvRaceCellCycleTime.ReadOnly = true;
            this.dgvRaceCellCycleTime.Width = 250;
            // 
            // dgvRaceCellBestTime
            // 
            this.dgvRaceCellBestTime.HeaderText = "Лучшее время";
            this.dgvRaceCellBestTime.MinimumWidth = 12;
            this.dgvRaceCellBestTime.Name = "dgvRaceCellBestTime";
            this.dgvRaceCellBestTime.ReadOnly = true;
            this.dgvRaceCellBestTime.Width = 105;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.groupBox_ant);
            this.tabPage3.Controls.Add(this.button_Read);
            this.tabPage3.Controls.Add(this.maskedTextBox_reader_ip);
            this.tabPage3.Controls.Add(this.checkBox_Simulator);
            this.tabPage3.Controls.Add(this.button_disconnect);
            this.tabPage3.Controls.Add(this.button_connect);
            this.tabPage3.Controls.Add(this.numericUpDown_reader_port);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage3.Size = new System.Drawing.Size(1879, 1518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(885, 29);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(2663, 1020);
            this.richTextBox1.TabIndex = 33;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox_ant
            // 
            this.groupBox_ant.Controls.Add(this.checkBox_ant4);
            this.groupBox_ant.Controls.Add(this.checkBox_ant3);
            this.groupBox_ant.Controls.Add(this.checkBox_ant2);
            this.groupBox_ant.Controls.Add(this.checkBox_ant1);
            this.groupBox_ant.Location = new System.Drawing.Point(21, 93);
            this.groupBox_ant.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox_ant.Name = "groupBox_ant";
            this.groupBox_ant.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox_ant.Size = new System.Drawing.Size(608, 114);
            this.groupBox_ant.TabIndex = 30;
            this.groupBox_ant.TabStop = false;
            this.groupBox_ant.Text = "Антены";
            // 
            // checkBox_ant4
            // 
            this.checkBox_ant4.AutoSize = true;
            this.checkBox_ant4.Location = new System.Drawing.Point(464, 45);
            this.checkBox_ant4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_ant4.Name = "checkBox_ant4";
            this.checkBox_ant4.Size = new System.Drawing.Size(117, 36);
            this.checkBox_ant4.TabIndex = 3;
            this.checkBox_ant4.Tag = "8";
            this.checkBox_ant4.Text = "Ант4";
            this.checkBox_ant4.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant3
            // 
            this.checkBox_ant3.AutoSize = true;
            this.checkBox_ant3.Location = new System.Drawing.Point(315, 45);
            this.checkBox_ant3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_ant3.Name = "checkBox_ant3";
            this.checkBox_ant3.Size = new System.Drawing.Size(117, 36);
            this.checkBox_ant3.TabIndex = 2;
            this.checkBox_ant3.Tag = "4";
            this.checkBox_ant3.Text = "Ант3";
            this.checkBox_ant3.UseVisualStyleBackColor = true;
            // 
            // checkBox_ant2
            // 
            this.checkBox_ant2.AutoSize = true;
            this.checkBox_ant2.Location = new System.Drawing.Point(165, 45);
            this.checkBox_ant2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_ant2.Name = "checkBox_ant2";
            this.checkBox_ant2.Size = new System.Drawing.Size(117, 36);
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
            this.checkBox_ant1.Location = new System.Drawing.Point(16, 45);
            this.checkBox_ant1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_ant1.Name = "checkBox_ant1";
            this.checkBox_ant1.Size = new System.Drawing.Size(117, 36);
            this.checkBox_ant1.TabIndex = 0;
            this.checkBox_ant1.Tag = "1";
            this.checkBox_ant1.Text = "Ант1";
            this.checkBox_ant1.UseVisualStyleBackColor = true;
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(245, 246);
            this.button_Read.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(221, 55);
            this.button_Read.TabIndex = 31;
            this.button_Read.Text = "Читать";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // maskedTextBox_reader_ip
            // 
            this.maskedTextBox_reader_ip.Location = new System.Drawing.Point(16, 29);
            this.maskedTextBox_reader_ip.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.maskedTextBox_reader_ip.Name = "maskedTextBox_reader_ip";
            this.maskedTextBox_reader_ip.Size = new System.Drawing.Size(228, 38);
            this.maskedTextBox_reader_ip.TabIndex = 27;
            this.maskedTextBox_reader_ip.Text = "192.168.1.116";
            // 
            // checkBox_Simulator
            // 
            this.checkBox_Simulator.AutoSize = true;
            this.checkBox_Simulator.Location = new System.Drawing.Point(429, 33);
            this.checkBox_Simulator.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBox_Simulator.Name = "checkBox_Simulator";
            this.checkBox_Simulator.Size = new System.Drawing.Size(199, 36);
            this.checkBox_Simulator.TabIndex = 26;
            this.checkBox_Simulator.Text = "Симулятор";
            this.checkBox_Simulator.UseVisualStyleBackColor = true;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(477, 246);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(219, 55);
            this.button_disconnect.TabIndex = 29;
            this.button_disconnect.Text = "Отключить";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(16, 246);
            this.button_connect.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(219, 55);
            this.button_connect.TabIndex = 25;
            this.button_connect.Text = "Подключить";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // numericUpDown_reader_port
            // 
            this.numericUpDown_reader_port.Location = new System.Drawing.Point(267, 31);
            this.numericUpDown_reader_port.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.numericUpDown_reader_port.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numericUpDown_reader_port.Name = "numericUpDown_reader_port";
            this.numericUpDown_reader_port.Size = new System.Drawing.Size(147, 38);
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
            // timerUpdateRaceView
            // 
            this.timerUpdateRaceView.Enabled = true;
            this.timerUpdateRaceView.Tick += new System.EventHandler(this.timerUpdateRaceView_Tick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TID1";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "TID2";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Age";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "1";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "2";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 20;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "3";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 20;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.HeaderText = "4";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 20;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.HeaderText = "5";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 12;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Width = 20;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 12;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // TID1
            // 
            this.TID1.HeaderText = "TID1";
            this.TID1.MinimumWidth = 12;
            this.TID1.Name = "TID1";
            this.TID1.Width = 250;
            // 
            // TID2
            // 
            this.TID2.HeaderText = "TID2";
            this.TID2.MinimumWidth = 12;
            this.TID2.Name = "TID2";
            this.TID2.Width = 250;
            // 
            // RacingNumber
            // 
            this.RacingNumber.HeaderText = "Номер";
            this.RacingNumber.MinimumWidth = 12;
            this.RacingNumber.Name = "RacingNumber";
            this.RacingNumber.Width = 50;
            // 
            // SecondName
            // 
            this.SecondName.HeaderText = "Фамилия";
            this.SecondName.MinimumWidth = 12;
            this.SecondName.Name = "SecondName";
            this.SecondName.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 12;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 200;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 12;
            this.Age.Name = "Age";
            this.Age.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Age.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // Race1
            // 
            this.Race1.HeaderText = "1";
            this.Race1.MinimumWidth = 12;
            this.Race1.Name = "Race1";
            this.Race1.Width = 20;
            // 
            // Race2
            // 
            this.Race2.HeaderText = "2";
            this.Race2.MinimumWidth = 12;
            this.Race2.Name = "Race2";
            this.Race2.Width = 20;
            // 
            // Race3
            // 
            this.Race3.HeaderText = "3";
            this.Race3.MinimumWidth = 12;
            this.Race3.Name = "Race3";
            this.Race3.Width = 20;
            // 
            // Race4
            // 
            this.Race4.HeaderText = "4";
            this.Race4.MinimumWidth = 12;
            this.Race4.Name = "Race4";
            this.Race4.Width = 20;
            // 
            // Race5
            // 
            this.Race5.HeaderText = "5";
            this.Race5.MinimumWidth = 12;
            this.Race5.Name = "Race5";
            this.Race5.Width = 20;
            // 
            // DT
            // 
            this.DT.HeaderText = "Дата";
            this.DT.MinimumWidth = 12;
            this.DT.Name = "DT";
            this.DT.ReadOnly = true;
            this.DT.Width = 130;
            // 
            // Note
            // 
            this.Note.HeaderText = "Заметка";
            this.Note.MinimumWidth = 12;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 250;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1576);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FormMain";
            this.Text = "Хронометраж";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonActive)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRace)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox_ant.ResumeLayout(false);
            this.groupBox_ant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_reader_port)).EndInit();
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
        private System.Windows.Forms.Timer timerRemoveOldRecords;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clearAllRacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SelectRaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_SelectRace;
        private DataGridViewPersonTag dgvRace;
        private System.Windows.Forms.Button button_RaceStop;
        private System.Windows.Forms.Button button_RaceStart;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.Timer timerUpdateRaceView;
        private System.Windows.Forms.DataGridView dgvRacerData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleDeltaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CycleDT;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellNuber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellCycleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaceCellBestTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_TimeStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TimeRace;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_log2;
        private System.Windows.Forms.CheckBox checkBox_FullLog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DataGridViewPersonTag dgvPerson;
        private DataGridViewPersonTag dgvPersonActive;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}